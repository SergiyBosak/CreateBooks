using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Diagnostics;
using System.IO;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

using MigraDoc;

using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;

namespace CreateBooks
{
    public partial class MainForm : Form
    {
        BooksContext db;
        ChapterForm chapterForm;
        static int selectBook;

        public MainForm()
        {
            InitializeComponent();

            db = new BooksContext();

            visibleBooks();

            visibleChapters(0);

            settingDataGridChapters();
        }

        private void visibleBooks()
        {
            db.Books.Load();

            dGVBooks.DataSource = db.Books.Local.ToBindingList();

            dGVBooks.Columns["Id"].Visible = false;
            dGVBooks.Columns["Chapters"].Visible = false;
            dGVBooks.Columns["Title"].HeaderText = "Название книги";
            dGVBooks.Columns["Autor"].HeaderText = "Автор";
            dGVBooks.Columns["Title"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGVBooks.ReadOnly = true;

            dGVBooks.AllowUserToAddRows = false;
            dGVBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void BtnCreateBook_Click(object sender, EventArgs e)
        {
            Book book = new Book();

            string stringError = string.Empty;

            bool isError = false;

            if (tBTitleBook.Text == string.Empty)
            {
                isError = true;
                stringError = "Введите название книги\r\n";
            }
            if (tBAutor.Text == string.Empty)
            {
                isError = true;
                stringError += "Введите автора\r\n";
            }

            if (isError)
            {
                MessageBox.Show(stringError, "Пустые строки", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            book.Title = tBTitleBook.Text;

            book.Autor = tBAutor.Text;

            db.Books.Add(book);

            db.SaveChanges();

            tBTitleBook.Clear();
            tBAutor.Clear();
        }

        private void BtnDropBook_Click(object sender, EventArgs e)
        {
            if (dGVBooks.SelectedRows.Count > 0)
            {
                int index = dGVBooks.SelectedRows[0].Index;

                Book book = db.Books.Find(dGVBooks["Id", index].Value);

                var qvery = from item in db.Chapters.Local.ToList()
                            where item.BookId == Convert.ToInt32(dGVBooks["Id", index].Value)
                            select item;

                foreach (var item in qvery)
                {
                    db.Chapters.Remove(item);
                }

                db.Books.Remove(book);

                db.SaveChanges();

                visibleBooks();

                settingDataGridChapters();

                visibleChapters(0);

                //dGVChapters.DataSource = null;
            }          
        }

        void visibleChapters()
        {
            db.Chapters.Load();

            int index = dGVBooks.SelectedRows[0].Index;

            var qvery = from item in db.Chapters.Local.ToList()
                        where item.BookId == Convert.ToInt32(dGVBooks["Id", index].Value)
                        orderby item.ChapterNumber
                        select item;

            dGVChapters.DataSource = qvery.ToList();
        }

        private void settingDataGridChapters()
        {

            dGVChapters.Columns["Id"].Visible = false;
            dGVChapters.Columns["Text"].Visible = false;
            dGVChapters.Columns["BookId"].Visible = false;
            dGVChapters.Columns["Book"].Visible = false;
            dGVChapters.Columns["ChapterNumber"].HeaderText = "Номер";
            dGVChapters.Columns["ChapterNumber"].Width = 50;
            dGVChapters.Columns["Title"].HeaderText = "Глава";
            dGVChapters.Columns["Title"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dGVChapters.ReadOnly = true;

            dGVChapters.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        void visibleChapters(int index)
        {
            db.Chapters.Load();

            var qvery = from item in db.Chapters.Local.ToList()
                        where item.BookId == Convert.ToInt32(dGVBooks["Id", index].Value)
                        orderby item.ChapterNumber
                        select item;

            dGVChapters.DataSource = qvery.ToList();
        }

        private void BtnAddChapter_Click(object sender, EventArgs e)
        {
            if (dGVBooks.SelectedRows.Count > 0)
            {
                chapterForm = new ChapterForm();

                int index = dGVBooks.SelectedRows[0].Index;

                selectBook = Convert.ToInt32(dGVBooks["Id", index].Value);

                chapterForm.ShowDialog();

                if (chapterForm.DialogResult == DialogResult.OK)
                {
                    Chapter chapter = new Chapter();

                    chapter.Title = chapterForm.tBCapterTitle.Text;
                    chapter.BookId = Convert.ToInt32(dGVBooks["Id", index].Value);
                    chapter.ChapterNumber = (int)chapterForm.nUpDNumberChapter.Value;

                    var qvery = from item in db.Chapters.Local.ToList()
                                where item.BookId == Convert.ToInt32(dGVBooks["Id", index].Value)
                                select item.ChapterNumber;

                    chapter.Text = chapterForm.tBChapterText.Text;

                    db.Chapters.Add(chapter);

                    db.SaveChanges();

                    visibleChapters();
                }
            }           
        }

        public List<int> CheckQvery()
        {
            db.Chapters.Load();

            var qvery = from item in db.Chapters.Local.ToList()
                        where item.BookId == selectBook
                        select item.ChapterNumber;

            return qvery.ToList();
        }

        private void DGVChapters_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            editChapters();
        }

        private void editChapters()
        {
            if (dGVChapters.SelectedRows.Count > 0)
            {
                ChapterForm chapterForm = new ChapterForm();

                int index = dGVChapters.SelectedRows[0].Index;

                chapterForm.tBChapterText.Text = (string)dGVChapters["Text", index].Value;

                chapterForm.tBCapterTitle.Text = (string)dGVChapters["Title", index].Value;

                chapterForm.nUpDNumberChapter.Value = (int)dGVChapters["ChapterNumber", index].Value;

                chapterForm.ShowDialog();

                Chapter chapter = db.Chapters.Find((int)dGVChapters["Id", index].Value);

                chapter.Text = chapterForm.tBChapterText.Text;

                chapter.Title = chapterForm.tBCapterTitle.Text;

                chapter.ChapterNumber = (int)chapterForm.nUpDNumberChapter.Value;

                db.Entry(chapter).State = EntityState.Modified;

                db.SaveChanges();
            }         
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (dGVChapters.SelectedRows.Count > 0)
            {
                int index = dGVChapters.SelectedRows[0].Index;

                Chapter chapter = db.Chapters.Find((int)dGVChapters["Id", index].Value);

                db.Chapters.Remove(chapter);

                db.SaveChanges();

                visibleChapters();
            } 
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            if (dGVBooks.SelectedRows.Count > 0)
            {
                db.Chapters.Load();

                db.Books.Load();

                int index = dGVBooks.SelectedRows[0].Index;

                var bookTitle = from item in db.Books.Local.ToList()
                                where item.Id == Convert.ToInt32(dGVBooks["Id", index].Value)
                                select item;

                var qvery = from item in db.Chapters.Local.ToList()
                            where item.BookId == Convert.ToInt32(dGVBooks["Id", index].Value)
                            select item;

                Document document2 = new Document();

                string filePath = string.Empty;

                foreach (var item in bookTitle)
                {
                    filePath = item.Title;
                }

                Section section = document2.AddSection();

                section.PageSetup.PageFormat = PageFormat.A4;
                section.PageSetup.Orientation = MigraDoc.DocumentObjectModel.Orientation.Portrait;
                section.PageSetup.BottomMargin = 10;
                section.PageSetup.TopMargin = 30;

                foreach (var item in qvery)
                {
                    Paragraph paragraph = section.AddParagraph();

                    FormattedText formattedText = new FormattedText();

                    formattedText.Font.Color = MigraDoc.DocumentObjectModel.Color.FromCmyk(100, 30, 20, 50);
                    formattedText.Font.Size = 17;
                    formattedText.Font.Bold = true;
                    formattedText.Underline = Underline.Single;

                    formattedText.AddText(item.Title);

                    paragraph.Add(formattedText);

                    paragraph.AddText("\r\n\r\n" + item.Text + "\r\n\r\n\r\n");
                }

                PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer(true, PdfFontEmbedding.Always);

                pdfRenderer.Document = document2;

                pdfRenderer.RenderDocument();

                pdfRenderer.PdfDocument.Save(filePath);

                Process.Start(filePath);
            }           
        }

        private void BtnEditBook_Click(object sender, EventArgs e)
        {
            db.Books.Load();           
        }

        private void DGVBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            visibleChapters();
        }

        private void BtnEditChapter_Click(object sender, EventArgs e)
        {
            editChapters();
        }
    }
}

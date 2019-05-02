namespace CreateBooks
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tBTitleBook = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddChapter = new System.Windows.Forms.Button();
            this.btnEditChapter = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnCreateBook = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tBAutor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dGVBooks = new System.Windows.Forms.DataGridView();
            this.btnDropBook = new System.Windows.Forms.Button();
            this.btnEditBook = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dGVChapters = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVBooks)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVChapters)).BeginInit();
            this.SuspendLayout();
            // 
            // tBTitleBook
            // 
            this.tBTitleBook.Location = new System.Drawing.Point(210, 21);
            this.tBTitleBook.Name = "tBTitleBook";
            this.tBTitleBook.Size = new System.Drawing.Size(234, 20);
            this.tBTitleBook.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Название книги";
            // 
            // btnAddChapter
            // 
            this.btnAddChapter.Location = new System.Drawing.Point(6, 237);
            this.btnAddChapter.Name = "btnAddChapter";
            this.btnAddChapter.Size = new System.Drawing.Size(70, 23);
            this.btnAddChapter.TabIndex = 4;
            this.btnAddChapter.Text = "Добавить главу";
            this.btnAddChapter.UseVisualStyleBackColor = true;
            this.btnAddChapter.Click += new System.EventHandler(this.BtnAddChapter_Click);
            // 
            // btnEditChapter
            // 
            this.btnEditChapter.Location = new System.Drawing.Point(82, 237);
            this.btnEditChapter.Name = "btnEditChapter";
            this.btnEditChapter.Size = new System.Drawing.Size(99, 23);
            this.btnEditChapter.TabIndex = 6;
            this.btnEditChapter.Text = "Редактировать";
            this.btnEditChapter.UseVisualStyleBackColor = true;
            this.btnEditChapter.Click += new System.EventHandler(this.BtnEditChapter_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(187, 237);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // btnCreateBook
            // 
            this.btnCreateBook.Location = new System.Drawing.Point(6, 19);
            this.btnCreateBook.Name = "btnCreateBook";
            this.btnCreateBook.Size = new System.Drawing.Size(98, 23);
            this.btnCreateBook.TabIndex = 10;
            this.btnCreateBook.Text = "Создать книгу";
            this.btnCreateBook.UseVisualStyleBackColor = true;
            this.btnCreateBook.Click += new System.EventHandler(this.BtnCreateBook_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tBAutor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCreateBook);
            this.groupBox1.Controls.Add(this.tBTitleBook);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(680, 49);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Создание книги";
            // 
            // tBAutor
            // 
            this.tBAutor.Location = new System.Drawing.Point(494, 21);
            this.tBAutor.Name = "tBAutor";
            this.tBAutor.Size = new System.Drawing.Size(177, 20);
            this.tBAutor.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(450, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Автор";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dGVBooks);
            this.groupBox2.Controls.Add(this.btnDropBook);
            this.groupBox2.Controls.Add(this.btnEditBook);
            this.groupBox2.Controls.Add(this.btnExport);
            this.groupBox2.Location = new System.Drawing.Point(12, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 267);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выбрать книгу";
            // 
            // dGVBooks
            // 
            this.dGVBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVBooks.Location = new System.Drawing.Point(6, 19);
            this.dGVBooks.Name = "dGVBooks";
            this.dGVBooks.Size = new System.Drawing.Size(327, 212);
            this.dGVBooks.TabIndex = 12;
            this.dGVBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVBooks_CellClick);
            // 
            // btnDropBook
            // 
            this.btnDropBook.Location = new System.Drawing.Point(191, 237);
            this.btnDropBook.Name = "btnDropBook";
            this.btnDropBook.Size = new System.Drawing.Size(75, 23);
            this.btnDropBook.TabIndex = 11;
            this.btnDropBook.Text = "Удалить";
            this.btnDropBook.UseVisualStyleBackColor = true;
            this.btnDropBook.Click += new System.EventHandler(this.BtnDropBook_Click);
            // 
            // btnEditBook
            // 
            this.btnEditBook.Location = new System.Drawing.Point(6, 237);
            this.btnEditBook.Name = "btnEditBook";
            this.btnEditBook.Size = new System.Drawing.Size(98, 23);
            this.btnEditBook.TabIndex = 10;
            this.btnEditBook.Text = "Редактировать";
            this.btnEditBook.UseVisualStyleBackColor = true;
            this.btnEditBook.Click += new System.EventHandler(this.BtnEditBook_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(110, 237);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 9;
            this.btnExport.Text = "Экспорт";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dGVChapters);
            this.groupBox3.Controls.Add(this.btnAddChapter);
            this.groupBox3.Controls.Add(this.btnEditChapter);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Location = new System.Drawing.Point(364, 67);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(329, 267);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Главы";
            // 
            // dGVChapters
            // 
            this.dGVChapters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVChapters.Location = new System.Drawing.Point(6, 19);
            this.dGVChapters.Name = "dGVChapters";
            this.dGVChapters.Size = new System.Drawing.Size(317, 212);
            this.dGVChapters.TabIndex = 8;
            this.dGVChapters.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVChapters_CellDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 347);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "CreateBooks";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVBooks)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVChapters)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tBTitleBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddChapter;
        private System.Windows.Forms.Button btnEditChapter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnCreateBook;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDropBook;
        private System.Windows.Forms.Button btnEditBook;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dGVChapters;
        private System.Windows.Forms.DataGridView dGVBooks;
        private System.Windows.Forms.TextBox tBAutor;
        private System.Windows.Forms.Label label1;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CreateBooks
{
    public partial class ChapterForm : Form
    {

        public ChapterForm()
        {
            InitializeComponent();

            nUpDNumberChapter.Value = 0;
        }

        private void BtnSaveChapter_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();

            if (CheckChapter(mainForm.CheckQvery()))
            {
                MessageBox.Show("Глава с данным номером уже существует");
                return;
            }

            this.DialogResult = DialogResult.OK;     
        }

        public bool CheckChapter(List<int> qvery)
        {
            foreach (int item in qvery)
            {
                if (item == (int)nUpDNumberChapter.Value)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

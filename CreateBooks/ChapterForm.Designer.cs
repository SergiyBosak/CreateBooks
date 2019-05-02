namespace CreateBooks
{
    partial class ChapterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tBCapterTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nUpDNumberChapter = new System.Windows.Forms.NumericUpDown();
            this.tBChapterText = new System.Windows.Forms.TextBox();
            this.btnSaveChapter = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDNumberChapter)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название главы";
            // 
            // tBCapterTitle
            // 
            this.tBCapterTitle.Location = new System.Drawing.Point(12, 30);
            this.tBCapterTitle.Multiline = true;
            this.tBCapterTitle.Name = "tBCapterTitle";
            this.tBCapterTitle.Size = new System.Drawing.Size(199, 20);
            this.tBCapterTitle.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Содержание главы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Номер главы";
            // 
            // nUpDNumberChapter
            // 
            this.nUpDNumberChapter.Location = new System.Drawing.Point(217, 30);
            this.nUpDNumberChapter.Name = "nUpDNumberChapter";
            this.nUpDNumberChapter.Size = new System.Drawing.Size(129, 20);
            this.nUpDNumberChapter.TabIndex = 4;
            // 
            // tBChapterText
            // 
            this.tBChapterText.Location = new System.Drawing.Point(12, 78);
            this.tBChapterText.Multiline = true;
            this.tBChapterText.Name = "tBChapterText";
            this.tBChapterText.Size = new System.Drawing.Size(334, 249);
            this.tBChapterText.TabIndex = 5;
            // 
            // btnSaveChapter
            // 
            this.btnSaveChapter.Location = new System.Drawing.Point(12, 333);
            this.btnSaveChapter.Name = "btnSaveChapter";
            this.btnSaveChapter.Size = new System.Drawing.Size(75, 23);
            this.btnSaveChapter.TabIndex = 6;
            this.btnSaveChapter.Text = "Добавить";
            this.btnSaveChapter.UseVisualStyleBackColor = true;
            this.btnSaveChapter.Click += new System.EventHandler(this.BtnSaveChapter_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(93, 333);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Отмена";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // ChapterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 365);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSaveChapter);
            this.Controls.Add(this.tBChapterText);
            this.Controls.Add(this.nUpDNumberChapter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBCapterTitle);
            this.Controls.Add(this.label1);
            this.Name = "ChapterForm";
            this.Text = "ChapterForm";
            ((System.ComponentModel.ISupportInitialize)(this.nUpDNumberChapter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tBCapterTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.NumericUpDown nUpDNumberChapter;
        public System.Windows.Forms.TextBox tBChapterText;
        private System.Windows.Forms.Button btnSaveChapter;
        private System.Windows.Forms.Button btnClose;
    }
}
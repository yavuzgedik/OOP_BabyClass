namespace Baby_WinForms
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.isimTxtBox = new System.Windows.Forms.TextBox();
            this.soyisimTxtBox = new System.Windows.Forms.TextBox();
            this.yasTxtBox = new System.Windows.Forms.TextBox();
            this.EkleBtn = new System.Windows.Forms.Button();
            this.BabyList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyisim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yaş";
            // 
            // isimTxtBox
            // 
            this.isimTxtBox.Location = new System.Drawing.Point(3, 16);
            this.isimTxtBox.Name = "isimTxtBox";
            this.isimTxtBox.Size = new System.Drawing.Size(100, 20);
            this.isimTxtBox.TabIndex = 3;
            // 
            // soyisimTxtBox
            // 
            this.soyisimTxtBox.Location = new System.Drawing.Point(3, 55);
            this.soyisimTxtBox.Name = "soyisimTxtBox";
            this.soyisimTxtBox.Size = new System.Drawing.Size(100, 20);
            this.soyisimTxtBox.TabIndex = 4;
            // 
            // yasTxtBox
            // 
            this.yasTxtBox.Location = new System.Drawing.Point(3, 94);
            this.yasTxtBox.Name = "yasTxtBox";
            this.yasTxtBox.Size = new System.Drawing.Size(100, 20);
            this.yasTxtBox.TabIndex = 5;
            // 
            // EkleBtn
            // 
            this.EkleBtn.Location = new System.Drawing.Point(3, 120);
            this.EkleBtn.Name = "EkleBtn";
            this.EkleBtn.Size = new System.Drawing.Size(100, 23);
            this.EkleBtn.TabIndex = 6;
            this.EkleBtn.Text = "Ekle";
            this.EkleBtn.UseVisualStyleBackColor = true;
            this.EkleBtn.Click += new System.EventHandler(this.EkleBtn_Click);
            // 
            // BabyList
            // 
            this.BabyList.FormattingEnabled = true;
            this.BabyList.Location = new System.Drawing.Point(117, 18);
            this.BabyList.Name = "BabyList";
            this.BabyList.Size = new System.Drawing.Size(150, 121);
            this.BabyList.TabIndex = 7;
            this.BabyList.DoubleClick += new System.EventHandler(this.BabyList_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BabyList);
            this.Controls.Add(this.EkleBtn);
            this.Controls.Add(this.yasTxtBox);
            this.Controls.Add(this.soyisimTxtBox);
            this.Controls.Add(this.isimTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox isimTxtBox;
        private System.Windows.Forms.TextBox soyisimTxtBox;
        private System.Windows.Forms.TextBox yasTxtBox;
        private System.Windows.Forms.Button EkleBtn;
        private System.Windows.Forms.ListBox BabyList;
    }
}


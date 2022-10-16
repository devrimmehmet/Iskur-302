namespace Banka_Uygulamasi
{
    partial class GirisSifreli
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tB_KullaniciAdi = new System.Windows.Forms.TextBox();
            this.tB_Sifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tB_Sifre);
            this.groupBox2.Controls.Add(this.tB_KullaniciAdi);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 146);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kurumsal";
            // 
            // tB_KullaniciAdi
            // 
            this.tB_KullaniciAdi.Location = new System.Drawing.Point(140, 30);
            this.tB_KullaniciAdi.Name = "tB_KullaniciAdi";
            this.tB_KullaniciAdi.Size = new System.Drawing.Size(203, 31);
            this.tB_KullaniciAdi.TabIndex = 0;
            // 
            // tB_Sifre
            // 
            this.tB_Sifre.Location = new System.Drawing.Point(140, 67);
            this.tB_Sifre.Name = "tB_Sifre";
            this.tB_Sifre.Size = new System.Drawing.Size(203, 31);
            this.tB_Sifre.TabIndex = 1;
            this.tB_Sifre.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Şirket Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Giriş Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GirisSifreli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(419, 164);
            this.Controls.Add(this.groupBox2);
            this.Name = "GirisSifreli";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kurumsal Bankacılık";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tB_Sifre;
        private System.Windows.Forms.TextBox tB_KullaniciAdi;
    }
}
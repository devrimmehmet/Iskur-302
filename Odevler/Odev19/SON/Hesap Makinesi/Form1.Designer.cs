namespace Hesap_Makinesi
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
            this.btn_Esittir = new System.Windows.Forms.Button();
            this.btn_Toplama = new System.Windows.Forms.Button();
            this.btn_Virgul = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_Cikarma = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_Carpma = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_Bolme = new System.Windows.Forms.Button();
            this.btn_Geri = new System.Windows.Forms.Button();
            this.btn_C = new System.Windows.Forms.Button();
            this.lbl_Sonuc = new System.Windows.Forms.Label();
            this.txt_Sonuc = new System.Windows.Forms.TextBox();
            this.btn_CE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Esittir
            // 
            this.btn_Esittir.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Esittir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Esittir.Location = new System.Drawing.Point(21, 323);
            this.btn_Esittir.Name = "btn_Esittir";
            this.btn_Esittir.Size = new System.Drawing.Size(214, 51);
            this.btn_Esittir.TabIndex = 38;
            this.btn_Esittir.Text = "=";
            this.btn_Esittir.UseVisualStyleBackColor = false;
            this.btn_Esittir.Click += new System.EventHandler(this.btn_Esittir_Click);
            this.btn_Esittir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressforAllButtons);
            // 
            // btn_Toplama
            // 
            this.btn_Toplama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Toplama.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Toplama.Location = new System.Drawing.Point(186, 227);
            this.btn_Toplama.Name = "btn_Toplama";
            this.btn_Toplama.Size = new System.Drawing.Size(49, 90);
            this.btn_Toplama.TabIndex = 36;
            this.btn_Toplama.Text = "+";
            this.btn_Toplama.UseVisualStyleBackColor = false;
            this.btn_Toplama.Click += new System.EventHandler(this.Click_Islem);
            this.btn_Toplama.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressforAllButtons);
            // 
            // btn_Virgul
            // 
            this.btn_Virgul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Virgul.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Virgul.Location = new System.Drawing.Point(131, 275);
            this.btn_Virgul.Name = "btn_Virgul";
            this.btn_Virgul.Size = new System.Drawing.Size(49, 42);
            this.btn_Virgul.TabIndex = 35;
            this.btn_Virgul.Text = ",";
            this.btn_Virgul.UseVisualStyleBackColor = false;
            this.btn_Virgul.Click += new System.EventHandler(this.btn_Virgul_Click);
            this.btn_Virgul.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressforAllButtons);
            // 
            // btn_0
            // 
            this.btn_0.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_0.Location = new System.Drawing.Point(21, 275);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(104, 42);
            this.btn_0.TabIndex = 34;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = false;
            this.btn_0.Click += new System.EventHandler(this.Click_Rakam);
            this.btn_0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressforAllButtons);
            // 
            // btn_3
            // 
            this.btn_3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_3.Location = new System.Drawing.Point(131, 226);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(49, 43);
            this.btn_3.TabIndex = 33;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = false;
            this.btn_3.Click += new System.EventHandler(this.Click_Rakam);
            this.btn_3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressforAllButtons);
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_2.Location = new System.Drawing.Point(76, 226);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(49, 43);
            this.btn_2.TabIndex = 32;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = false;
            this.btn_2.Click += new System.EventHandler(this.Click_Rakam);
            this.btn_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressforAllButtons);
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_1.Location = new System.Drawing.Point(21, 226);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(49, 43);
            this.btn_1.TabIndex = 31;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.Click_Rakam);
            this.btn_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressforAllButtons);
            // 
            // btn_Cikarma
            // 
            this.btn_Cikarma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Cikarma.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Cikarma.Location = new System.Drawing.Point(186, 177);
            this.btn_Cikarma.Name = "btn_Cikarma";
            this.btn_Cikarma.Size = new System.Drawing.Size(49, 43);
            this.btn_Cikarma.TabIndex = 30;
            this.btn_Cikarma.Text = "-";
            this.btn_Cikarma.UseVisualStyleBackColor = false;
            this.btn_Cikarma.Click += new System.EventHandler(this.Click_Islem);
            this.btn_Cikarma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressforAllButtons);
            // 
            // btn_6
            // 
            this.btn_6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_6.Location = new System.Drawing.Point(131, 177);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(49, 43);
            this.btn_6.TabIndex = 29;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = false;
            this.btn_6.Click += new System.EventHandler(this.Click_Rakam);
            this.btn_6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressforAllButtons);
            // 
            // btn_5
            // 
            this.btn_5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_5.Location = new System.Drawing.Point(76, 177);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(49, 43);
            this.btn_5.TabIndex = 28;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = false;
            this.btn_5.Click += new System.EventHandler(this.Click_Rakam);
            this.btn_5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressforAllButtons);
            // 
            // btn_4
            // 
            this.btn_4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_4.Location = new System.Drawing.Point(21, 177);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(49, 43);
            this.btn_4.TabIndex = 27;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = false;
            this.btn_4.Click += new System.EventHandler(this.Click_Rakam);
            this.btn_4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressforAllButtons);
            // 
            // btn_Carpma
            // 
            this.btn_Carpma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Carpma.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Carpma.Location = new System.Drawing.Point(186, 128);
            this.btn_Carpma.Name = "btn_Carpma";
            this.btn_Carpma.Size = new System.Drawing.Size(49, 43);
            this.btn_Carpma.TabIndex = 26;
            this.btn_Carpma.Text = "*";
            this.btn_Carpma.UseVisualStyleBackColor = false;
            this.btn_Carpma.Click += new System.EventHandler(this.Click_Islem);
            this.btn_Carpma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressforAllButtons);
            // 
            // btn_9
            // 
            this.btn_9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_9.Location = new System.Drawing.Point(131, 128);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(49, 43);
            this.btn_9.TabIndex = 25;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = false;
            this.btn_9.Click += new System.EventHandler(this.Click_Rakam);
            this.btn_9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressforAllButtons);
            // 
            // btn_8
            // 
            this.btn_8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_8.Location = new System.Drawing.Point(76, 128);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(49, 43);
            this.btn_8.TabIndex = 24;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = false;
            this.btn_8.Click += new System.EventHandler(this.Click_Rakam);
            this.btn_8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressforAllButtons);
            // 
            // btn_7
            // 
            this.btn_7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_7.Location = new System.Drawing.Point(21, 128);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(49, 43);
            this.btn_7.TabIndex = 23;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = false;
            this.btn_7.Click += new System.EventHandler(this.Click_Rakam);
            this.btn_7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressforAllButtons);
            // 
            // btn_Bolme
            // 
            this.btn_Bolme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Bolme.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Bolme.Location = new System.Drawing.Point(186, 79);
            this.btn_Bolme.Name = "btn_Bolme";
            this.btn_Bolme.Size = new System.Drawing.Size(49, 43);
            this.btn_Bolme.TabIndex = 22;
            this.btn_Bolme.Text = "/";
            this.btn_Bolme.UseVisualStyleBackColor = false;
            this.btn_Bolme.Click += new System.EventHandler(this.Click_Islem);
            this.btn_Bolme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressforAllButtons);
            // 
            // btn_Geri
            // 
            this.btn_Geri.BackColor = System.Drawing.Color.Yellow;
            this.btn_Geri.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Geri.Location = new System.Drawing.Point(131, 79);
            this.btn_Geri.Name = "btn_Geri";
            this.btn_Geri.Size = new System.Drawing.Size(49, 43);
            this.btn_Geri.TabIndex = 21;
            this.btn_Geri.Text = "<";
            this.btn_Geri.UseVisualStyleBackColor = false;
            this.btn_Geri.Click += new System.EventHandler(this.btn_Geri_Click);
            this.btn_Geri.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressforAllButtons);
            // 
            // btn_C
            // 
            this.btn_C.BackColor = System.Drawing.Color.Yellow;
            this.btn_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_C.Location = new System.Drawing.Point(21, 79);
            this.btn_C.Name = "btn_C";
            this.btn_C.Size = new System.Drawing.Size(49, 43);
            this.btn_C.TabIndex = 20;
            this.btn_C.Text = "C";
            this.btn_C.UseVisualStyleBackColor = false;
            this.btn_C.Click += new System.EventHandler(this.btn_C_Click);
            this.btn_C.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressforAllButtons);
            // 
            // lbl_Sonuc
            // 
            this.lbl_Sonuc.AllowDrop = true;
            this.lbl_Sonuc.Location = new System.Drawing.Point(21, 10);
            this.lbl_Sonuc.Name = "lbl_Sonuc";
            this.lbl_Sonuc.Size = new System.Drawing.Size(214, 30);
            this.lbl_Sonuc.TabIndex = 39;
            this.lbl_Sonuc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_Sonuc
            // 
            this.txt_Sonuc.Enabled = false;
            this.txt_Sonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Sonuc.Location = new System.Drawing.Point(21, 43);
            this.txt_Sonuc.Multiline = true;
            this.txt_Sonuc.Name = "txt_Sonuc";
            this.txt_Sonuc.Size = new System.Drawing.Size(214, 30);
            this.txt_Sonuc.TabIndex = 40;
            this.txt_Sonuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_CE
            // 
            this.btn_CE.BackColor = System.Drawing.Color.Yellow;
            this.btn_CE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_CE.Location = new System.Drawing.Point(76, 79);
            this.btn_CE.Name = "btn_CE";
            this.btn_CE.Size = new System.Drawing.Size(49, 43);
            this.btn_CE.TabIndex = 41;
            this.btn_CE.Text = "CE";
            this.btn_CE.UseVisualStyleBackColor = false;
            this.btn_CE.Click += new System.EventHandler(this.btn_CE_Click);
            this.btn_CE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressforAllButtons);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 386);
            this.Controls.Add(this.btn_CE);
            this.Controls.Add(this.lbl_Sonuc);
            this.Controls.Add(this.btn_Esittir);
            this.Controls.Add(this.btn_Toplama);
            this.Controls.Add(this.btn_Virgul);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_Cikarma);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_Carpma);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_Bolme);
            this.Controls.Add(this.btn_Geri);
            this.Controls.Add(this.btn_C);
            this.Controls.Add(this.txt_Sonuc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hesap Makinesi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Esittir;
        private System.Windows.Forms.Button btn_Toplama;
        private System.Windows.Forms.Button btn_Virgul;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_Cikarma;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_Carpma;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_Bolme;
        private System.Windows.Forms.Button btn_Geri;
        private System.Windows.Forms.Button btn_C;
        private System.Windows.Forms.Label lbl_Sonuc;
        protected internal System.Windows.Forms.TextBox txt_Sonuc;
        private System.Windows.Forms.Button btn_CE;
    }
}




namespace WindowsFormsApp1
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
            this.btn_kare = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_dikdortgen = new System.Windows.Forms.Button();
            this.btn_ucgen = new System.Windows.Forms.Button();
            this.btn_daire = new System.Windows.Forms.Button();
            this.pnl_verigirisi = new System.Windows.Forms.Panel();
            this.lbl_baslik = new System.Windows.Forms.Label();
            this.lbl_a = new System.Windows.Forms.Label();
            this.tB_a = new System.Windows.Forms.TextBox();
            this.btn_hesapla = new System.Windows.Forms.Button();
            this.lbl_alan = new System.Windows.Forms.Label();
            this.lbl_cevre = new System.Windows.Forms.Label();
            this.pnl_sonuc = new System.Windows.Forms.Panel();
            this.lbl_cevre_yazdir = new System.Windows.Forms.Label();
            this.lbl_alan_yazdir = new System.Windows.Forms.Label();
            this.lbl_hosgeldiniz = new System.Windows.Forms.Label();
            this.tB_b = new System.Windows.Forms.TextBox();
            this.lbl_b = new System.Windows.Forms.Label();
            this.tB_c = new System.Windows.Forms.TextBox();
            this.lbl_c = new System.Windows.Forms.Label();
            this.pnl_verigirisi.SuspendLayout();
            this.pnl_sonuc.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_kare
            // 
            this.btn_kare.BackColor = System.Drawing.Color.Tomato;
            this.btn_kare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kare.ForeColor = System.Drawing.Color.Yellow;
            this.btn_kare.Location = new System.Drawing.Point(19, 55);
            this.btn_kare.Name = "btn_kare";
            this.btn_kare.Size = new System.Drawing.Size(80, 46);
            this.btn_kare.TabIndex = 0;
            this.btn_kare.Text = "Kare";
            this.btn_kare.UseVisualStyleBackColor = false;
            this.btn_kare.Click += new System.EventHandler(this.btn_kare_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alan ve Çevre Hesaplama";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_dikdortgen
            // 
            this.btn_dikdortgen.BackColor = System.Drawing.Color.Tomato;
            this.btn_dikdortgen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_dikdortgen.ForeColor = System.Drawing.Color.Yellow;
            this.btn_dikdortgen.Location = new System.Drawing.Point(105, 55);
            this.btn_dikdortgen.Name = "btn_dikdortgen";
            this.btn_dikdortgen.Size = new System.Drawing.Size(113, 46);
            this.btn_dikdortgen.TabIndex = 2;
            this.btn_dikdortgen.Text = "Dikdörtgen";
            this.btn_dikdortgen.UseVisualStyleBackColor = false;
            this.btn_dikdortgen.Click += new System.EventHandler(this.btn_dikdortgen_Click);
            // 
            // btn_ucgen
            // 
            this.btn_ucgen.BackColor = System.Drawing.Color.Tomato;
            this.btn_ucgen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ucgen.ForeColor = System.Drawing.Color.Yellow;
            this.btn_ucgen.Location = new System.Drawing.Point(224, 55);
            this.btn_ucgen.Name = "btn_ucgen";
            this.btn_ucgen.Size = new System.Drawing.Size(122, 46);
            this.btn_ucgen.TabIndex = 3;
            this.btn_ucgen.Text = "Üçgen";
            this.btn_ucgen.UseVisualStyleBackColor = false;
            this.btn_ucgen.Click += new System.EventHandler(this.btn_ucgen_Click);
            // 
            // btn_daire
            // 
            this.btn_daire.BackColor = System.Drawing.Color.Tomato;
            this.btn_daire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_daire.ForeColor = System.Drawing.Color.Yellow;
            this.btn_daire.Location = new System.Drawing.Point(352, 55);
            this.btn_daire.Name = "btn_daire";
            this.btn_daire.Size = new System.Drawing.Size(108, 46);
            this.btn_daire.TabIndex = 4;
            this.btn_daire.Text = "Daire";
            this.btn_daire.UseVisualStyleBackColor = false;
            this.btn_daire.Click += new System.EventHandler(this.btn_daire_Click);
            // 
            // pnl_verigirisi
            // 
            this.pnl_verigirisi.Controls.Add(this.btn_hesapla);
            this.pnl_verigirisi.Controls.Add(this.tB_c);
            this.pnl_verigirisi.Controls.Add(this.lbl_c);
            this.pnl_verigirisi.Controls.Add(this.tB_b);
            this.pnl_verigirisi.Controls.Add(this.lbl_b);
            this.pnl_verigirisi.Controls.Add(this.tB_a);
            this.pnl_verigirisi.Controls.Add(this.lbl_a);
            this.pnl_verigirisi.Controls.Add(this.lbl_baslik);
            this.pnl_verigirisi.Location = new System.Drawing.Point(19, 107);
            this.pnl_verigirisi.Name = "pnl_verigirisi";
            this.pnl_verigirisi.Size = new System.Drawing.Size(304, 246);
            this.pnl_verigirisi.TabIndex = 6;
            this.pnl_verigirisi.Visible = false;
            // 
            // lbl_baslik
            // 
            this.lbl_baslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_baslik.ForeColor = System.Drawing.Color.Gold;
            this.lbl_baslik.Location = new System.Drawing.Point(3, 10);
            this.lbl_baslik.Name = "lbl_baslik";
            this.lbl_baslik.Size = new System.Drawing.Size(286, 43);
            this.lbl_baslik.TabIndex = 7;
            this.lbl_baslik.Text = "Kare";
            this.lbl_baslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_a
            // 
            this.lbl_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_a.ForeColor = System.Drawing.Color.Gold;
            this.lbl_a.Location = new System.Drawing.Point(6, 53);
            this.lbl_a.Name = "lbl_a";
            this.lbl_a.Size = new System.Drawing.Size(202, 51);
            this.lbl_a.TabIndex = 8;
            this.lbl_a.Text = "Karenin Bir Kenarının Uzunluğunu Giriniz";
            this.lbl_a.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tB_a
            // 
            this.tB_a.AllowDrop = true;
            this.tB_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tB_a.Location = new System.Drawing.Point(201, 65);
            this.tB_a.Multiline = true;
            this.tB_a.Name = "tB_a";
            this.tB_a.Size = new System.Drawing.Size(81, 29);
            this.tB_a.TabIndex = 9;
            this.tB_a.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tB_a.TextChanged += new System.EventHandler(this.tB_a_TextChanged);
            this.tB_a.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tB_a_KeyPress);
            // 
            // btn_hesapla
            // 
            this.btn_hesapla.BackColor = System.Drawing.Color.Red;
            this.btn_hesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hesapla.ForeColor = System.Drawing.Color.Transparent;
            this.btn_hesapla.Location = new System.Drawing.Point(105, 207);
            this.btn_hesapla.Name = "btn_hesapla";
            this.btn_hesapla.Size = new System.Drawing.Size(94, 35);
            this.btn_hesapla.TabIndex = 10;
            this.btn_hesapla.Text = "Hesapla";
            this.btn_hesapla.UseVisualStyleBackColor = false;
            this.btn_hesapla.Click += new System.EventHandler(this.btn_hesapla_Click);
            // 
            // lbl_alan
            // 
            this.lbl_alan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_alan.ForeColor = System.Drawing.Color.Gold;
            this.lbl_alan.Location = new System.Drawing.Point(8, 119);
            this.lbl_alan.Name = "lbl_alan";
            this.lbl_alan.Size = new System.Drawing.Size(134, 24);
            this.lbl_alan.TabIndex = 11;
            this.lbl_alan.Text = "Alan ";
            this.lbl_alan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_cevre
            // 
            this.lbl_cevre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_cevre.ForeColor = System.Drawing.Color.Gold;
            this.lbl_cevre.Location = new System.Drawing.Point(5, 40);
            this.lbl_cevre.Name = "lbl_cevre";
            this.lbl_cevre.Size = new System.Drawing.Size(134, 24);
            this.lbl_cevre.TabIndex = 12;
            this.lbl_cevre.Text = "Çevre ";
            this.lbl_cevre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_sonuc
            // 
            this.pnl_sonuc.BackColor = System.Drawing.Color.DimGray;
            this.pnl_sonuc.Controls.Add(this.lbl_alan_yazdir);
            this.pnl_sonuc.Controls.Add(this.lbl_cevre_yazdir);
            this.pnl_sonuc.Controls.Add(this.lbl_cevre);
            this.pnl_sonuc.Controls.Add(this.lbl_alan);
            this.pnl_sonuc.Location = new System.Drawing.Point(321, 107);
            this.pnl_sonuc.Name = "pnl_sonuc";
            this.pnl_sonuc.Size = new System.Drawing.Size(145, 246);
            this.pnl_sonuc.TabIndex = 13;
            this.pnl_sonuc.Visible = false;
            // 
            // lbl_cevre_yazdir
            // 
            this.lbl_cevre_yazdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_cevre_yazdir.ForeColor = System.Drawing.Color.Gold;
            this.lbl_cevre_yazdir.Location = new System.Drawing.Point(5, 80);
            this.lbl_cevre_yazdir.Name = "lbl_cevre_yazdir";
            this.lbl_cevre_yazdir.Size = new System.Drawing.Size(134, 24);
            this.lbl_cevre_yazdir.TabIndex = 13;
            this.lbl_cevre_yazdir.Text = ".";
            this.lbl_cevre_yazdir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_alan_yazdir
            // 
            this.lbl_alan_yazdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_alan_yazdir.ForeColor = System.Drawing.Color.Gold;
            this.lbl_alan_yazdir.Location = new System.Drawing.Point(5, 157);
            this.lbl_alan_yazdir.Name = "lbl_alan_yazdir";
            this.lbl_alan_yazdir.Size = new System.Drawing.Size(134, 33);
            this.lbl_alan_yazdir.TabIndex = 14;
            this.lbl_alan_yazdir.Text = ".";
            this.lbl_alan_yazdir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_hosgeldiniz
            // 
            this.lbl_hosgeldiniz.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_hosgeldiniz.ForeColor = System.Drawing.Color.Gold;
            this.lbl_hosgeldiniz.Location = new System.Drawing.Point(1, 130);
            this.lbl_hosgeldiniz.Name = "lbl_hosgeldiniz";
            this.lbl_hosgeldiniz.Size = new System.Drawing.Size(476, 168);
            this.lbl_hosgeldiniz.TabIndex = 14;
            this.lbl_hosgeldiniz.Text = "Hoş Geldiniz Lütfen Bir Butona Tıklayınız";
            this.lbl_hosgeldiniz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tB_b
            // 
            this.tB_b.AllowDrop = true;
            this.tB_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tB_b.Location = new System.Drawing.Point(201, 114);
            this.tB_b.Multiline = true;
            this.tB_b.Name = "tB_b";
            this.tB_b.Size = new System.Drawing.Size(81, 29);
            this.tB_b.TabIndex = 12;
            this.tB_b.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tB_b.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tB_b_KeyPress);
            // 
            // lbl_b
            // 
            this.lbl_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_b.ForeColor = System.Drawing.Color.Gold;
            this.lbl_b.Location = new System.Drawing.Point(6, 102);
            this.lbl_b.Name = "lbl_b";
            this.lbl_b.Size = new System.Drawing.Size(202, 51);
            this.lbl_b.TabIndex = 11;
            this.lbl_b.Text = "Karenin Bir Kenarının Uzunluğunu Giriniz";
            this.lbl_b.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tB_c
            // 
            this.tB_c.AllowDrop = true;
            this.tB_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tB_c.Location = new System.Drawing.Point(201, 159);
            this.tB_c.Multiline = true;
            this.tB_c.Name = "tB_c";
            this.tB_c.Size = new System.Drawing.Size(81, 29);
            this.tB_c.TabIndex = 14;
            this.tB_c.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tB_c.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tB_c_KeyPress);
            // 
            // lbl_c
            // 
            this.lbl_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_c.ForeColor = System.Drawing.Color.Gold;
            this.lbl_c.Location = new System.Drawing.Point(6, 153);
            this.lbl_c.Name = "lbl_c";
            this.lbl_c.Size = new System.Drawing.Size(202, 51);
            this.lbl_c.TabIndex = 13;
            this.lbl_c.Text = "Karenin Bir Kenarının Uzunluğunu Giriniz";
            this.lbl_c.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(478, 365);
            this.Controls.Add(this.pnl_sonuc);
            this.Controls.Add(this.pnl_verigirisi);
            this.Controls.Add(this.lbl_hosgeldiniz);
            this.Controls.Add(this.btn_daire);
            this.Controls.Add(this.btn_ucgen);
            this.Controls.Add(this.btn_dikdortgen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_kare);
            this.Name = "Form1";
            this.Text = "Alan Ve Çevre Hesaplama Ödevi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_verigirisi.ResumeLayout(false);
            this.pnl_verigirisi.PerformLayout();
            this.pnl_sonuc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_kare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_dikdortgen;
        private System.Windows.Forms.Button btn_ucgen;
        private System.Windows.Forms.Button btn_daire;
        private System.Windows.Forms.Panel pnl_verigirisi;
        private System.Windows.Forms.Label lbl_cevre;
        private System.Windows.Forms.Label lbl_alan;
        private System.Windows.Forms.Button btn_hesapla;
        private System.Windows.Forms.Label lbl_a;
        private System.Windows.Forms.Label lbl_baslik;
        private System.Windows.Forms.Panel pnl_sonuc;
        private System.Windows.Forms.Label lbl_alan_yazdir;
        private System.Windows.Forms.Label lbl_cevre_yazdir;
        private System.Windows.Forms.Label lbl_hosgeldiniz;
        protected System.Windows.Forms.TextBox tB_a;
        protected System.Windows.Forms.TextBox tB_b;
        private System.Windows.Forms.Label lbl_b;
        protected System.Windows.Forms.TextBox tB_c;
        private System.Windows.Forms.Label lbl_c;
    }
}


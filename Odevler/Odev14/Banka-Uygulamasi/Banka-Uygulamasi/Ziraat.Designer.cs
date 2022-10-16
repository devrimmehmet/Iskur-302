namespace Banka_Uygulamasi
{
    partial class Ziraat
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pnl_krediCekme = new System.Windows.Forms.Panel();
            this.lB_krediCekme = new System.Windows.Forms.ListBox();
            this.btn_KrediOnayla = new System.Windows.Forms.Button();
            this.lbl_Baslik = new System.Windows.Forms.Label();
            this.btn_KrediCekmeHesaplama = new System.Windows.Forms.Button();
            this.cB_TaksitSayisi = new System.Windows.Forms.ComboBox();
            this.tB_KrediCekme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_krediKapatma = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lB_KrediKapatma = new System.Windows.Forms.ListBox();
            this.btn_krediKapatmaOnay = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_hesaplaKrediKapatma = new System.Windows.Forms.Button();
            this.cB_odenenTaksit = new System.Windows.Forms.ComboBox();
            this.pnl_krediCekme.SuspendLayout();
            this.pnl_krediKapatma.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 83);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kredi Çekme";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(280, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(228, 83);
            this.button2.TabIndex = 1;
            this.button2.Text = "Kredi Kapatma";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pnl_krediCekme
            // 
            this.pnl_krediCekme.Controls.Add(this.label2);
            this.pnl_krediCekme.Controls.Add(this.label1);
            this.pnl_krediCekme.Controls.Add(this.lB_krediCekme);
            this.pnl_krediCekme.Controls.Add(this.btn_KrediOnayla);
            this.pnl_krediCekme.Controls.Add(this.lbl_Baslik);
            this.pnl_krediCekme.Controls.Add(this.btn_KrediCekmeHesaplama);
            this.pnl_krediCekme.Controls.Add(this.cB_TaksitSayisi);
            this.pnl_krediCekme.Controls.Add(this.tB_KrediCekme);
            this.pnl_krediCekme.Location = new System.Drawing.Point(12, 101);
            this.pnl_krediCekme.Name = "pnl_krediCekme";
            this.pnl_krediCekme.Size = new System.Drawing.Size(499, 293);
            this.pnl_krediCekme.TabIndex = 2;
            this.pnl_krediCekme.Visible = false;
            // 
            // lB_krediCekme
            // 
            this.lB_krediCekme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lB_krediCekme.FormattingEnabled = true;
            this.lB_krediCekme.ItemHeight = 16;
            this.lB_krediCekme.Location = new System.Drawing.Point(129, 43);
            this.lB_krediCekme.Name = "lB_krediCekme";
            this.lB_krediCekme.Size = new System.Drawing.Size(367, 244);
            this.lB_krediCekme.TabIndex = 5;
            // 
            // btn_KrediOnayla
            // 
            this.btn_KrediOnayla.BackColor = System.Drawing.Color.Orange;
            this.btn_KrediOnayla.Location = new System.Drawing.Point(3, 236);
            this.btn_KrediOnayla.Name = "btn_KrediOnayla";
            this.btn_KrediOnayla.Size = new System.Drawing.Size(120, 48);
            this.btn_KrediOnayla.TabIndex = 4;
            this.btn_KrediOnayla.Text = "Kredi Çekme İşlemini Onayla";
            this.btn_KrediOnayla.UseVisualStyleBackColor = false;
            this.btn_KrediOnayla.Visible = false;
            this.btn_KrediOnayla.Click += new System.EventHandler(this.button5_Click);
            // 
            // lbl_Baslik
            // 
            this.lbl_Baslik.BackColor = System.Drawing.Color.Gold;
            this.lbl_Baslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Baslik.ForeColor = System.Drawing.Color.LightCoral;
            this.lbl_Baslik.Location = new System.Drawing.Point(3, 0);
            this.lbl_Baslik.Name = "lbl_Baslik";
            this.lbl_Baslik.Size = new System.Drawing.Size(493, 37);
            this.lbl_Baslik.TabIndex = 3;
            this.lbl_Baslik.Text = "Kredi Çekme İşlemleri";
            this.lbl_Baslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_KrediCekmeHesaplama
            // 
            this.btn_KrediCekmeHesaplama.BackColor = System.Drawing.SystemColors.Info;
            this.btn_KrediCekmeHesaplama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_KrediCekmeHesaplama.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_KrediCekmeHesaplama.Location = new System.Drawing.Point(3, 171);
            this.btn_KrediCekmeHesaplama.Name = "btn_KrediCekmeHesaplama";
            this.btn_KrediCekmeHesaplama.Size = new System.Drawing.Size(120, 39);
            this.btn_KrediCekmeHesaplama.TabIndex = 2;
            this.btn_KrediCekmeHesaplama.Text = "Hesapla";
            this.btn_KrediCekmeHesaplama.UseVisualStyleBackColor = false;
            this.btn_KrediCekmeHesaplama.Click += new System.EventHandler(this.btn_KrediCekmeHesaplama_Click);
            // 
            // cB_TaksitSayisi
            // 
            this.cB_TaksitSayisi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_TaksitSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cB_TaksitSayisi.FormattingEnabled = true;
            this.cB_TaksitSayisi.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13"});
            this.cB_TaksitSayisi.Location = new System.Drawing.Point(3, 137);
            this.cB_TaksitSayisi.Name = "cB_TaksitSayisi";
            this.cB_TaksitSayisi.Size = new System.Drawing.Size(120, 28);
            this.cB_TaksitSayisi.TabIndex = 1;
            // 
            // tB_KrediCekme
            // 
            this.tB_KrediCekme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tB_KrediCekme.Location = new System.Drawing.Point(3, 80);
            this.tB_KrediCekme.Name = "tB_KrediCekme";
            this.tB_KrediCekme.Size = new System.Drawing.Size(120, 26);
            this.tB_KrediCekme.TabIndex = 0;
            this.tB_KrediCekme.Text = "10000";
            this.tB_KrediCekme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tB_KrediCekme_KeyPress);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(3, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Çekmek İstediğiniz Miktar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(3, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Taksit Sayısı";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_krediKapatma
            // 
            this.pnl_krediKapatma.Controls.Add(this.label3);
            this.pnl_krediKapatma.Controls.Add(this.lB_KrediKapatma);
            this.pnl_krediKapatma.Controls.Add(this.btn_krediKapatmaOnay);
            this.pnl_krediKapatma.Controls.Add(this.label5);
            this.pnl_krediKapatma.Controls.Add(this.btn_hesaplaKrediKapatma);
            this.pnl_krediKapatma.Controls.Add(this.cB_odenenTaksit);
            this.pnl_krediKapatma.Location = new System.Drawing.Point(9, 104);
            this.pnl_krediKapatma.Name = "pnl_krediKapatma";
            this.pnl_krediKapatma.Size = new System.Drawing.Size(499, 293);
            this.pnl_krediKapatma.TabIndex = 8;
            this.pnl_krediKapatma.Visible = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(3, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 39);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ödediğiniz Taksit Sayısı";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lB_KrediKapatma
            // 
            this.lB_KrediKapatma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lB_KrediKapatma.FormattingEnabled = true;
            this.lB_KrediKapatma.ItemHeight = 16;
            this.lB_KrediKapatma.Location = new System.Drawing.Point(129, 43);
            this.lB_KrediKapatma.Name = "lB_KrediKapatma";
            this.lB_KrediKapatma.Size = new System.Drawing.Size(367, 244);
            this.lB_KrediKapatma.TabIndex = 5;
            // 
            // btn_krediKapatmaOnay
            // 
            this.btn_krediKapatmaOnay.BackColor = System.Drawing.Color.Orange;
            this.btn_krediKapatmaOnay.Location = new System.Drawing.Point(3, 239);
            this.btn_krediKapatmaOnay.Name = "btn_krediKapatmaOnay";
            this.btn_krediKapatmaOnay.Size = new System.Drawing.Size(120, 48);
            this.btn_krediKapatmaOnay.TabIndex = 4;
            this.btn_krediKapatmaOnay.Text = "Kredi Kapatma İşlemini Onayla";
            this.btn_krediKapatmaOnay.UseVisualStyleBackColor = false;
            this.btn_krediKapatmaOnay.Visible = false;
            this.btn_krediKapatmaOnay.Click += new System.EventHandler(this.btn_krediKapatmaOnay_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Gold;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.LightCoral;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(493, 37);
            this.label5.TabIndex = 3;
            this.label5.Text = "Kredi Kapatma İşlemleri";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_hesaplaKrediKapatma
            // 
            this.btn_hesaplaKrediKapatma.BackColor = System.Drawing.SystemColors.Info;
            this.btn_hesaplaKrediKapatma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hesaplaKrediKapatma.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_hesaplaKrediKapatma.Location = new System.Drawing.Point(3, 153);
            this.btn_hesaplaKrediKapatma.Name = "btn_hesaplaKrediKapatma";
            this.btn_hesaplaKrediKapatma.Size = new System.Drawing.Size(120, 39);
            this.btn_hesaplaKrediKapatma.TabIndex = 2;
            this.btn_hesaplaKrediKapatma.Text = "Hesapla";
            this.btn_hesaplaKrediKapatma.UseVisualStyleBackColor = false;
            this.btn_hesaplaKrediKapatma.Click += new System.EventHandler(this.btn_hesaplaKrediKapatma_Click);
            // 
            // cB_odenenTaksit
            // 
            this.cB_odenenTaksit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_odenenTaksit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cB_odenenTaksit.FormattingEnabled = true;
            this.cB_odenenTaksit.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13"});
            this.cB_odenenTaksit.Location = new System.Drawing.Point(3, 119);
            this.cB_odenenTaksit.Name = "cB_odenenTaksit";
            this.cB_odenenTaksit.Size = new System.Drawing.Size(120, 28);
            this.cB_odenenTaksit.TabIndex = 1;
            // 
            // Ziraat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(526, 397);
            this.Controls.Add(this.pnl_krediKapatma);
            this.Controls.Add(this.pnl_krediCekme);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Ziraat";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ziraat Bankası";
            this.Load += new System.EventHandler(this.Ziraat_Load);
            this.pnl_krediCekme.ResumeLayout(false);
            this.pnl_krediCekme.PerformLayout();
            this.pnl_krediKapatma.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pnl_krediCekme;
        public System.Windows.Forms.ListBox lB_krediCekme;
        private System.Windows.Forms.Button btn_KrediOnayla;
        private System.Windows.Forms.Label lbl_Baslik;
        private System.Windows.Forms.Button btn_KrediCekmeHesaplama;
        private System.Windows.Forms.ComboBox cB_TaksitSayisi;
        private System.Windows.Forms.TextBox tB_KrediCekme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_krediKapatma;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ListBox lB_KrediKapatma;
        private System.Windows.Forms.Button btn_krediKapatmaOnay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_hesaplaKrediKapatma;
        private System.Windows.Forms.ComboBox cB_odenenTaksit;
    }
}
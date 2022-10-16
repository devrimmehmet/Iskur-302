namespace Odev10
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.cB_kola = new System.Windows.Forms.CheckBox();
            this.cB_Limonata = new System.Windows.Forms.CheckBox();
            this.cB_cay = new System.Windows.Forms.CheckBox();
            this.cB_Su = new System.Windows.Forms.CheckBox();
            this.coB_Kola = new System.Windows.Forms.ComboBox();
            this.coB_limonata = new System.Windows.Forms.ComboBox();
            this.coB_cay = new System.Windows.Forms.ComboBox();
            this.coB_su = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_siparis = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.btn_Hesapla = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.ForestGreen;
            this.button1.Location = new System.Drawing.Point(139, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "Satış Yap";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cB_kola
            // 
            this.cB_kola.AutoSize = true;
            this.cB_kola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cB_kola.ForeColor = System.Drawing.Color.Orange;
            this.cB_kola.Location = new System.Drawing.Point(13, 51);
            this.cB_kola.Name = "cB_kola";
            this.cB_kola.Size = new System.Drawing.Size(63, 24);
            this.cB_kola.TabIndex = 1;
            this.cB_kola.Text = "Kola";
            this.cB_kola.UseVisualStyleBackColor = true;
            this.cB_kola.CheckedChanged += new System.EventHandler(this.cB_kola_CheckedChanged);
            // 
            // cB_Limonata
            // 
            this.cB_Limonata.AutoSize = true;
            this.cB_Limonata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cB_Limonata.ForeColor = System.Drawing.Color.Orange;
            this.cB_Limonata.Location = new System.Drawing.Point(13, 85);
            this.cB_Limonata.Name = "cB_Limonata";
            this.cB_Limonata.Size = new System.Drawing.Size(102, 24);
            this.cB_Limonata.TabIndex = 2;
            this.cB_Limonata.Text = "Limonata";
            this.cB_Limonata.UseVisualStyleBackColor = true;
            this.cB_Limonata.CheckedChanged += new System.EventHandler(this.cB_Limonata_CheckedChanged);
            // 
            // cB_cay
            // 
            this.cB_cay.AutoSize = true;
            this.cB_cay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cB_cay.ForeColor = System.Drawing.Color.Orange;
            this.cB_cay.Location = new System.Drawing.Point(12, 119);
            this.cB_cay.Name = "cB_cay";
            this.cB_cay.Size = new System.Drawing.Size(58, 24);
            this.cB_cay.TabIndex = 3;
            this.cB_cay.Text = "Çay";
            this.cB_cay.UseVisualStyleBackColor = true;
            this.cB_cay.CheckedChanged += new System.EventHandler(this.cB_cay_CheckedChanged);
            // 
            // cB_Su
            // 
            this.cB_Su.AutoSize = true;
            this.cB_Su.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cB_Su.ForeColor = System.Drawing.Color.Orange;
            this.cB_Su.Location = new System.Drawing.Point(13, 153);
            this.cB_Su.Name = "cB_Su";
            this.cB_Su.Size = new System.Drawing.Size(50, 24);
            this.cB_Su.TabIndex = 4;
            this.cB_Su.Text = "Su";
            this.cB_Su.UseVisualStyleBackColor = true;
            this.cB_Su.CheckedChanged += new System.EventHandler(this.cB_Su_CheckedChanged);
            // 
            // coB_Kola
            // 
            this.coB_Kola.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coB_Kola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.coB_Kola.FormattingEnabled = true;
            this.coB_Kola.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.coB_Kola.Location = new System.Drawing.Point(180, 47);
            this.coB_Kola.Name = "coB_Kola";
            this.coB_Kola.Size = new System.Drawing.Size(90, 28);
            this.coB_Kola.TabIndex = 5;
            this.coB_Kola.SelectedIndexChanged += new System.EventHandler(this.coB_Kola_SelectedIndexChanged);
            this.coB_Kola.SelectedValueChanged += new System.EventHandler(this.coB_Kola_SelectedValueChanged);
            // 
            // coB_limonata
            // 
            this.coB_limonata.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coB_limonata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.coB_limonata.FormattingEnabled = true;
            this.coB_limonata.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.coB_limonata.Location = new System.Drawing.Point(180, 81);
            this.coB_limonata.Name = "coB_limonata";
            this.coB_limonata.Size = new System.Drawing.Size(90, 28);
            this.coB_limonata.TabIndex = 6;
            this.coB_limonata.SelectedValueChanged += new System.EventHandler(this.coB_limonata_SelectedValueChanged);
            // 
            // coB_cay
            // 
            this.coB_cay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coB_cay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.coB_cay.FormattingEnabled = true;
            this.coB_cay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.coB_cay.Location = new System.Drawing.Point(180, 115);
            this.coB_cay.Name = "coB_cay";
            this.coB_cay.Size = new System.Drawing.Size(90, 28);
            this.coB_cay.TabIndex = 7;
            this.coB_cay.SelectedValueChanged += new System.EventHandler(this.coB_cay_SelectedValueChanged);
            // 
            // coB_su
            // 
            this.coB_su.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coB_su.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.coB_su.FormattingEnabled = true;
            this.coB_su.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.coB_su.Location = new System.Drawing.Point(180, 149);
            this.coB_su.Name = "coB_su";
            this.coB_su.Size = new System.Drawing.Size(90, 28);
            this.coB_su.TabIndex = 8;
            this.coB_su.SelectedValueChanged += new System.EventHandler(this.coB_su_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(317, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Sipariş Toplamı";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(317, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Kasa Toplamı";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_siparis
            // 
            this.lbl_siparis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_siparis.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_siparis.Location = new System.Drawing.Point(317, 77);
            this.lbl_siparis.Name = "lbl_siparis";
            this.lbl_siparis.Size = new System.Drawing.Size(131, 20);
            this.lbl_siparis.TabIndex = 11;
            this.lbl_siparis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_total
            // 
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_total.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_total.Location = new System.Drawing.Point(317, 144);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(131, 20);
            this.lbl_total.TabIndex = 12;
            this.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Hesapla
            // 
            this.btn_Hesapla.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Hesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Hesapla.ForeColor = System.Drawing.Color.ForestGreen;
            this.btn_Hesapla.Location = new System.Drawing.Point(12, 183);
            this.btn_Hesapla.Name = "btn_Hesapla";
            this.btn_Hesapla.Size = new System.Drawing.Size(121, 64);
            this.btn_Hesapla.TabIndex = 13;
            this.btn_Hesapla.Text = "Hesapla";
            this.btn_Hesapla.UseVisualStyleBackColor = false;
            this.btn_Hesapla.Click += new System.EventHandler(this.btn_Hesapla_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(161, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Adet";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCoral;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.ForestGreen;
            this.button2.Location = new System.Drawing.Point(329, 178);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 40);
            this.button2.TabIndex = 15;
            this.button2.Text = "Gün Sonu Al";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightCoral;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.ForestGreen;
            this.button3.Location = new System.Drawing.Point(348, 224);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 32);
            this.button3.TabIndex = 16;
            this.button3.Text = "Detay";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(490, 259);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Hesapla);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_siparis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.coB_su);
            this.Controls.Add(this.coB_cay);
            this.Controls.Add(this.coB_limonata);
            this.Controls.Add(this.coB_Kola);
            this.Controls.Add(this.cB_Su);
            this.Controls.Add(this.cB_cay);
            this.Controls.Add(this.cB_Limonata);
            this.Controls.Add(this.cB_kola);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "302 Cafe Programı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cB_kola;
        private System.Windows.Forms.CheckBox cB_Limonata;
        private System.Windows.Forms.CheckBox cB_cay;
        private System.Windows.Forms.CheckBox cB_Su;
        private System.Windows.Forms.ComboBox coB_Kola;
        private System.Windows.Forms.ComboBox coB_limonata;
        private System.Windows.Forms.ComboBox coB_cay;
        private System.Windows.Forms.ComboBox coB_su;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_siparis;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Button btn_Hesapla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}


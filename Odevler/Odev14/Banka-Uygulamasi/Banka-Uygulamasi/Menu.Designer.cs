namespace Banka_Uygulamasi
{
    partial class Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.gB_Akbank = new System.Windows.Forms.GroupBox();
            this.btn_Akbank = new System.Windows.Forms.Button();
            this.gB_Garanti = new System.Windows.Forms.GroupBox();
            this.btn_Garanti = new System.Windows.Forms.Button();
            this.gB_YapıKredi = new System.Windows.Forms.GroupBox();
            this.btn_YapiKredi = new System.Windows.Forms.Button();
            this.gB_Finans = new System.Windows.Forms.GroupBox();
            this.btn_Finans = new System.Windows.Forms.Button();
            this.gB_Ziraat = new System.Windows.Forms.GroupBox();
            this.btn_Ziraat = new System.Windows.Forms.Button();
            this.gB_Akbank.SuspendLayout();
            this.gB_Garanti.SuspendLayout();
            this.gB_YapıKredi.SuspendLayout();
            this.gB_Finans.SuspendLayout();
            this.gB_Ziraat.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(911, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Banka Uygulamasına Hoş Geldiniz";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gB_Akbank
            // 
            this.gB_Akbank.BackColor = System.Drawing.Color.Transparent;
            this.gB_Akbank.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gB_Akbank.Controls.Add(this.btn_Akbank);
            this.gB_Akbank.Location = new System.Drawing.Point(742, 50);
            this.gB_Akbank.Name = "gB_Akbank";
            this.gB_Akbank.Size = new System.Drawing.Size(175, 149);
            this.gB_Akbank.TabIndex = 3;
            this.gB_Akbank.TabStop = false;
            this.gB_Akbank.Text = "Akbank";
            // 
            // btn_Akbank
            // 
            this.btn_Akbank.BackColor = System.Drawing.Color.Transparent;
            this.btn_Akbank.BackgroundImage = global::Banka_Uygulamasi.Properties.Resources.Akbank;
            this.btn_Akbank.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Akbank.Location = new System.Drawing.Point(0, 26);
            this.btn_Akbank.Name = "btn_Akbank";
            this.btn_Akbank.Size = new System.Drawing.Size(175, 123);
            this.btn_Akbank.TabIndex = 4;
            this.btn_Akbank.UseVisualStyleBackColor = false;
            this.btn_Akbank.Click += new System.EventHandler(this.btn_Akbank_Click);
            // 
            // gB_Garanti
            // 
            this.gB_Garanti.BackColor = System.Drawing.Color.Transparent;
            this.gB_Garanti.BackgroundImage = global::Banka_Uygulamasi.Properties.Resources.Garanti;
            this.gB_Garanti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gB_Garanti.Controls.Add(this.btn_Garanti);
            this.gB_Garanti.Location = new System.Drawing.Point(561, 50);
            this.gB_Garanti.Name = "gB_Garanti";
            this.gB_Garanti.Size = new System.Drawing.Size(175, 149);
            this.gB_Garanti.TabIndex = 3;
            this.gB_Garanti.TabStop = false;
            this.gB_Garanti.Text = "Garanti";
            // 
            // btn_Garanti
            // 
            this.btn_Garanti.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Garanti.BackgroundImage = global::Banka_Uygulamasi.Properties.Resources.Garanti;
            this.btn_Garanti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Garanti.Location = new System.Drawing.Point(0, 26);
            this.btn_Garanti.Name = "btn_Garanti";
            this.btn_Garanti.Size = new System.Drawing.Size(175, 123);
            this.btn_Garanti.TabIndex = 3;
            this.btn_Garanti.UseVisualStyleBackColor = false;
            this.btn_Garanti.Click += new System.EventHandler(this.btn_Garanti_Click);
            // 
            // gB_YapıKredi
            // 
            this.gB_YapıKredi.BackColor = System.Drawing.Color.Transparent;
            this.gB_YapıKredi.BackgroundImage = global::Banka_Uygulamasi.Properties.Resources.yapikredi;
            this.gB_YapıKredi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gB_YapıKredi.Controls.Add(this.btn_YapiKredi);
            this.gB_YapıKredi.Location = new System.Drawing.Point(380, 50);
            this.gB_YapıKredi.Name = "gB_YapıKredi";
            this.gB_YapıKredi.Size = new System.Drawing.Size(175, 149);
            this.gB_YapıKredi.TabIndex = 3;
            this.gB_YapıKredi.TabStop = false;
            this.gB_YapıKredi.Text = "Yapı Kredi";
            // 
            // btn_YapiKredi
            // 
            this.btn_YapiKredi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_YapiKredi.BackgroundImage = global::Banka_Uygulamasi.Properties.Resources.yapikredi;
            this.btn_YapiKredi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_YapiKredi.Location = new System.Drawing.Point(0, 26);
            this.btn_YapiKredi.Name = "btn_YapiKredi";
            this.btn_YapiKredi.Size = new System.Drawing.Size(175, 123);
            this.btn_YapiKredi.TabIndex = 2;
            this.btn_YapiKredi.UseVisualStyleBackColor = false;
            this.btn_YapiKredi.Click += new System.EventHandler(this.btn_YapiKredi_Click);
            // 
            // gB_Finans
            // 
            this.gB_Finans.BackColor = System.Drawing.Color.Transparent;
            this.gB_Finans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gB_Finans.Controls.Add(this.btn_Finans);
            this.gB_Finans.Location = new System.Drawing.Point(199, 50);
            this.gB_Finans.Name = "gB_Finans";
            this.gB_Finans.Size = new System.Drawing.Size(175, 149);
            this.gB_Finans.TabIndex = 3;
            this.gB_Finans.TabStop = false;
            this.gB_Finans.Text = "Finans Bank";
            // 
            // btn_Finans
            // 
            this.btn_Finans.BackColor = System.Drawing.Color.Transparent;
            this.btn_Finans.BackgroundImage = global::Banka_Uygulamasi.Properties.Resources.finans;
            this.btn_Finans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Finans.Location = new System.Drawing.Point(0, 26);
            this.btn_Finans.Name = "btn_Finans";
            this.btn_Finans.Size = new System.Drawing.Size(175, 123);
            this.btn_Finans.TabIndex = 1;
            this.btn_Finans.UseVisualStyleBackColor = false;
            this.btn_Finans.Click += new System.EventHandler(this.btn_Finans_Click);
            // 
            // gB_Ziraat
            // 
            this.gB_Ziraat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gB_Ziraat.Controls.Add(this.btn_Ziraat);
            this.gB_Ziraat.Location = new System.Drawing.Point(18, 50);
            this.gB_Ziraat.Name = "gB_Ziraat";
            this.gB_Ziraat.Size = new System.Drawing.Size(175, 149);
            this.gB_Ziraat.TabIndex = 2;
            this.gB_Ziraat.TabStop = false;
            this.gB_Ziraat.Text = "Ziraat Bankası";
            // 
            // btn_Ziraat
            // 
            this.btn_Ziraat.BackColor = System.Drawing.Color.Transparent;
            this.btn_Ziraat.BackgroundImage = global::Banka_Uygulamasi.Properties.Resources.Ziraat;
            this.btn_Ziraat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Ziraat.Location = new System.Drawing.Point(0, 25);
            this.btn_Ziraat.Name = "btn_Ziraat";
            this.btn_Ziraat.Size = new System.Drawing.Size(175, 123);
            this.btn_Ziraat.TabIndex = 0;
            this.btn_Ziraat.UseVisualStyleBackColor = false;
            this.btn_Ziraat.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(935, 210);
            this.Controls.Add(this.gB_Ziraat);
            this.Controls.Add(this.gB_Akbank);
            this.Controls.Add(this.gB_Garanti);
            this.Controls.Add(this.gB_YapıKredi);
            this.Controls.Add(this.gB_Finans);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Menu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banka Uygulaması";
            this.gB_Akbank.ResumeLayout(false);
            this.gB_Garanti.ResumeLayout(false);
            this.gB_YapıKredi.ResumeLayout(false);
            this.gB_Finans.ResumeLayout(false);
            this.gB_Ziraat.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gB_Ziraat;
        private System.Windows.Forms.GroupBox gB_Finans;
        private System.Windows.Forms.GroupBox gB_YapıKredi;
        private System.Windows.Forms.GroupBox gB_Garanti;
        private System.Windows.Forms.GroupBox gB_Akbank;
        private System.Windows.Forms.Button btn_Akbank;
        private System.Windows.Forms.Button btn_Garanti;
        private System.Windows.Forms.Button btn_YapiKredi;
        private System.Windows.Forms.Button btn_Finans;
        private System.Windows.Forms.Button btn_Ziraat;
    }
}


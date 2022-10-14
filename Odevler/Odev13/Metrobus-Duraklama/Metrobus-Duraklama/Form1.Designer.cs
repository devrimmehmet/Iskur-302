namespace Metrobus_Duraklama
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnBaslat = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_sogutlucesme = new System.Windows.Forms.Label();
            this.lbl_fikirtepe = new System.Windows.Forms.Label();
            this.lbl_uzuncayir = new System.Windows.Forms.Label();
            this.lbl_acibadem = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(11, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Zaman";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // BtnBaslat
            // 
            this.BtnBaslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnBaslat.Location = new System.Drawing.Point(11, 105);
            this.BtnBaslat.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBaslat.Name = "BtnBaslat";
            this.BtnBaslat.Size = new System.Drawing.Size(80, 37);
            this.BtnBaslat.TabIndex = 5;
            this.BtnBaslat.Text = "Başlat";
            this.BtnBaslat.UseVisualStyleBackColor = true;
            this.BtnBaslat.Click += new System.EventHandler(this.BtnBaslat_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Metrobus_Duraklama.Properties.Resources.metrobus;
            this.pictureBox1.Location = new System.Drawing.Point(100, 87);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_sogutlucesme
            // 
            this.lbl_sogutlucesme.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sogutlucesme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sogutlucesme.Location = new System.Drawing.Point(340, 9);
            this.lbl_sogutlucesme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_sogutlucesme.Name = "lbl_sogutlucesme";
            this.lbl_sogutlucesme.Size = new System.Drawing.Size(150, 46);
            this.lbl_sogutlucesme.TabIndex = 10;
            this.lbl_sogutlucesme.Text = "Söğütlüçeşme";
            this.lbl_sogutlucesme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_fikirtepe
            // 
            this.lbl_fikirtepe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_fikirtepe.Location = new System.Drawing.Point(584, 9);
            this.lbl_fikirtepe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_fikirtepe.Name = "lbl_fikirtepe";
            this.lbl_fikirtepe.Size = new System.Drawing.Size(150, 46);
            this.lbl_fikirtepe.TabIndex = 11;
            this.lbl_fikirtepe.Text = "Fikirtepe";
            this.lbl_fikirtepe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_uzuncayir
            // 
            this.lbl_uzuncayir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_uzuncayir.Location = new System.Drawing.Point(828, 9);
            this.lbl_uzuncayir.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_uzuncayir.Name = "lbl_uzuncayir";
            this.lbl_uzuncayir.Size = new System.Drawing.Size(150, 46);
            this.lbl_uzuncayir.TabIndex = 12;
            this.lbl_uzuncayir.Text = "Uzunçayır";
            this.lbl_uzuncayir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_acibadem
            // 
            this.lbl_acibadem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_acibadem.Location = new System.Drawing.Point(1070, 9);
            this.lbl_acibadem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_acibadem.Name = "lbl_acibadem";
            this.lbl_acibadem.Size = new System.Drawing.Size(150, 46);
            this.lbl_acibadem.TabIndex = 15;
            this.lbl_acibadem.Text = "Acıbadem";
            this.lbl_acibadem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(1239, 105);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 37);
            this.button1.TabIndex = 16;
            this.button1.Text = "Başlat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(96, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1141, 33);
            this.label1.TabIndex = 17;
            this.label1.Text = "---->";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 238);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_acibadem);
            this.Controls.Add(this.lbl_uzuncayir);
            this.Controls.Add(this.lbl_fikirtepe);
            this.Controls.Add(this.lbl_sogutlucesme);
            this.Controls.Add(this.BtnBaslat);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Metrobüs Otomasyonu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnBaslat;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_sogutlucesme;
        private System.Windows.Forms.Label lbl_fikirtepe;
        private System.Windows.Forms.Label lbl_uzuncayir;
        private System.Windows.Forms.Label lbl_acibadem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}


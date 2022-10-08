namespace WindowsFormsApp1
{
    partial class Form2
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tB_a = new System.Windows.Forms.TextBox();
            this.lbl_a = new System.Windows.Forms.Label();
            this.pnl_sonuc = new System.Windows.Forms.Panel();
            this.lbl_alan_yazdir = new System.Windows.Forms.Label();
            this.lbl_cevre_yazdir = new System.Windows.Forms.Label();
            this.lbl_cevre = new System.Windows.Forms.Label();
            this.lbl_alan = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pnl_sonuc.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(617, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "Diziye Atılan Sayılarla İşlem Yapma";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(41, 118);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(153, 121);
            this.listBox1.TabIndex = 3;
            // 
            // tB_a
            // 
            this.tB_a.AllowDrop = true;
            this.tB_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tB_a.Location = new System.Drawing.Point(207, 76);
            this.tB_a.Multiline = true;
            this.tB_a.Name = "tB_a";
            this.tB_a.Size = new System.Drawing.Size(95, 29);
            this.tB_a.TabIndex = 11;
            this.tB_a.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tB_a.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tB_a_KeyPress);
            // 
            // lbl_a
            // 
            this.lbl_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_a.ForeColor = System.Drawing.Color.Gold;
            this.lbl_a.Location = new System.Drawing.Point(12, 64);
            this.lbl_a.Name = "lbl_a";
            this.lbl_a.Size = new System.Drawing.Size(202, 51);
            this.lbl_a.TabIndex = 10;
            this.lbl_a.Text = "Bir Sayı Giriniz";
            this.lbl_a.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_sonuc
            // 
            this.pnl_sonuc.BackColor = System.Drawing.Color.DimGray;
            this.pnl_sonuc.Controls.Add(this.lbl_alan_yazdir);
            this.pnl_sonuc.Controls.Add(this.lbl_cevre_yazdir);
            this.pnl_sonuc.Controls.Add(this.lbl_cevre);
            this.pnl_sonuc.Controls.Add(this.lbl_alan);
            this.pnl_sonuc.Location = new System.Drawing.Point(323, 76);
            this.pnl_sonuc.Name = "pnl_sonuc";
            this.pnl_sonuc.Size = new System.Drawing.Size(291, 163);
            this.pnl_sonuc.TabIndex = 14;
            this.pnl_sonuc.Visible = false;
            // 
            // lbl_alan_yazdir
            // 
            this.lbl_alan_yazdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_alan_yazdir.ForeColor = System.Drawing.Color.Gold;
            this.lbl_alan_yazdir.Location = new System.Drawing.Point(3, 127);
            this.lbl_alan_yazdir.Name = "lbl_alan_yazdir";
            this.lbl_alan_yazdir.Size = new System.Drawing.Size(285, 33);
            this.lbl_alan_yazdir.TabIndex = 14;
            this.lbl_alan_yazdir.Text = ".";
            this.lbl_alan_yazdir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_cevre_yazdir
            // 
            this.lbl_cevre_yazdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_cevre_yazdir.ForeColor = System.Drawing.Color.Gold;
            this.lbl_cevre_yazdir.Location = new System.Drawing.Point(3, 50);
            this.lbl_cevre_yazdir.Name = "lbl_cevre_yazdir";
            this.lbl_cevre_yazdir.Size = new System.Drawing.Size(285, 24);
            this.lbl_cevre_yazdir.TabIndex = 13;
            this.lbl_cevre_yazdir.Text = ".";
            this.lbl_cevre_yazdir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_cevre
            // 
            this.lbl_cevre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_cevre.ForeColor = System.Drawing.Color.Gold;
            this.lbl_cevre.Location = new System.Drawing.Point(3, 10);
            this.lbl_cevre.Name = "lbl_cevre";
            this.lbl_cevre.Size = new System.Drawing.Size(285, 24);
            this.lbl_cevre.TabIndex = 12;
            this.lbl_cevre.Text = "Toplamları";
            this.lbl_cevre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_alan
            // 
            this.lbl_alan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_alan.ForeColor = System.Drawing.Color.Gold;
            this.lbl_alan.Location = new System.Drawing.Point(0, 80);
            this.lbl_alan.Name = "lbl_alan";
            this.lbl_alan.Size = new System.Drawing.Size(288, 24);
            this.lbl_alan.TabIndex = 11;
            this.lbl_alan.Text = "Çarpımları";
            this.lbl_alan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(220, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(220, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Topla";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(220, 189);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Çarp";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 259);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnl_sonuc);
            this.Controls.Add(this.tB_a);
            this.Controls.Add(this.lbl_a);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "s";
            this.pnl_sonuc.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        protected System.Windows.Forms.TextBox tB_a;
        private System.Windows.Forms.Label lbl_a;
        private System.Windows.Forms.Panel pnl_sonuc;
        private System.Windows.Forms.Label lbl_alan_yazdir;
        private System.Windows.Forms.Label lbl_cevre_yazdir;
        private System.Windows.Forms.Label lbl_cevre;
        private System.Windows.Forms.Label lbl_alan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
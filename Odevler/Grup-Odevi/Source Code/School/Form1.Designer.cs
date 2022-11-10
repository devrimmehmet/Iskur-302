namespace School
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tB_Name = new System.Windows.Forms.TextBox();
            this.tB_Surname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tB_StudentNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pB_Picture = new System.Windows.Forms.PictureBox();
            this.tB_PhotoURL = new System.Windows.Forms.TextBox();
            this.btn_PhotoAdd = new System.Windows.Forms.Button();
            this.tB_Phone = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 356);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1156, 313);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
       
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "AD:";
            // 
            // tB_Name
            // 
            this.tB_Name.Location = new System.Drawing.Point(24, 34);
            this.tB_Name.Margin = new System.Windows.Forms.Padding(5);
            this.tB_Name.Name = "tB_Name";
            this.tB_Name.Size = new System.Drawing.Size(298, 26);
            this.tB_Name.TabIndex = 2;
            // 
            // tB_Surname
            // 
            this.tB_Surname.Location = new System.Drawing.Point(24, 90);
            this.tB_Surname.Margin = new System.Windows.Forms.Padding(5);
            this.tB_Surname.Name = "tB_Surname";
            this.tB_Surname.Size = new System.Drawing.Size(298, 26);
            this.tB_Surname.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "SOYAD:";
            // 
            // tB_StudentNumber
            // 
            this.tB_StudentNumber.Location = new System.Drawing.Point(24, 146);
            this.tB_StudentNumber.Margin = new System.Windows.Forms.Padding(5);
            this.tB_StudentNumber.Name = "tB_StudentNumber";
            this.tB_StudentNumber.Size = new System.Drawing.Size(298, 26);
            this.tB_StudentNumber.TabIndex = 6;
            this.tB_StudentNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tB_StudentNumber_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "ÖĞRENCİ NUMARASI:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.tB_Phone);
            this.panel1.Controls.Add(this.btn_Add);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tB_Name);
            this.panel1.Controls.Add(this.tB_StudentNumber);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tB_Surname);
            this.panel1.ForeColor = System.Drawing.Color.Goldenrod;
            this.panel1.Location = new System.Drawing.Point(14, 23);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 325);
            this.panel1.TabIndex = 7;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Add.Location = new System.Drawing.Point(78, 248);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(146, 59);
            this.btn_Add.TabIndex = 14;
            this.btn_Add.Text = "Ekle";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 177);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "TELEFON:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.DarkGray;
            this.label5.Location = new System.Drawing.Point(533, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(322, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "ÖĞRENCİ KAYIT SİSTEMİ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label6.Location = new System.Drawing.Point(515, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(239, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "ÖĞRENCİ BİLGİ EKRANI";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel2.Controls.Add(this.pB_Picture);
            this.panel2.Controls.Add(this.tB_PhotoURL);
            this.panel2.Controls.Add(this.btn_PhotoAdd);
            this.panel2.Location = new System.Drawing.Point(371, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(299, 247);
            this.panel2.TabIndex = 11;
            // 
            // pB_Picture
            // 
            this.pB_Picture.Location = new System.Drawing.Point(54, 30);
            this.pB_Picture.Name = "pB_Picture";
            this.pB_Picture.Size = new System.Drawing.Size(177, 157);
            this.pB_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_Picture.TabIndex = 2;
            this.pB_Picture.TabStop = false;
            // 
            // tB_PhotoURL
            // 
            this.tB_PhotoURL.Location = new System.Drawing.Point(125, 203);
            this.tB_PhotoURL.Name = "tB_PhotoURL";
            this.tB_PhotoURL.Size = new System.Drawing.Size(163, 26);
            this.tB_PhotoURL.TabIndex = 1;
            this.tB_PhotoURL.Visible = false;
            // 
            // btn_PhotoAdd
            // 
            this.btn_PhotoAdd.BackColor = System.Drawing.Color.Transparent;
            this.btn_PhotoAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_PhotoAdd.Location = new System.Drawing.Point(7, 203);
            this.btn_PhotoAdd.Name = "btn_PhotoAdd";
            this.btn_PhotoAdd.Size = new System.Drawing.Size(112, 26);
            this.btn_PhotoAdd.TabIndex = 0;
            this.btn_PhotoAdd.Text = "Dosya Seç";
            this.btn_PhotoAdd.UseVisualStyleBackColor = false;
            this.btn_PhotoAdd.Click += new System.EventHandler(this.btn_PhotoAdd_Click);
            // 
            // tB_Phone
            // 
            this.tB_Phone.Location = new System.Drawing.Point(24, 210);
            this.tB_Phone.Mask = "(999) 000-0000";
            this.tB_Phone.Name = "tB_Phone";
            this.tB_Phone.Size = new System.Drawing.Size(298, 26);
            this.tB_Phone.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1184, 697);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Goldenrod;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(1200, 741);
            this.MinimumSize = new System.Drawing.Size(1200, 736);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Kayıt Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tB_Name;
        private System.Windows.Forms.TextBox tB_Surname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tB_StudentNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pB_Picture;
        private System.Windows.Forms.TextBox tB_PhotoURL;
        private System.Windows.Forms.Button btn_PhotoAdd;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.MaskedTextBox tB_Phone;
    }
}


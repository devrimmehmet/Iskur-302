namespace School
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
            this.tB_Name = new System.Windows.Forms.TextBox();
            this.tB_Surname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tB_StudentNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tB_ID = new System.Windows.Forms.TextBox();
            this.cB_State = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pB_Picture = new System.Windows.Forms.PictureBox();
            this.tB_PhotoURL = new System.Windows.Forms.TextBox();
            this.btn_PhotoAdd = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.tB_Phone = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "AD:";
            // 
            // tB_Name
            // 
            this.tB_Name.Location = new System.Drawing.Point(28, 51);
            this.tB_Name.Margin = new System.Windows.Forms.Padding(5);
            this.tB_Name.Name = "tB_Name";
            this.tB_Name.Size = new System.Drawing.Size(298, 26);
            this.tB_Name.TabIndex = 1;
            // 
            // tB_Surname
            // 
            this.tB_Surname.Location = new System.Drawing.Point(28, 107);
            this.tB_Surname.Margin = new System.Windows.Forms.Padding(5);
            this.tB_Surname.Name = "tB_Surname";
            this.tB_Surname.Size = new System.Drawing.Size(298, 26);
            this.tB_Surname.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "SOYAD:";
            // 
            // tB_StudentNumber
            // 
            this.tB_StudentNumber.Enabled = false;
            this.tB_StudentNumber.Location = new System.Drawing.Point(28, 163);
            this.tB_StudentNumber.Margin = new System.Windows.Forms.Padding(5);
            this.tB_StudentNumber.Name = "tB_StudentNumber";
            this.tB_StudentNumber.Size = new System.Drawing.Size(298, 26);
            this.tB_StudentNumber.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 138);
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
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.tB_ID);
            this.panel1.Controls.Add(this.cB_State);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tB_Name);
            this.panel1.Controls.Add(this.tB_StudentNumber);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tB_Surname);
            this.panel1.ForeColor = System.Drawing.Color.Goldenrod;
            this.panel1.Location = new System.Drawing.Point(14, 34);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 381);
            this.panel1.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 319);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "KAYIT TARİHİ:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(28, 342);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(298, 26);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // tB_ID
            // 
            this.tB_ID.Enabled = false;
            this.tB_ID.Location = new System.Drawing.Point(28, 5);
            this.tB_ID.Margin = new System.Windows.Forms.Padding(5);
            this.tB_ID.Name = "tB_ID";
            this.tB_ID.Size = new System.Drawing.Size(298, 26);
            this.tB_ID.TabIndex = 12;
            this.tB_ID.Visible = false;
            // 
            // cB_State
            // 
            this.cB_State.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cB_State.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cB_State.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_State.FormattingEnabled = true;
            this.cB_State.Items.AddRange(new object[] {
            "ÖĞRENCİ",
            "MEZUN",
            "DONDURULMUŞ KAYIT",
            "SİLİNMİŞ KAYIT"});
            this.cB_State.Location = new System.Drawing.Point(28, 279);
            this.cB_State.Name = "cB_State";
            this.cB_State.Size = new System.Drawing.Size(298, 28);
            this.cB_State.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 256);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "DURUM:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 194);
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
            this.label6.Location = new System.Drawing.Point(237, 5);
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
            this.panel2.Location = new System.Drawing.Point(371, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(299, 276);
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
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Update.Location = new System.Drawing.Point(371, 353);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(146, 59);
            this.btn_Update.TabIndex = 12;
            this.btn_Update.Text = "GÜNCELLE";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Delete.Location = new System.Drawing.Point(523, 353);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(146, 59);
            this.btn_Delete.TabIndex = 13;
            this.btn_Delete.Text = "SİL";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // tB_Phone
            // 
            this.tB_Phone.Location = new System.Drawing.Point(28, 217);
            this.tB_Phone.Mask = "(999) 000-0000";
            this.tB_Phone.Name = "tB_Phone";
            this.tB_Phone.Size = new System.Drawing.Size(298, 26);
            this.tB_Phone.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(682, 424);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Goldenrod;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(698, 463);
            this.MinimumSize = new System.Drawing.Size(698, 463);
            this.Name = "Form2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Kayıt Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tB_Name;
        private System.Windows.Forms.TextBox tB_Surname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tB_StudentNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cB_State;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pB_Picture;
        private System.Windows.Forms.TextBox tB_PhotoURL;
        private System.Windows.Forms.Button btn_PhotoAdd;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.TextBox tB_ID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MaskedTextBox tB_Phone;
    }
}


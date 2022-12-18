namespace EntityFramework
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tB_Ad = new System.Windows.Forms.TextBox();
            this.tB_Fiyat = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.tB_Fiyat_Update = new System.Windows.Forms.TextBox();
            this.tB_Ad_Update = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tB_ID_Update = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tB_ID_Delete = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tB_Fiyat_Delete = new System.Windows.Forms.TextBox();
            this.tB_Ad_Delete = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tB_Search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 39);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(707, 225);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tB_Fiyat);
            this.groupBox1.Controls.Add(this.tB_Ad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 274);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Size = new System.Drawing.Size(229, 171);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Ekle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fiyat";
            // 
            // tB_Ad
            // 
            this.tB_Ad.Location = new System.Drawing.Point(81, 19);
            this.tB_Ad.Name = "tB_Ad";
            this.tB_Ad.Size = new System.Drawing.Size(140, 26);
            this.tB_Ad.TabIndex = 3;
            // 
            // tB_Fiyat
            // 
            this.tB_Fiyat.Location = new System.Drawing.Point(81, 80);
            this.tB_Fiyat.Name = "tB_Fiyat";
            this.tB_Fiyat.Size = new System.Drawing.Size(140, 26);
            this.tB_Fiyat.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tB_ID_Update);
            this.groupBox2.Controls.Add(this.btn_Guncelle);
            this.groupBox2.Controls.Add(this.tB_Fiyat_Update);
            this.groupBox2.Controls.Add(this.tB_Ad_Update);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(259, 274);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(229, 171);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün Güncelle";
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Location = new System.Drawing.Point(81, 124);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(140, 30);
            this.btn_Guncelle.TabIndex = 5;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // tB_Fiyat_Update
            // 
            this.tB_Fiyat_Update.Location = new System.Drawing.Point(81, 89);
            this.tB_Fiyat_Update.Name = "tB_Fiyat_Update";
            this.tB_Fiyat_Update.Size = new System.Drawing.Size(140, 26);
            this.tB_Fiyat_Update.TabIndex = 4;
            // 
            // tB_Ad_Update
            // 
            this.tB_Ad_Update.Location = new System.Drawing.Point(81, 57);
            this.tB_Ad_Update.Name = "tB_Ad_Update";
            this.tB_Ad_Update.Size = new System.Drawing.Size(140, 26);
            this.tB_Ad_Update.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fiyat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ad";
            // 
            // tB_ID_Update
            // 
            this.tB_ID_Update.Enabled = false;
            this.tB_ID_Update.Location = new System.Drawing.Point(81, 27);
            this.tB_ID_Update.Name = "tB_ID_Update";
            this.tB_ID_Update.Size = new System.Drawing.Size(140, 26);
            this.tB_ID_Update.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "ID";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Red;
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tB_ID_Delete);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.tB_Fiyat_Delete);
            this.groupBox3.Controls.Add(this.tB_Ad_Delete);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(498, 274);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox3.Size = new System.Drawing.Size(229, 171);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ürün Sil";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "ID";
            // 
            // tB_ID_Delete
            // 
            this.tB_ID_Delete.Enabled = false;
            this.tB_ID_Delete.Location = new System.Drawing.Point(81, 27);
            this.tB_ID_Delete.Name = "tB_ID_Delete";
            this.tB_ID_Delete.Size = new System.Drawing.Size(140, 26);
            this.tB_ID_Delete.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(81, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 30);
            this.button2.TabIndex = 5;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tB_Fiyat_Delete
            // 
            this.tB_Fiyat_Delete.Enabled = false;
            this.tB_Fiyat_Delete.Location = new System.Drawing.Point(81, 89);
            this.tB_Fiyat_Delete.Name = "tB_Fiyat_Delete";
            this.tB_Fiyat_Delete.Size = new System.Drawing.Size(140, 26);
            this.tB_Fiyat_Delete.TabIndex = 4;
            // 
            // tB_Ad_Delete
            // 
            this.tB_Ad_Delete.Enabled = false;
            this.tB_Ad_Delete.Location = new System.Drawing.Point(81, 57);
            this.tB_Ad_Delete.Name = "tB_Ad_Delete";
            this.tB_Ad_Delete.Size = new System.Drawing.Size(140, 26);
            this.tB_Ad_Delete.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 89);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Fiyat";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 63);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ad";
            // 
            // tB_Search
            // 
            this.tB_Search.Location = new System.Drawing.Point(627, 12);
            this.tB_Search.Name = "tB_Search";
            this.tB_Search.Size = new System.Drawing.Size(100, 26);
            this.tB_Search.TabIndex = 9;
            this.tB_Search.TextChanged += new System.EventHandler(this.tB_Search_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 468);
            this.Controls.Add(this.tB_Search);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tB_Fiyat;
        private System.Windows.Forms.TextBox tB_Ad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tB_ID_Update;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.TextBox tB_Fiyat_Update;
        private System.Windows.Forms.TextBox tB_Ad_Update;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tB_ID_Delete;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tB_Fiyat_Delete;
        private System.Windows.Forms.TextBox tB_Ad_Delete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tB_Search;
    }
}


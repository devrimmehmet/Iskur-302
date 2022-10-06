namespace WindowsForms10
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
            this.btn1 = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.tbt_adi = new System.Windows.Forms.TextBox();
            this.tbt_soyadi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_soyadi = new System.Windows.Forms.Label();
            this.lbl_adi = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Red;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn1.ForeColor = System.Drawing.Color.Transparent;
            this.btn1.Location = new System.Drawing.Point(12, 12);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(257, 38);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Salihin Kırmızı Butonu";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lbl1
            // 
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl1.Location = new System.Drawing.Point(23, 64);
            this.lbl1.Name = "lbl1";
            this.lbl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl1.Size = new System.Drawing.Size(123, 23);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Adı :";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl2
            // 
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl2.Location = new System.Drawing.Point(38, 106);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(80, 20);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Soyadı :";
            // 
            // tbt_adi
            // 
            this.tbt_adi.Location = new System.Drawing.Point(152, 67);
            this.tbt_adi.Name = "tbt_adi";
            this.tbt_adi.Size = new System.Drawing.Size(100, 20);
            this.tbt_adi.TabIndex = 3;
            // 
            // tbt_soyadi
            // 
            this.tbt_soyadi.Location = new System.Drawing.Point(152, 106);
            this.tbt_soyadi.Name = "tbt_soyadi";
            this.tbt_soyadi.Size = new System.Drawing.Size(100, 20);
            this.tbt_soyadi.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "ismi gönder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(379, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Soyadı :";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(364, 64);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(123, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Adı :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_soyadi
            // 
            this.lbl_soyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_soyadi.Location = new System.Drawing.Point(512, 106);
            this.lbl_soyadi.Name = "lbl_soyadi";
            this.lbl_soyadi.Size = new System.Drawing.Size(276, 20);
            this.lbl_soyadi.TabIndex = 9;
            this.lbl_soyadi.Text = "Soyadı :";
            this.lbl_soyadi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_adi
            // 
            this.lbl_adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_adi.Location = new System.Drawing.Point(508, 64);
            this.lbl_adi.Name = "lbl_adi";
            this.lbl_adi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_adi.Size = new System.Drawing.Size(287, 23);
            this.lbl_adi.TabIndex = 8;
            this.lbl_adi.Text = "Adı :";
            this.lbl_adi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(318, 166);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 10;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(37, 217);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(42, 190);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.lbl_soyadi);
            this.Controls.Add(this.lbl_adi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbt_soyadi);
            this.Controls.Add(this.tbt_adi);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox tbt_adi;
        private System.Windows.Forms.TextBox tbt_soyadi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_soyadi;
        private System.Windows.Forms.Label lbl_adi;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}


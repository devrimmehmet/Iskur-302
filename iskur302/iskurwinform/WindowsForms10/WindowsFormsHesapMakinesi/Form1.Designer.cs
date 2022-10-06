namespace WindowsFormsHesapMakinesi
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
            this.tB1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tB2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.z = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tB1
            // 
            this.tB1.Location = new System.Drawing.Point(108, 28);
            this.tB1.Name = "tB1";
            this.tB1.Size = new System.Drawing.Size(100, 20);
            this.tB1.TabIndex = 0;
            this.tB1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tB1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(53, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sayi1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(53, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sayi2";
            // 
            // tB2
            // 
            this.tB2.Location = new System.Drawing.Point(108, 54);
            this.tB2.Name = "tB2";
            this.tB2.Size = new System.Drawing.Size(100, 20);
            this.tB2.TabIndex = 2;
            this.tB2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tB2_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.comboBox1.Location = new System.Drawing.Point(96, 80);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // z
            // 
            this.z.AutoSize = true;
            this.z.ForeColor = System.Drawing.Color.Firebrick;
            this.z.Location = new System.Drawing.Point(318, 57);
            this.z.Name = "z";
            this.z.Size = new System.Drawing.Size(44, 13);
            this.z.TabIndex = 5;
            this.z.Text = "Sonuç: ";
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.ForeColor = System.Drawing.Color.Firebrick;
            this.lblSonuc.Location = new System.Drawing.Point(368, 57);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(0, 13);
            this.lblSonuc.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Firebrick;
            this.button1.Location = new System.Drawing.Point(119, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "İşlem Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(461, 144);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.z);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tB2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tB1);
            this.Name = "Form1";
            this.Text = "Hesap İşlemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tB1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tB2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label z;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Button button1;
    }
}


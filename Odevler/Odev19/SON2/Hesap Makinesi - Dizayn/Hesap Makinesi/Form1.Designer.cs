namespace Hesap_Makinesi
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
            this.btn_Equal = new System.Windows.Forms.Button();
            this.btn_Addition = new System.Windows.Forms.Button();
            this.btn_Virgule = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_Subtraction = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_Multiplication = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_Division = new System.Windows.Forms.Button();
            this.btn_Backspace = new System.Windows.Forms.Button();
            this.btn_C = new System.Windows.Forms.Button();
            this.lbl_Result = new System.Windows.Forms.Label();
            this.txt_Result = new System.Windows.Forms.TextBox();
            this.btn_CE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Equal
            // 
            this.btn_Equal.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Equal.Location = new System.Drawing.Point(21, 323);
            this.btn_Equal.Name = "btn_Equal";
            this.btn_Equal.Size = new System.Drawing.Size(214, 51);
            this.btn_Equal.TabIndex = 38;
            this.btn_Equal.Text = "=";
            this.btn_Equal.UseVisualStyleBackColor = false;
            this.btn_Equal.Click += new System.EventHandler(this.Click_Equal);
            // 
            // btn_Addition
            // 
            this.btn_Addition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Addition.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Addition.Location = new System.Drawing.Point(186, 227);
            this.btn_Addition.Name = "btn_Addition";
            this.btn_Addition.Size = new System.Drawing.Size(49, 90);
            this.btn_Addition.TabIndex = 36;
            this.btn_Addition.Text = "+";
            this.btn_Addition.UseVisualStyleBackColor = false;
            this.btn_Addition.Click += new System.EventHandler(this.Click_Operator);
            // 
            // btn_Virgule
            // 
            this.btn_Virgule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Virgule.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Virgule.Location = new System.Drawing.Point(131, 275);
            this.btn_Virgule.Name = "btn_Virgule";
            this.btn_Virgule.Size = new System.Drawing.Size(49, 42);
            this.btn_Virgule.TabIndex = 35;
            this.btn_Virgule.Text = ",";
            this.btn_Virgule.UseVisualStyleBackColor = false;
            this.btn_Virgule.Click += new System.EventHandler(this.Click_Virgule);
            // 
            // btn_0
            // 
            this.btn_0.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_0.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_0.Location = new System.Drawing.Point(21, 275);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(104, 42);
            this.btn_0.TabIndex = 34;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = false;
            this.btn_0.Click += new System.EventHandler(this.Click_Number);
            // 
            // btn_3
            // 
            this.btn_3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_3.Location = new System.Drawing.Point(131, 226);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(49, 43);
            this.btn_3.TabIndex = 33;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = false;
            this.btn_3.Click += new System.EventHandler(this.Click_Number);
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_2.Location = new System.Drawing.Point(76, 226);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(49, 43);
            this.btn_2.TabIndex = 32;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = false;
            this.btn_2.Click += new System.EventHandler(this.Click_Number);
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_1.Location = new System.Drawing.Point(21, 226);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(49, 43);
            this.btn_1.TabIndex = 31;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.Click_Number);
            // 
            // btn_Subtraction
            // 
            this.btn_Subtraction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Subtraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Subtraction.Location = new System.Drawing.Point(186, 177);
            this.btn_Subtraction.Name = "btn_Subtraction";
            this.btn_Subtraction.Size = new System.Drawing.Size(49, 43);
            this.btn_Subtraction.TabIndex = 30;
            this.btn_Subtraction.Text = "-";
            this.btn_Subtraction.UseVisualStyleBackColor = false;
            this.btn_Subtraction.Click += new System.EventHandler(this.Click_Operator);
            // 
            // btn_6
            // 
            this.btn_6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_6.Location = new System.Drawing.Point(131, 177);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(49, 43);
            this.btn_6.TabIndex = 29;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = false;
            this.btn_6.Click += new System.EventHandler(this.Click_Number);
            // 
            // btn_5
            // 
            this.btn_5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_5.Location = new System.Drawing.Point(76, 177);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(49, 43);
            this.btn_5.TabIndex = 28;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = false;
            this.btn_5.Click += new System.EventHandler(this.Click_Number);
            // 
            // btn_4
            // 
            this.btn_4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_4.Location = new System.Drawing.Point(21, 177);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(49, 43);
            this.btn_4.TabIndex = 27;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = false;
            this.btn_4.Click += new System.EventHandler(this.Click_Number);
            // 
            // btn_Multiplication
            // 
            this.btn_Multiplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Multiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Multiplication.Location = new System.Drawing.Point(186, 128);
            this.btn_Multiplication.Name = "btn_Multiplication";
            this.btn_Multiplication.Size = new System.Drawing.Size(49, 43);
            this.btn_Multiplication.TabIndex = 26;
            this.btn_Multiplication.Text = "x";
            this.btn_Multiplication.UseVisualStyleBackColor = false;
            this.btn_Multiplication.Click += new System.EventHandler(this.Click_Operator);
            // 
            // btn_9
            // 
            this.btn_9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_9.Location = new System.Drawing.Point(131, 128);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(49, 43);
            this.btn_9.TabIndex = 25;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = false;
            this.btn_9.Click += new System.EventHandler(this.Click_Number);
            // 
            // btn_8
            // 
            this.btn_8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_8.Location = new System.Drawing.Point(76, 128);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(49, 43);
            this.btn_8.TabIndex = 24;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = false;
            this.btn_8.Click += new System.EventHandler(this.Click_Number);
            // 
            // btn_7
            // 
            this.btn_7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_7.Location = new System.Drawing.Point(21, 128);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(49, 43);
            this.btn_7.TabIndex = 23;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = false;
            this.btn_7.Click += new System.EventHandler(this.Click_Number);
            // 
            // btn_Division
            // 
            this.btn_Division.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Division.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Division.Location = new System.Drawing.Point(186, 79);
            this.btn_Division.Name = "btn_Division";
            this.btn_Division.Size = new System.Drawing.Size(49, 43);
            this.btn_Division.TabIndex = 22;
            this.btn_Division.Text = "/";
            this.btn_Division.UseVisualStyleBackColor = false;
            this.btn_Division.Click += new System.EventHandler(this.Click_Operator);
            // 
            // btn_Backspace
            // 
            this.btn_Backspace.BackColor = System.Drawing.Color.Yellow;
            this.btn_Backspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Backspace.Location = new System.Drawing.Point(131, 79);
            this.btn_Backspace.Name = "btn_Backspace";
            this.btn_Backspace.Size = new System.Drawing.Size(49, 43);
            this.btn_Backspace.TabIndex = 21;
            this.btn_Backspace.Text = "<";
            this.btn_Backspace.UseVisualStyleBackColor = false;
            this.btn_Backspace.Click += new System.EventHandler(this.Click_Backspace);
            // 
            // btn_C
            // 
            this.btn_C.BackColor = System.Drawing.Color.Yellow;
            this.btn_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_C.Location = new System.Drawing.Point(21, 79);
            this.btn_C.Name = "btn_C";
            this.btn_C.Size = new System.Drawing.Size(49, 43);
            this.btn_C.TabIndex = 20;
            this.btn_C.Text = "C";
            this.btn_C.UseVisualStyleBackColor = false;
            this.btn_C.Click += new System.EventHandler(this.Click_C);
            // 
            // lbl_Result
            // 
            this.lbl_Result.AllowDrop = true;
            this.lbl_Result.Location = new System.Drawing.Point(21, 10);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(214, 30);
            this.lbl_Result.TabIndex = 39;
            this.lbl_Result.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_Result
            // 
            this.txt_Result.Enabled = false;
            this.txt_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Result.Location = new System.Drawing.Point(21, 43);
            this.txt_Result.Multiline = true;
            this.txt_Result.Name = "txt_Result";
            this.txt_Result.Size = new System.Drawing.Size(214, 30);
            this.txt_Result.TabIndex = 40;
            this.txt_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_CE
            // 
            this.btn_CE.BackColor = System.Drawing.Color.Yellow;
            this.btn_CE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_CE.Location = new System.Drawing.Point(76, 79);
            this.btn_CE.Name = "btn_CE";
            this.btn_CE.Size = new System.Drawing.Size(49, 43);
            this.btn_CE.TabIndex = 41;
            this.btn_CE.Text = "CE";
            this.btn_CE.UseVisualStyleBackColor = false;
            this.btn_CE.Click += new System.EventHandler(this.Click_CE);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 386);
            this.Controls.Add(this.btn_CE);
            this.Controls.Add(this.lbl_Result);
            this.Controls.Add(this.btn_Equal);
            this.Controls.Add(this.btn_Addition);
            this.Controls.Add(this.btn_Virgule);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_Subtraction);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_Multiplication);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_Division);
            this.Controls.Add(this.btn_Backspace);
            this.Controls.Add(this.btn_C);
            this.Controls.Add(this.txt_Result);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Equal;
        private System.Windows.Forms.Button btn_Addition;
        private System.Windows.Forms.Button btn_Virgule;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_Subtraction;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_Multiplication;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_Division;
        private System.Windows.Forms.Button btn_Backspace;
        private System.Windows.Forms.Button btn_C;
        private System.Windows.Forms.Label lbl_Result;
        protected internal System.Windows.Forms.TextBox txt_Result;
        private System.Windows.Forms.Button btn_CE;
    }
}





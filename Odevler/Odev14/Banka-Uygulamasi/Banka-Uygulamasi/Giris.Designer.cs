namespace Banka_Uygulamasi
{
    partial class Giris
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Bireysel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Kurumsal = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Bireysel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 260);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bireysel";
            // 
            // btn_Bireysel
            // 
            this.btn_Bireysel.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Bireysel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Bireysel.Location = new System.Drawing.Point(6, 30);
            this.btn_Bireysel.Name = "btn_Bireysel";
            this.btn_Bireysel.Size = new System.Drawing.Size(183, 222);
            this.btn_Bireysel.TabIndex = 0;
            this.btn_Bireysel.Text = "Bireysel Bankacılık";
            this.btn_Bireysel.UseVisualStyleBackColor = false;
            this.btn_Bireysel.Click += new System.EventHandler(this.btn_Bireysel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Kurumsal);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(213, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(195, 260);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kurumsal";
            // 
            // btn_Kurumsal
            // 
            this.btn_Kurumsal.BackColor = System.Drawing.SystemColors.Info;
            this.btn_Kurumsal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kurumsal.Location = new System.Drawing.Point(6, 30);
            this.btn_Kurumsal.Name = "btn_Kurumsal";
            this.btn_Kurumsal.Size = new System.Drawing.Size(183, 224);
            this.btn_Kurumsal.TabIndex = 1;
            this.btn_Kurumsal.Text = "Kurumsal Bankacılık";
            this.btn_Kurumsal.UseVisualStyleBackColor = false;
            this.btn_Kurumsal.Click += new System.EventHandler(this.btn_Kurumsal_Click);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(419, 276);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Giris";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bireysel - Kurumsal";
            this.Load += new System.EventHandler(this.Giris_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Bireysel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Kurumsal;
    }
}
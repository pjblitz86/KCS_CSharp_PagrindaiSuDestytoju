namespace FormsApplication
{
    partial class manoAplikacija
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
            this.Mygtukas = new System.Windows.Forms.Button();
            this.TekstoLaukas = new System.Windows.Forms.TextBox();
            this.varnele = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Mygtukas
            // 
            this.Mygtukas.Location = new System.Drawing.Point(400, 57);
            this.Mygtukas.Name = "Mygtukas";
            this.Mygtukas.Size = new System.Drawing.Size(162, 98);
            this.Mygtukas.TabIndex = 0;
            this.Mygtukas.Text = "button1";
            this.Mygtukas.UseVisualStyleBackColor = true;
            this.Mygtukas.Click += new System.EventHandler(this.button1_Click);
            // 
            // TekstoLaukas
            // 
            this.TekstoLaukas.Location = new System.Drawing.Point(65, 57);
            this.TekstoLaukas.Name = "TekstoLaukas";
            this.TekstoLaukas.Size = new System.Drawing.Size(207, 20);
            this.TekstoLaukas.TabIndex = 1;
            // 
            // varnele
            // 
            this.varnele.AutoSize = true;
            this.varnele.Location = new System.Drawing.Point(192, 83);
            this.varnele.Name = "varnele";
            this.varnele.Size = new System.Drawing.Size(80, 17);
            this.varnele.TabIndex = 2;
            this.varnele.Text = "checkBox1";
            this.varnele.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(65, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(497, 289);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // manoAplikacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 460);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.varnele);
            this.Controls.Add(this.TekstoLaukas);
            this.Controls.Add(this.Mygtukas);
            this.Name = "manoAplikacija";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Mygtukas;
        private System.Windows.Forms.TextBox TekstoLaukas;
        private System.Windows.Forms.CheckBox varnele;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


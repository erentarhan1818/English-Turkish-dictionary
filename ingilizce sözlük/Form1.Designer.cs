namespace ingilizce_sözlük
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
            this.Btnekle = new System.Windows.Forms.Button();
            this.btnBul = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btnekle
            // 
            this.Btnekle.Location = new System.Drawing.Point(222, 108);
            this.Btnekle.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Btnekle.Name = "Btnekle";
            this.Btnekle.Size = new System.Drawing.Size(175, 67);
            this.Btnekle.TabIndex = 0;
            this.Btnekle.Text = "Kelime Ekle";
            this.Btnekle.UseVisualStyleBackColor = true;
            this.Btnekle.Click += new System.EventHandler(this.Btnekle_Click);
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(222, 252);
            this.btnBul.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(175, 67);
            this.btnBul.TabIndex = 1;
            this.btnBul.Text = "Kelime Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(626, 430);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.Btnekle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Türkçe-İngilizce Sözlük Uygulaması";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btnekle;
        private System.Windows.Forms.Button btnBul;
    }
}


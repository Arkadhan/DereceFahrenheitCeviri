
namespace DereceFahrenheitCeviri
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDerece = new System.Windows.Forms.TextBox();
            this.tbFahrenheit = new System.Windows.Forms.TextBox();
            this.btnFahrenheit = new System.Windows.Forms.Button();
            this.btnDerece = new System.Windows.Forms.Button();
            this.lblDurum = new System.Windows.Forms.Label();
            this.btnKelvin = new System.Windows.Forms.Button();
            this.tbKelvin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Derece";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fahrenheit";
            // 
            // tbDerece
            // 
            this.tbDerece.Location = new System.Drawing.Point(17, 62);
            this.tbDerece.Name = "tbDerece";
            this.tbDerece.Size = new System.Drawing.Size(100, 20);
            this.tbDerece.TabIndex = 2;
            // 
            // tbFahrenheit
            // 
            this.tbFahrenheit.Location = new System.Drawing.Point(160, 62);
            this.tbFahrenheit.Name = "tbFahrenheit";
            this.tbFahrenheit.Size = new System.Drawing.Size(100, 20);
            this.tbFahrenheit.TabIndex = 3;
            // 
            // btnFahrenheit
            // 
            this.btnFahrenheit.Location = new System.Drawing.Point(29, 88);
            this.btnFahrenheit.Name = "btnFahrenheit";
            this.btnFahrenheit.Size = new System.Drawing.Size(75, 48);
            this.btnFahrenheit.TabIndex = 4;
            this.btnFahrenheit.Text = "Fahrenheit Dönüştür";
            this.btnFahrenheit.UseVisualStyleBackColor = true;
            this.btnFahrenheit.Click += new System.EventHandler(this.btnFahrenheit_Click);
            // 
            // btnDerece
            // 
            this.btnDerece.Location = new System.Drawing.Point(174, 88);
            this.btnDerece.Name = "btnDerece";
            this.btnDerece.Size = new System.Drawing.Size(75, 48);
            this.btnDerece.TabIndex = 5;
            this.btnDerece.Text = "Deredeye Dönüştür";
            this.btnDerece.UseVisualStyleBackColor = true;
            this.btnDerece.Click += new System.EventHandler(this.btnDerece_Click);
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(181, 183);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(41, 13);
            this.lblDurum.TabIndex = 6;
            this.lblDurum.Text = "Sonuç:";
            // 
            // btnKelvin
            // 
            this.btnKelvin.Location = new System.Drawing.Point(316, 88);
            this.btnKelvin.Name = "btnKelvin";
            this.btnKelvin.Size = new System.Drawing.Size(75, 48);
            this.btnKelvin.TabIndex = 9;
            this.btnKelvin.Text = "Deredeye Dönüştür";
            this.btnKelvin.UseVisualStyleBackColor = true;
            this.btnKelvin.Click += new System.EventHandler(this.btnKelvin_Click);
            // 
            // tbKelvin
            // 
            this.tbKelvin.Location = new System.Drawing.Point(302, 62);
            this.tbKelvin.Name = "tbKelvin";
            this.tbKelvin.Size = new System.Drawing.Size(100, 20);
            this.tbKelvin.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kelvin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 316);
            this.Controls.Add(this.btnKelvin);
            this.Controls.Add(this.tbKelvin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.btnDerece);
            this.Controls.Add(this.btnFahrenheit);
            this.Controls.Add(this.tbFahrenheit);
            this.Controls.Add(this.tbDerece);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDerece;
        private System.Windows.Forms.TextBox tbFahrenheit;
        private System.Windows.Forms.Button btnFahrenheit;
        private System.Windows.Forms.Button btnDerece;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Button btnKelvin;
        private System.Windows.Forms.TextBox tbKelvin;
        private System.Windows.Forms.Label label3;
    }
}


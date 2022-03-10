
namespace soru2
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
            this.yazdirma = new System.Windows.Forms.Button();
            this.toplama = new System.Windows.Forms.Button();
            this.okuma = new System.Windows.Forms.Button();
            this.carpma = new System.Windows.Forms.Button();
            this.iz = new System.Windows.Forms.Button();
            this.ters = new System.Windows.Forms.Button();
            this.transpoze = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yazdirma
            // 
            this.yazdirma.Location = new System.Drawing.Point(72, 541);
            this.yazdirma.Name = "yazdirma";
            this.yazdirma.Size = new System.Drawing.Size(150, 53);
            this.yazdirma.TabIndex = 3;
            this.yazdirma.Text = "Yazdırma";
            this.yazdirma.UseVisualStyleBackColor = true;
            this.yazdirma.Click += new System.EventHandler(this.yazdirma_Click);
            // 
            // toplama
            // 
            this.toplama.Location = new System.Drawing.Point(278, 541);
            this.toplama.Name = "toplama";
            this.toplama.Size = new System.Drawing.Size(150, 53);
            this.toplama.TabIndex = 4;
            this.toplama.Text = "Toplama";
            this.toplama.UseVisualStyleBackColor = true;
            this.toplama.Click += new System.EventHandler(this.toplama_Click);
            // 
            // okuma
            // 
            this.okuma.Location = new System.Drawing.Point(707, 541);
            this.okuma.Name = "okuma";
            this.okuma.Size = new System.Drawing.Size(150, 53);
            this.okuma.TabIndex = 6;
            this.okuma.Text = "Okuma";
            this.okuma.UseVisualStyleBackColor = true;
            this.okuma.Click += new System.EventHandler(this.okuma_Click);
            // 
            // carpma
            // 
            this.carpma.Location = new System.Drawing.Point(488, 541);
            this.carpma.Name = "carpma";
            this.carpma.Size = new System.Drawing.Size(150, 53);
            this.carpma.TabIndex = 5;
            this.carpma.Text = "Çarpma";
            this.carpma.UseVisualStyleBackColor = true;
            this.carpma.Click += new System.EventHandler(this.carpma_Click);
            // 
            // iz
            // 
            this.iz.Location = new System.Drawing.Point(1134, 541);
            this.iz.Name = "iz";
            this.iz.Size = new System.Drawing.Size(150, 53);
            this.iz.TabIndex = 8;
            this.iz.Text = "İzi bul";
            this.iz.UseVisualStyleBackColor = true;
            this.iz.Click += new System.EventHandler(this.iz_Click);
            // 
            // ters
            // 
            this.ters.Location = new System.Drawing.Point(931, 541);
            this.ters.Name = "ters";
            this.ters.Size = new System.Drawing.Size(150, 53);
            this.ters.TabIndex = 7;
            this.ters.Text = "Tersini Al";
            this.ters.UseVisualStyleBackColor = true;
            this.ters.Click += new System.EventHandler(this.ters_Click);
            // 
            // transpoze
            // 
            this.transpoze.Location = new System.Drawing.Point(1337, 541);
            this.transpoze.Name = "transpoze";
            this.transpoze.Size = new System.Drawing.Size(150, 53);
            this.transpoze.TabIndex = 9;
            this.transpoze.Text = "Transpoze";
            this.transpoze.UseVisualStyleBackColor = true;
            this.transpoze.Click += new System.EventHandler(this.transpoze_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1555, 732);
            this.Controls.Add(this.transpoze);
            this.Controls.Add(this.iz);
            this.Controls.Add(this.ters);
            this.Controls.Add(this.okuma);
            this.Controls.Add(this.carpma);
            this.Controls.Add(this.toplama);
            this.Controls.Add(this.yazdirma);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button yazdirma;
        private System.Windows.Forms.Button toplama;
        private System.Windows.Forms.Button okuma;
        private System.Windows.Forms.Button carpma;
        private System.Windows.Forms.Button iz;
        private System.Windows.Forms.Button ters;
        private System.Windows.Forms.Button transpoze;
    }
}


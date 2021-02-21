
namespace SesliSessizForms
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
            this.lgiris = new System.Windows.Forms.Label();
            this.tbKelime = new System.Windows.Forms.TextBox();
            this.lSesli = new System.Windows.Forms.Label();
            this.lSessiz = new System.Windows.Forms.Label();
            this.tbSesli = new System.Windows.Forms.TextBox();
            this.tbSessiz = new System.Windows.Forms.TextBox();
            this.bKaydet = new System.Windows.Forms.Button();
            this.bTemizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lgiris
            // 
            this.lgiris.AutoSize = true;
            this.lgiris.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgiris.Location = new System.Drawing.Point(12, 22);
            this.lgiris.Name = "lgiris";
            this.lgiris.Size = new System.Drawing.Size(223, 29);
            this.lgiris.TabIndex = 0;
            this.lgiris.Text = "Kelimenizi giriniz:";
            // 
            // tbKelime
            // 
            this.tbKelime.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKelime.Location = new System.Drawing.Point(258, 12);
            this.tbKelime.Name = "tbKelime";
            this.tbKelime.Size = new System.Drawing.Size(385, 39);
            this.tbKelime.TabIndex = 1;
            // 
            // lSesli
            // 
            this.lSesli.AutoSize = true;
            this.lSesli.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSesli.Location = new System.Drawing.Point(129, 107);
            this.lSesli.Name = "lSesli";
            this.lSesli.Size = new System.Drawing.Size(103, 20);
            this.lSesli.TabIndex = 2;
            this.lSesli.Text = "Sesli Harfler";
            // 
            // lSessiz
            // 
            this.lSessiz.AutoSize = true;
            this.lSessiz.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSessiz.Location = new System.Drawing.Point(413, 104);
            this.lSessiz.Name = "lSessiz";
            this.lSessiz.Size = new System.Drawing.Size(127, 23);
            this.lSessiz.TabIndex = 2;
            this.lSessiz.Text = "Sessiz Harfler";
            // 
            // tbSesli
            // 
            this.tbSesli.Enabled = false;
            this.tbSesli.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbSesli.Location = new System.Drawing.Point(97, 134);
            this.tbSesli.Name = "tbSesli";
            this.tbSesli.Size = new System.Drawing.Size(176, 29);
            this.tbSesli.TabIndex = 3;
            // 
            // tbSessiz
            // 
            this.tbSessiz.Enabled = false;
            this.tbSessiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbSessiz.Location = new System.Drawing.Point(381, 134);
            this.tbSessiz.Name = "tbSessiz";
            this.tbSessiz.Size = new System.Drawing.Size(187, 29);
            this.tbSessiz.TabIndex = 3;
            // 
            // bKaydet
            // 
            this.bKaydet.Location = new System.Drawing.Point(683, 22);
            this.bKaydet.Name = "bKaydet";
            this.bKaydet.Size = new System.Drawing.Size(105, 23);
            this.bKaydet.TabIndex = 4;
            this.bKaydet.Text = "Kaydet";
            this.bKaydet.UseVisualStyleBackColor = true;
            this.bKaydet.Click += new System.EventHandler(this.button1_Click);
            // 
            // bTemizle
            // 
            this.bTemizle.Location = new System.Drawing.Point(683, 69);
            this.bTemizle.Name = "bTemizle";
            this.bTemizle.Size = new System.Drawing.Size(105, 23);
            this.bTemizle.TabIndex = 4;
            this.bTemizle.Text = "Temizle";
            this.bTemizle.UseVisualStyleBackColor = true;
            this.bTemizle.Click += new System.EventHandler(this.bTemizle_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.bKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bTemizle);
            this.Controls.Add(this.bKaydet);
            this.Controls.Add(this.tbSessiz);
            this.Controls.Add(this.tbSesli);
            this.Controls.Add(this.lSessiz);
            this.Controls.Add(this.lSesli);
            this.Controls.Add(this.tbKelime);
            this.Controls.Add(this.lgiris);
            this.Name = "Form1";
            this.Text = "SESLİ SESSİZ HARF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lgiris;
        private System.Windows.Forms.TextBox tbKelime;
        private System.Windows.Forms.Label lSesli;
        private System.Windows.Forms.Label lSessiz;
        private System.Windows.Forms.TextBox tbSesli;
        private System.Windows.Forms.TextBox tbSessiz;
        private System.Windows.Forms.Button bKaydet;
        private System.Windows.Forms.Button bTemizle;
    }
}


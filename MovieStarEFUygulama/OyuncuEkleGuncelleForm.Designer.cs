namespace MovieStarEFUygulama
{
    partial class OyuncuEkleGuncelleForm
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
            this.txtAdSoyAd = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEkleGuncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAdSoyAd
            // 
            this.txtAdSoyAd.Location = new System.Drawing.Point(131, 54);
            this.txtAdSoyAd.Margin = new System.Windows.Forms.Padding(6);
            this.txtAdSoyAd.Name = "txtAdSoyAd";
            this.txtAdSoyAd.Size = new System.Drawing.Size(180, 29);
            this.txtAdSoyAd.TabIndex = 0;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(131, 96);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(6);
            this.txtTelefon.MaxLength = 13;
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(180, 29);
            this.txtTelefon.TabIndex = 0;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(131, 144);
            this.txtAdres.Margin = new System.Windows.Forms.Padding(6);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(180, 191);
            this.txtAdres.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Adres:";
            // 
            // btnEkleGuncelle
            // 
            this.btnEkleGuncelle.Location = new System.Drawing.Point(131, 344);
            this.btnEkleGuncelle.Name = "btnEkleGuncelle";
            this.btnEkleGuncelle.Size = new System.Drawing.Size(180, 35);
            this.btnEkleGuncelle.TabIndex = 2;
            this.btnEkleGuncelle.Text = "Ekle";
            this.btnEkleGuncelle.UseVisualStyleBackColor = true;
            this.btnEkleGuncelle.Click += new System.EventHandler(this.btnEkleGuncelle_Click);
            // 
            // OyuncuEkleGuncelleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 392);
            this.Controls.Add(this.btnEkleGuncelle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtAdSoyAd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "OyuncuEkleGuncelleForm";
            this.Text = "OyuncuEkleGuncelleForm";
            this.Load += new System.EventHandler(this.OyuncuEkleGuncelleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdSoyAd;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEkleGuncelle;
    }
}
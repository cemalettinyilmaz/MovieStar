namespace MovieStarEFUygulama
{
    partial class FilmOyuncuGuncelleForm
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
            this.dgvFilminOyunculari = new System.Windows.Forms.DataGridView();
            this.OyuncuID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OyuncuAdSoyad1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTumOyuncular = new System.Windows.Forms.DataGridView();
            this.OyuncuID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OyuncuAdSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFilmAdi = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilminOyunculari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTumOyuncular)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFilminOyunculari
            // 
            this.dgvFilminOyunculari.AllowUserToAddRows = false;
            this.dgvFilminOyunculari.AllowUserToDeleteRows = false;
            this.dgvFilminOyunculari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFilminOyunculari.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFilminOyunculari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilminOyunculari.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OyuncuID1,
            this.OyuncuAdSoyad1});
            this.dgvFilminOyunculari.Location = new System.Drawing.Point(432, 132);
            this.dgvFilminOyunculari.MultiSelect = false;
            this.dgvFilminOyunculari.Name = "dgvFilminOyunculari";
            this.dgvFilminOyunculari.ReadOnly = true;
            this.dgvFilminOyunculari.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFilminOyunculari.Size = new System.Drawing.Size(278, 390);
            this.dgvFilminOyunculari.TabIndex = 0;
            // 
            // OyuncuID1
            // 
            this.OyuncuID1.FillWeight = 50.76142F;
            this.OyuncuID1.HeaderText = "OyuncuID";
            this.OyuncuID1.Name = "OyuncuID1";
            this.OyuncuID1.ReadOnly = true;
            // 
            // OyuncuAdSoyad1
            // 
            this.OyuncuAdSoyad1.FillWeight = 149.2386F;
            this.OyuncuAdSoyad1.HeaderText = "Oyuncu Ad Soyad";
            this.OyuncuAdSoyad1.Name = "OyuncuAdSoyad1";
            this.OyuncuAdSoyad1.ReadOnly = true;
            // 
            // dgvTumOyuncular
            // 
            this.dgvTumOyuncular.AllowUserToAddRows = false;
            this.dgvTumOyuncular.AllowUserToDeleteRows = false;
            this.dgvTumOyuncular.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTumOyuncular.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTumOyuncular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTumOyuncular.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OyuncuID,
            this.OyuncuAdSoyad});
            this.dgvTumOyuncular.Location = new System.Drawing.Point(28, 132);
            this.dgvTumOyuncular.Name = "dgvTumOyuncular";
            this.dgvTumOyuncular.ReadOnly = true;
            this.dgvTumOyuncular.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTumOyuncular.Size = new System.Drawing.Size(290, 390);
            this.dgvTumOyuncular.TabIndex = 1;
            // 
            // OyuncuID
            // 
            this.OyuncuID.FillWeight = 50.76142F;
            this.OyuncuID.HeaderText = "OyuncuID";
            this.OyuncuID.Name = "OyuncuID";
            this.OyuncuID.ReadOnly = true;
            // 
            // OyuncuAdSoyad
            // 
            this.OyuncuAdSoyad.FillWeight = 149.2386F;
            this.OyuncuAdSoyad.HeaderText = "Oyuncu Adı";
            this.OyuncuAdSoyad.Name = "OyuncuAdSoyad";
            this.OyuncuAdSoyad.ReadOnly = true;
            // 
            // lblFilmAdi
            // 
            this.lblFilmAdi.AutoSize = true;
            this.lblFilmAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFilmAdi.Location = new System.Drawing.Point(51, 46);
            this.lblFilmAdi.Name = "lblFilmAdi";
            this.lblFilmAdi.Size = new System.Drawing.Size(84, 24);
            this.lblFilmAdi.TabIndex = 2;
            this.lblFilmAdi.Text = "Film Adi:";
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(352, 250);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(42, 24);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "=>";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(352, 308);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(42, 24);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "X";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(113, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tüm Oyuncular";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(513, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Filmin Oyuncuları";
            // 
            // FilmOyuncuGuncelleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 555);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lblFilmAdi);
            this.Controls.Add(this.dgvTumOyuncular);
            this.Controls.Add(this.dgvFilminOyunculari);
            this.Name = "FilmOyuncuGuncelleForm";
            this.Text = "FilmOyuncuGuncelleForm";
            this.Load += new System.EventHandler(this.FilmOyuncuGuncelleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilminOyunculari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTumOyuncular)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFilminOyunculari;
        private System.Windows.Forms.DataGridView dgvTumOyuncular;
        private System.Windows.Forms.Label lblFilmAdi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn OyuncuID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn OyuncuAdSoyad1;
        private System.Windows.Forms.DataGridViewTextBoxColumn OyuncuID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OyuncuAdSoyad;
    }
}
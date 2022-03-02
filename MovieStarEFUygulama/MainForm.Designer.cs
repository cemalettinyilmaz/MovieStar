namespace MovieStarEFUygulama
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiOyuncular = new System.Windows.Forms.ToolStripMenuItem();
            this.türlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oyuncuGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.türGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvFilmler = new System.Windows.Forms.DataGridView();
            this.FilmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilmAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Poster = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMDBPuani = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imdbID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TurAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Oyuncular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pboFilmPoster = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilmAra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTur = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboFilmPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOyuncular,
            this.türlerToolStripMenuItem,
            this.filmlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(925, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiOyuncular
            // 
            this.tsmiOyuncular.Name = "tsmiOyuncular";
            this.tsmiOyuncular.Size = new System.Drawing.Size(74, 20);
            this.tsmiOyuncular.Text = "Oyuncular";
            this.tsmiOyuncular.Click += new System.EventHandler(this.tsmiOyuncular_Click);
            // 
            // türlerToolStripMenuItem
            // 
            this.türlerToolStripMenuItem.Name = "türlerToolStripMenuItem";
            this.türlerToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.türlerToolStripMenuItem.Text = "Tür Ekle";
            this.türlerToolStripMenuItem.Click += new System.EventHandler(this.türlerToolStripMenuItem_Click);
            // 
            // filmlerToolStripMenuItem
            // 
            this.filmlerToolStripMenuItem.Name = "filmlerToolStripMenuItem";
            this.filmlerToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.filmlerToolStripMenuItem.Text = "Film Ekle";
            this.filmlerToolStripMenuItem.Click += new System.EventHandler(this.filmlerToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem,
            this.güncelleToolStripMenuItem,
            this.oyuncuGüncelleToolStripMenuItem,
            this.türGüncelleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(166, 92);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.güncelleToolStripMenuItem.Text = "Güncelle";
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.güncelleToolStripMenuItem_Click);
            // 
            // oyuncuGüncelleToolStripMenuItem
            // 
            this.oyuncuGüncelleToolStripMenuItem.Name = "oyuncuGüncelleToolStripMenuItem";
            this.oyuncuGüncelleToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.oyuncuGüncelleToolStripMenuItem.Text = "Oyuncu Güncelle";
            this.oyuncuGüncelleToolStripMenuItem.Click += new System.EventHandler(this.oyuncuGüncelleToolStripMenuItem_Click);
            // 
            // türGüncelleToolStripMenuItem
            // 
            this.türGüncelleToolStripMenuItem.Name = "türGüncelleToolStripMenuItem";
            this.türGüncelleToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.türGüncelleToolStripMenuItem.Text = "Tür Güncelle";
            this.türGüncelleToolStripMenuItem.Click += new System.EventHandler(this.türGüncelleToolStripMenuItem_Click);
            // 
            // dgvFilmler
            // 
            this.dgvFilmler.AllowUserToAddRows = false;
            this.dgvFilmler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFilmler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFilmler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFilmler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilmler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FilmID,
            this.FilmAdi,
            this.Poster,
            this.Yil,
            this.IMDBPuani,
            this.imdbID,
            this.TurAdi,
            this.Oyuncular});
            this.dgvFilmler.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvFilmler.Location = new System.Drawing.Point(12, 81);
            this.dgvFilmler.MultiSelect = false;
            this.dgvFilmler.Name = "dgvFilmler";
            this.dgvFilmler.ReadOnly = true;
            this.dgvFilmler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFilmler.Size = new System.Drawing.Size(595, 460);
            this.dgvFilmler.TabIndex = 1;
            this.dgvFilmler.SelectionChanged += new System.EventHandler(this.dgvFilmler_SelectionChanged);
            this.dgvFilmler.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvFilmler_MouseDown);
            // 
            // FilmID
            // 
            this.FilmID.HeaderText = "FilmID";
            this.FilmID.Name = "FilmID";
            this.FilmID.ReadOnly = true;
            // 
            // FilmAdi
            // 
            this.FilmAdi.HeaderText = "FilmAdi";
            this.FilmAdi.Name = "FilmAdi";
            this.FilmAdi.ReadOnly = true;
            // 
            // Poster
            // 
            this.Poster.HeaderText = "Poster";
            this.Poster.Name = "Poster";
            this.Poster.ReadOnly = true;
            // 
            // Yil
            // 
            this.Yil.HeaderText = "Yil";
            this.Yil.Name = "Yil";
            this.Yil.ReadOnly = true;
            // 
            // IMDBPuani
            // 
            this.IMDBPuani.HeaderText = "IMDB Puani";
            this.IMDBPuani.Name = "IMDBPuani";
            this.IMDBPuani.ReadOnly = true;
            // 
            // imdbID
            // 
            this.imdbID.HeaderText = "imdb ID";
            this.imdbID.Name = "imdbID";
            this.imdbID.ReadOnly = true;
            // 
            // TurAdi
            // 
            this.TurAdi.HeaderText = "Tür Adi";
            this.TurAdi.Name = "TurAdi";
            this.TurAdi.ReadOnly = true;
            // 
            // Oyuncular
            // 
            this.Oyuncular.HeaderText = "Oyuncular";
            this.Oyuncular.Name = "Oyuncular";
            this.Oyuncular.ReadOnly = true;
            // 
            // pboFilmPoster
            // 
            this.pboFilmPoster.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pboFilmPoster.Location = new System.Drawing.Point(613, 91);
            this.pboFilmPoster.Name = "pboFilmPoster";
            this.pboFilmPoster.Size = new System.Drawing.Size(300, 450);
            this.pboFilmPoster.TabIndex = 2;
            this.pboFilmPoster.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Film Ara";
            // 
            // txtFilmAra
            // 
            this.txtFilmAra.Location = new System.Drawing.Point(72, 55);
            this.txtFilmAra.Name = "txtFilmAra";
            this.txtFilmAra.Size = new System.Drawing.Size(183, 20);
            this.txtFilmAra.TabIndex = 4;
            this.txtFilmAra.TextChanged += new System.EventHandler(this.txtFilmAra_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(454, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tür:";
            // 
            // cmbTur
            // 
            this.cmbTur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTur.FormattingEnabled = true;
            this.cmbTur.Location = new System.Drawing.Point(486, 54);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Size = new System.Drawing.Size(121, 21);
            this.cmbTur.TabIndex = 6;
            this.cmbTur.SelectedIndexChanged += new System.EventHandler(this.cmbTur_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 550);
            this.Controls.Add(this.cmbTur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFilmAra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pboFilmPoster);
            this.Controls.Add(this.dgvFilmler);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboFilmPoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiOyuncular;
        private System.Windows.Forms.DataGridView dgvFilmler;
        private System.Windows.Forms.PictureBox pboFilmPoster;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilmAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Poster;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yil;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMDBPuani;
        private System.Windows.Forms.DataGridViewTextBoxColumn imdbID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TurAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oyuncular;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oyuncuGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem türGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem türlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmlerToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilmAra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTur;
    }
}


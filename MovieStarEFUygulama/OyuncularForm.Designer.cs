namespace MovieStarEFUygulama
{
    partial class OyuncularForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.OyuncuID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OyuncuAdSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOyuncuEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OyuncuID,
            this.OyuncuAdSoyad,
            this.Adres,
            this.TelefonNO});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(776, 397);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDown);
            // 
            // OyuncuID
            // 
            this.OyuncuID.HeaderText = "OyuncuID";
            this.OyuncuID.Name = "OyuncuID";
            this.OyuncuID.ReadOnly = true;
            // 
            // OyuncuAdSoyad
            // 
            this.OyuncuAdSoyad.HeaderText = "OyuncuAdSoyad";
            this.OyuncuAdSoyad.Name = "OyuncuAdSoyad";
            this.OyuncuAdSoyad.ReadOnly = true;
            // 
            // Adres
            // 
            this.Adres.HeaderText = "Adres";
            this.Adres.Name = "Adres";
            this.Adres.ReadOnly = true;
            // 
            // TelefonNO
            // 
            this.TelefonNO.HeaderText = "TelefonNO";
            this.TelefonNO.Name = "TelefonNO";
            this.TelefonNO.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.güncelleToolStripMenuItem,
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(121, 48);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.güncelleToolStripMenuItem.Text = "Güncelle";
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.güncelleToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // btnOyuncuEkle
            // 
            this.btnOyuncuEkle.Location = new System.Drawing.Point(639, 12);
            this.btnOyuncuEkle.Name = "btnOyuncuEkle";
            this.btnOyuncuEkle.Size = new System.Drawing.Size(149, 23);
            this.btnOyuncuEkle.TabIndex = 1;
            this.btnOyuncuEkle.Text = "Oyuncu Ekle";
            this.btnOyuncuEkle.UseVisualStyleBackColor = true;
            this.btnOyuncuEkle.Click += new System.EventHandler(this.btnOyuncuEkle_Click);
            // 
            // OyuncularForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOyuncuEkle);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OyuncularForm";
            this.Text = "OyuncularForm";
            this.Load += new System.EventHandler(this.OyuncularForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnOyuncuEkle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn OyuncuID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OyuncuAdSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adres;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonNO;
    }
}
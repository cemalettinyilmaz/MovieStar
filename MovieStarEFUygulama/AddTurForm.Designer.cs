namespace MovieStarEFUygulama
{
    partial class AddTurForm
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
            this.txtTurAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTurler = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.guncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurler)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTurAdi
            // 
            this.txtTurAdi.Location = new System.Drawing.Point(94, 15);
            this.txtTurAdi.Name = "txtTurAdi";
            this.txtTurAdi.Size = new System.Drawing.Size(208, 20);
            this.txtTurAdi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tür Adı:";
            // 
            // dgvTurler
            // 
            this.dgvTurler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTurler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTurler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurler.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvTurler.Location = new System.Drawing.Point(37, 51);
            this.dgvTurler.MultiSelect = false;
            this.dgvTurler.Name = "dgvTurler";
            this.dgvTurler.ReadOnly = true;
            this.dgvTurler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTurler.Size = new System.Drawing.Size(265, 271);
            this.dgvTurler.TabIndex = 2;
            this.dgvTurler.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvTurler_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guncelleToolStripMenuItem,
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(121, 48);
            // 
            // guncelleToolStripMenuItem
            // 
            this.guncelleToolStripMenuItem.Name = "guncelleToolStripMenuItem";
            this.guncelleToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.guncelleToolStripMenuItem.Text = "Guncelle";
            this.guncelleToolStripMenuItem.Click += new System.EventHandler(this.guncelleToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(227, 347);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(146, 347);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(75, 23);
            this.btnIptal.TabIndex = 5;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Visible = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // AddTurForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 390);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dgvTurler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTurAdi);
            this.Name = "AddTurForm";
            this.Text = "AddTurForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurler)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTurAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTurler;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem guncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.Button btnIptal;
    }
}
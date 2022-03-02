namespace MovieStarEFUygulama
{
    partial class AddFilmForm
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
            this.txtFilmAdi = new System.Windows.Forms.TextBox();
            this.txtPoster = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudImdb = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTur = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.nudYil = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudImdb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYil)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFilmAdi
            // 
            this.txtFilmAdi.Location = new System.Drawing.Point(146, 20);
            this.txtFilmAdi.Margin = new System.Windows.Forms.Padding(6);
            this.txtFilmAdi.Name = "txtFilmAdi";
            this.txtFilmAdi.Size = new System.Drawing.Size(338, 29);
            this.txtFilmAdi.TabIndex = 0;
            // 
            // txtPoster
            // 
            this.txtPoster.Location = new System.Drawing.Point(146, 116);
            this.txtPoster.Margin = new System.Windows.Forms.Padding(6);
            this.txtPoster.Name = "txtPoster";
            this.txtPoster.Size = new System.Drawing.Size(338, 29);
            this.txtPoster.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Film Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yıl :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Poster Yolu:";
            // 
            // nudImdb
            // 
            this.nudImdb.DecimalPlaces = 1;
            this.nudImdb.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudImdb.Location = new System.Drawing.Point(146, 168);
            this.nudImdb.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            65536});
            this.nudImdb.Name = "nudImdb";
            this.nudImdb.Size = new System.Drawing.Size(186, 29);
            this.nudImdb.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "IMDB Puani:";
            // 
            // cmbTur
            // 
            this.cmbTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTur.FormattingEnabled = true;
            this.cmbTur.Location = new System.Drawing.Point(146, 217);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Size = new System.Drawing.Size(186, 32);
            this.cmbTur.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 220);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tür:";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(272, 285);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(212, 44);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // nudYil
            // 
            this.nudYil.Location = new System.Drawing.Point(146, 71);
            this.nudYil.Maximum = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            this.nudYil.Minimum = new decimal(new int[] {
            1700,
            0,
            0,
            0});
            this.nudYil.Name = "nudYil";
            this.nudYil.Size = new System.Drawing.Size(338, 29);
            this.nudYil.TabIndex = 5;
            this.nudYil.Value = new decimal(new int[] {
            1700,
            0,
            0,
            0});
            // 
            // AddFilmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 379);
            this.Controls.Add(this.nudYil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.cmbTur);
            this.Controls.Add(this.nudImdb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPoster);
            this.Controls.Add(this.txtFilmAdi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AddFilmForm";
            this.Text = "AddFilmForm";
            this.Load += new System.EventHandler(this.AddFilmForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudImdb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilmAdi;
        private System.Windows.Forms.TextBox txtPoster;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudImdb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.NumericUpDown nudYil;
    }
}
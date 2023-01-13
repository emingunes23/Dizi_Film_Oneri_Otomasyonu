namespace Ntp_Proje
{
    partial class BenzerFilm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BenzerFilm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Lblimdb = new System.Windows.Forms.Label();
            this.LblAd = new System.Windows.Forms.Label();
            this.LblTuru = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button14 = new System.Windows.Forms.Button();
            this.databaseDataSet4 = new Ntp_Proje.DatabaseDataSet4();
            this.filmKaydetmeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmKaydetmeTableAdapter = new Ntp_Proje.DatabaseDataSet4TableAdapters.FilmKaydetmeTableAdapter();
            this.filmidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmTuruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmYonetmenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmimdbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmSeriSayısiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmTarziDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmYiliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmFilitrelemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmKaydetmeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Lblimdb);
            this.panel1.Controls.Add(this.LblAd);
            this.panel1.Controls.Add(this.LblTuru);
            this.panel1.Location = new System.Drawing.Point(101, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 100);
            this.panel1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(533, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "Film İmdb:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(539, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "Film Türü:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Benzeri Diziler";
            // 
            // Lblimdb
            // 
            this.Lblimdb.AutoSize = true;
            this.Lblimdb.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblimdb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lblimdb.Location = new System.Drawing.Point(678, 62);
            this.Lblimdb.Name = "Lblimdb";
            this.Lblimdb.Size = new System.Drawing.Size(50, 27);
            this.Lblimdb.TabIndex = 3;
            this.Lblimdb.Text = "null";
            // 
            // LblAd
            // 
            this.LblAd.AutoSize = true;
            this.LblAd.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LblAd.Location = new System.Drawing.Point(48, 22);
            this.LblAd.Name = "LblAd";
            this.LblAd.Size = new System.Drawing.Size(58, 31);
            this.LblAd.TabIndex = 1;
            this.LblAd.Text = "null";
            // 
            // LblTuru
            // 
            this.LblTuru.AutoSize = true;
            this.LblTuru.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTuru.ForeColor = System.Drawing.Color.White;
            this.LblTuru.Location = new System.Drawing.Point(678, 22);
            this.LblTuru.Name = "LblTuru";
            this.LblTuru.Size = new System.Drawing.Size(50, 27);
            this.LblTuru.TabIndex = 2;
            this.LblTuru.Text = "null";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.filmidDataGridViewTextBoxColumn,
            this.filmAdiDataGridViewTextBoxColumn,
            this.filmTuruDataGridViewTextBoxColumn,
            this.filmYonetmenDataGridViewTextBoxColumn,
            this.filmimdbDataGridViewTextBoxColumn,
            this.filmSeriSayısiDataGridViewTextBoxColumn,
            this.filmTarziDataGridViewTextBoxColumn,
            this.filmYiliDataGridViewTextBoxColumn,
            this.filmFilitrelemeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.filmKaydetmeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(28, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1466, 462);
            this.dataGridView1.TabIndex = 6;
            // 
            // button14
            // 
            this.button14.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button14.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button14.BackgroundImage")));
            this.button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button14.Location = new System.Drawing.Point(12, 12);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(37, 45);
            this.button14.TabIndex = 108;
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // databaseDataSet4
            // 
            this.databaseDataSet4.DataSetName = "DatabaseDataSet4";
            this.databaseDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmKaydetmeBindingSource
            // 
            this.filmKaydetmeBindingSource.DataMember = "FilmKaydetme";
            this.filmKaydetmeBindingSource.DataSource = this.databaseDataSet4;
            // 
            // filmKaydetmeTableAdapter
            // 
            this.filmKaydetmeTableAdapter.ClearBeforeFill = true;
            // 
            // filmidDataGridViewTextBoxColumn
            // 
            this.filmidDataGridViewTextBoxColumn.DataPropertyName = "Filmid";
            this.filmidDataGridViewTextBoxColumn.HeaderText = "Filmid";
            this.filmidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.filmidDataGridViewTextBoxColumn.Name = "filmidDataGridViewTextBoxColumn";
            this.filmidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // filmAdiDataGridViewTextBoxColumn
            // 
            this.filmAdiDataGridViewTextBoxColumn.DataPropertyName = "FilmAdi";
            this.filmAdiDataGridViewTextBoxColumn.HeaderText = "FilmAdi";
            this.filmAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.filmAdiDataGridViewTextBoxColumn.Name = "filmAdiDataGridViewTextBoxColumn";
            // 
            // filmTuruDataGridViewTextBoxColumn
            // 
            this.filmTuruDataGridViewTextBoxColumn.DataPropertyName = "FilmTuru";
            this.filmTuruDataGridViewTextBoxColumn.HeaderText = "FilmTuru";
            this.filmTuruDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.filmTuruDataGridViewTextBoxColumn.Name = "filmTuruDataGridViewTextBoxColumn";
            // 
            // filmYonetmenDataGridViewTextBoxColumn
            // 
            this.filmYonetmenDataGridViewTextBoxColumn.DataPropertyName = "FilmYonetmen";
            this.filmYonetmenDataGridViewTextBoxColumn.HeaderText = "FilmYonetmen";
            this.filmYonetmenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.filmYonetmenDataGridViewTextBoxColumn.Name = "filmYonetmenDataGridViewTextBoxColumn";
            // 
            // filmimdbDataGridViewTextBoxColumn
            // 
            this.filmimdbDataGridViewTextBoxColumn.DataPropertyName = "Filmimdb";
            this.filmimdbDataGridViewTextBoxColumn.HeaderText = "Filmimdb";
            this.filmimdbDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.filmimdbDataGridViewTextBoxColumn.Name = "filmimdbDataGridViewTextBoxColumn";
            // 
            // filmSeriSayısiDataGridViewTextBoxColumn
            // 
            this.filmSeriSayısiDataGridViewTextBoxColumn.DataPropertyName = "FilmSeriSayısi";
            this.filmSeriSayısiDataGridViewTextBoxColumn.HeaderText = "FilmSeriSayısi";
            this.filmSeriSayısiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.filmSeriSayısiDataGridViewTextBoxColumn.Name = "filmSeriSayısiDataGridViewTextBoxColumn";
            // 
            // filmTarziDataGridViewTextBoxColumn
            // 
            this.filmTarziDataGridViewTextBoxColumn.DataPropertyName = "FilmTarzi";
            this.filmTarziDataGridViewTextBoxColumn.HeaderText = "FilmTarzi";
            this.filmTarziDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.filmTarziDataGridViewTextBoxColumn.Name = "filmTarziDataGridViewTextBoxColumn";
            // 
            // filmYiliDataGridViewTextBoxColumn
            // 
            this.filmYiliDataGridViewTextBoxColumn.DataPropertyName = "FilmYili";
            this.filmYiliDataGridViewTextBoxColumn.HeaderText = "FilmYili";
            this.filmYiliDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.filmYiliDataGridViewTextBoxColumn.Name = "filmYiliDataGridViewTextBoxColumn";
            // 
            // filmFilitrelemeDataGridViewTextBoxColumn
            // 
            this.filmFilitrelemeDataGridViewTextBoxColumn.DataPropertyName = "FilmFilitreleme";
            this.filmFilitrelemeDataGridViewTextBoxColumn.HeaderText = "FilmFilitreleme";
            this.filmFilitrelemeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.filmFilitrelemeDataGridViewTextBoxColumn.Name = "filmFilitrelemeDataGridViewTextBoxColumn";
            // 
            // BenzerFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1522, 729);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BenzerFilm";
            this.Text = "BenzerFilm";
            this.Load += new System.EventHandler(this.BenzerFilm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmKaydetmeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lblimdb;
        private System.Windows.Forms.Label LblAd;
        private System.Windows.Forms.Label LblTuru;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DatabaseDataSet4 databaseDataSet4;
        private System.Windows.Forms.BindingSource filmKaydetmeBindingSource;
        private DatabaseDataSet4TableAdapters.FilmKaydetmeTableAdapter filmKaydetmeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmTuruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmYonetmenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmimdbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmSeriSayısiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmTarziDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmYiliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmFilitrelemeDataGridViewTextBoxColumn;
    }
}
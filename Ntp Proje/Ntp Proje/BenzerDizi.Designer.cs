namespace Ntp_Proje
{
    partial class BenzerDizi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BenzerDizi));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LblAd = new System.Windows.Forms.Label();
            this.LblTuru = new System.Windows.Forms.Label();
            this.Lblimdb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button14 = new System.Windows.Forms.Button();
            this.databaseDataSet5 = new Ntp_Proje.DatabaseDataSet5();
            this.diziKaydetmeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diziKaydetmeTableAdapter = new Ntp_Proje.DatabaseDataSet5TableAdapters.DiziKaydetmeTableAdapter();
            this.diziidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diziAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diziTuruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diziYonetmenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diziimdbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diziSezonSayisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diziTarziDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diziYiliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diziFilitrelemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diziKaydetmeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.diziidDataGridViewTextBoxColumn,
            this.diziAdiDataGridViewTextBoxColumn,
            this.diziTuruDataGridViewTextBoxColumn,
            this.diziYonetmenDataGridViewTextBoxColumn,
            this.diziimdbDataGridViewTextBoxColumn,
            this.diziSezonSayisiDataGridViewTextBoxColumn,
            this.diziTarziDataGridViewTextBoxColumn,
            this.diziYiliDataGridViewTextBoxColumn,
            this.diziFilitrelemeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.diziKaydetmeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(34, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1466, 462);
            this.dataGridView1.TabIndex = 0;
            // 
            // LblAd
            // 
            this.LblAd.AutoSize = true;
            this.LblAd.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LblAd.Location = new System.Drawing.Point(27, 13);
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
            this.LblTuru.Location = new System.Drawing.Point(610, 17);
            this.LblTuru.Name = "LblTuru";
            this.LblTuru.Size = new System.Drawing.Size(50, 27);
            this.LblTuru.TabIndex = 2;
            this.LblTuru.Text = "null";
            // 
            // Lblimdb
            // 
            this.Lblimdb.AutoSize = true;
            this.Lblimdb.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblimdb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Lblimdb.Location = new System.Drawing.Point(610, 57);
            this.Lblimdb.Name = "Lblimdb";
            this.Lblimdb.Size = new System.Drawing.Size(50, 27);
            this.Lblimdb.TabIndex = 3;
            this.Lblimdb.Text = "null";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Benzeri Diziler";
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
            this.panel1.Location = new System.Drawing.Point(136, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 100);
            this.panel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(484, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dizi İmdb:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(490, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dizi Türü:";
            // 
            // button14
            // 
            this.button14.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button14.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button14.BackgroundImage")));
            this.button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button14.Location = new System.Drawing.Point(12, 12);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(37, 45);
            this.button14.TabIndex = 107;
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // databaseDataSet5
            // 
            this.databaseDataSet5.DataSetName = "DatabaseDataSet5";
            this.databaseDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // diziKaydetmeBindingSource
            // 
            this.diziKaydetmeBindingSource.DataMember = "DiziKaydetme";
            this.diziKaydetmeBindingSource.DataSource = this.databaseDataSet5;
            // 
            // diziKaydetmeTableAdapter
            // 
            this.diziKaydetmeTableAdapter.ClearBeforeFill = true;
            // 
            // diziidDataGridViewTextBoxColumn
            // 
            this.diziidDataGridViewTextBoxColumn.DataPropertyName = "Diziid";
            this.diziidDataGridViewTextBoxColumn.HeaderText = "Diziid";
            this.diziidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diziidDataGridViewTextBoxColumn.Name = "diziidDataGridViewTextBoxColumn";
            this.diziidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diziAdiDataGridViewTextBoxColumn
            // 
            this.diziAdiDataGridViewTextBoxColumn.DataPropertyName = "DiziAdi";
            this.diziAdiDataGridViewTextBoxColumn.HeaderText = "DiziAdi";
            this.diziAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diziAdiDataGridViewTextBoxColumn.Name = "diziAdiDataGridViewTextBoxColumn";
            // 
            // diziTuruDataGridViewTextBoxColumn
            // 
            this.diziTuruDataGridViewTextBoxColumn.DataPropertyName = "DiziTuru";
            this.diziTuruDataGridViewTextBoxColumn.HeaderText = "DiziTuru";
            this.diziTuruDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diziTuruDataGridViewTextBoxColumn.Name = "diziTuruDataGridViewTextBoxColumn";
            // 
            // diziYonetmenDataGridViewTextBoxColumn
            // 
            this.diziYonetmenDataGridViewTextBoxColumn.DataPropertyName = "DiziYonetmen";
            this.diziYonetmenDataGridViewTextBoxColumn.HeaderText = "DiziYonetmen";
            this.diziYonetmenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diziYonetmenDataGridViewTextBoxColumn.Name = "diziYonetmenDataGridViewTextBoxColumn";
            // 
            // diziimdbDataGridViewTextBoxColumn
            // 
            this.diziimdbDataGridViewTextBoxColumn.DataPropertyName = "Diziimdb";
            this.diziimdbDataGridViewTextBoxColumn.HeaderText = "Diziimdb";
            this.diziimdbDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diziimdbDataGridViewTextBoxColumn.Name = "diziimdbDataGridViewTextBoxColumn";
            // 
            // diziSezonSayisiDataGridViewTextBoxColumn
            // 
            this.diziSezonSayisiDataGridViewTextBoxColumn.DataPropertyName = "DiziSezonSayisi";
            this.diziSezonSayisiDataGridViewTextBoxColumn.HeaderText = "DiziSezonSayisi";
            this.diziSezonSayisiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diziSezonSayisiDataGridViewTextBoxColumn.Name = "diziSezonSayisiDataGridViewTextBoxColumn";
            // 
            // diziTarziDataGridViewTextBoxColumn
            // 
            this.diziTarziDataGridViewTextBoxColumn.DataPropertyName = "DiziTarzi";
            this.diziTarziDataGridViewTextBoxColumn.HeaderText = "DiziTarzi";
            this.diziTarziDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diziTarziDataGridViewTextBoxColumn.Name = "diziTarziDataGridViewTextBoxColumn";
            // 
            // diziYiliDataGridViewTextBoxColumn
            // 
            this.diziYiliDataGridViewTextBoxColumn.DataPropertyName = "DiziYili";
            this.diziYiliDataGridViewTextBoxColumn.HeaderText = "DiziYili";
            this.diziYiliDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diziYiliDataGridViewTextBoxColumn.Name = "diziYiliDataGridViewTextBoxColumn";
            // 
            // diziFilitrelemeDataGridViewTextBoxColumn
            // 
            this.diziFilitrelemeDataGridViewTextBoxColumn.DataPropertyName = "DiziFilitreleme";
            this.diziFilitrelemeDataGridViewTextBoxColumn.HeaderText = "DiziFilitreleme";
            this.diziFilitrelemeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diziFilitrelemeDataGridViewTextBoxColumn.Name = "diziFilitrelemeDataGridViewTextBoxColumn";
            // 
            // BenzerDizi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::Ntp_Proje.Properties.Resources._220_2205714_get_the_latest_movies_data_src_kodi_tv1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1522, 729);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BenzerDizi";
            this.Text = "BenzerDizi";
            this.Load += new System.EventHandler(this.BenzerDizi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diziKaydetmeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LblAd;
        private System.Windows.Forms.Label LblTuru;
        private System.Windows.Forms.Label Lblimdb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DatabaseDataSet5 databaseDataSet5;
        private System.Windows.Forms.BindingSource diziKaydetmeBindingSource;
        private DatabaseDataSet5TableAdapters.DiziKaydetmeTableAdapter diziKaydetmeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn diziidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diziAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diziTuruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diziYonetmenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diziimdbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diziSezonSayisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diziTarziDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diziYiliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diziFilitrelemeDataGridViewTextBoxColumn;
    }
}
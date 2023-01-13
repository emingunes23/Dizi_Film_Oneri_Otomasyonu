namespace Ntp_Proje
{
    partial class DiziFilmSayfası
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiziFilmSayfası));
            this.BtnGeri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnDizi = new System.Windows.Forms.Button();
            this.BtnFilm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnGeri
            // 
            this.BtnGeri.BackgroundImage = global::Ntp_Proje.Properties.Resources.png_clipart_arrow_symbol_computer_icons_back_angle_rectangle_thumbnail;
            this.BtnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnGeri.Location = new System.Drawing.Point(0, 0);
            this.BtnGeri.Name = "BtnGeri";
            this.BtnGeri.Size = new System.Drawing.Size(37, 45);
            this.BtnGeri.TabIndex = 3;
            this.BtnGeri.UseVisualStyleBackColor = true;
            this.BtnGeri.Click += new System.EventHandler(this.button13_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(532, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 31);
            this.label1.TabIndex = 107;
            this.label1.Text = "DİZİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(868, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 31);
            this.label2.TabIndex = 108;
            this.label2.Text = "FİLM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(87, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(496, 37);
            this.label3.TabIndex = 109;
            this.label3.Text = "DİZİ-FİLM ÖNERİ OTOMASYONU";
            // 
            // BtnDizi
            // 
            this.BtnDizi.BackColor = System.Drawing.Color.Transparent;
            this.BtnDizi.BackgroundImage = global::Ntp_Proje.Properties.Resources.dce38iv_c126dcac_1629_4a7b_b410_4eb8546227a7;
            this.BtnDizi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDizi.Location = new System.Drawing.Point(475, 217);
            this.BtnDizi.Name = "BtnDizi";
            this.BtnDizi.Size = new System.Drawing.Size(216, 189);
            this.BtnDizi.TabIndex = 1;
            this.BtnDizi.UseVisualStyleBackColor = false;
            this.BtnDizi.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnFilm
            // 
            this.BtnFilm.BackColor = System.Drawing.Color.Transparent;
            this.BtnFilm.BackgroundImage = global::Ntp_Proje.Properties.Resources.d66qy9l_3cdd9fd2_64b9_4fee_96de_d3400927d4d11;
            this.BtnFilm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnFilm.Location = new System.Drawing.Point(791, 217);
            this.BtnFilm.Name = "BtnFilm";
            this.BtnFilm.Size = new System.Drawing.Size(207, 189);
            this.BtnFilm.TabIndex = 2;
            this.BtnFilm.UseVisualStyleBackColor = false;
            this.BtnFilm.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.BtnDizi);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.BtnFilm);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(320, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1036, 598);
            this.panel1.TabIndex = 110;
            // 
            // DiziFilmSayfası
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1435, 698);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnGeri);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DiziFilmSayfası";
            this.Text = "Form10";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnGeri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnDizi;
        private System.Windows.Forms.Button BtnFilm;
        private System.Windows.Forms.Panel panel1;
    }
}
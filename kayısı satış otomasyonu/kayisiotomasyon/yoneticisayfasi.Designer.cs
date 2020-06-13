namespace kayisiotomasyon
{
    partial class yoneticisayfasi
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
            this.btn_AnaSayfa = new System.Windows.Forms.Button();
            this.btn_StokGüncelle = new System.Windows.Forms.Button();
            this.btn_SaticiEkle = new System.Windows.Forms.Button();
            this.btn_SaticiSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_AnaSayfa
            // 
            this.btn_AnaSayfa.Location = new System.Drawing.Point(13, 12);
            this.btn_AnaSayfa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_AnaSayfa.Name = "btn_AnaSayfa";
            this.btn_AnaSayfa.Size = new System.Drawing.Size(120, 43);
            this.btn_AnaSayfa.TabIndex = 0;
            this.btn_AnaSayfa.Text = "Anasayfa";
            this.btn_AnaSayfa.UseVisualStyleBackColor = true;
            this.btn_AnaSayfa.Click += new System.EventHandler(this.btn_AnaSayfa_Click);
            // 
            // btn_StokGüncelle
            // 
            this.btn_StokGüncelle.Location = new System.Drawing.Point(13, 109);
            this.btn_StokGüncelle.Name = "btn_StokGüncelle";
            this.btn_StokGüncelle.Size = new System.Drawing.Size(246, 46);
            this.btn_StokGüncelle.TabIndex = 3;
            this.btn_StokGüncelle.Text = "Stok Güncelle";
            this.btn_StokGüncelle.UseVisualStyleBackColor = true;
            this.btn_StokGüncelle.Click += new System.EventHandler(this.btn_StokGüncelle_Click);
            // 
            // btn_SaticiEkle
            // 
            this.btn_SaticiEkle.Location = new System.Drawing.Point(13, 161);
            this.btn_SaticiEkle.Name = "btn_SaticiEkle";
            this.btn_SaticiEkle.Size = new System.Drawing.Size(120, 65);
            this.btn_SaticiEkle.TabIndex = 4;
            this.btn_SaticiEkle.Text = "Satıcı Ekle";
            this.btn_SaticiEkle.UseVisualStyleBackColor = true;
            this.btn_SaticiEkle.Click += new System.EventHandler(this.btn_SaticiEkle_Click);
            // 
            // btn_SaticiSil
            // 
            this.btn_SaticiSil.Location = new System.Drawing.Point(139, 161);
            this.btn_SaticiSil.Name = "btn_SaticiSil";
            this.btn_SaticiSil.Size = new System.Drawing.Size(120, 65);
            this.btn_SaticiSil.TabIndex = 5;
            this.btn_SaticiSil.Text = "Satıcı Sil";
            this.btn_SaticiSil.UseVisualStyleBackColor = true;
            this.btn_SaticiSil.Click += new System.EventHandler(this.btn_SaticiSil_Click);
            // 
            // yoneticisayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kayisiotomasyon.Properties.Resources.Apricot_PNG_transparent_images_free_download_clipart_pics_Apricot_PNG_Transparent_Image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(675, 551);
            this.Controls.Add(this.btn_SaticiSil);
            this.Controls.Add(this.btn_SaticiEkle);
            this.Controls.Add(this.btn_StokGüncelle);
            this.Controls.Add(this.btn_AnaSayfa);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "yoneticisayfasi";
            this.Text = "Yönetici Sayfası";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_AnaSayfa;
        private System.Windows.Forms.Button btn_StokGüncelle;
        private System.Windows.Forms.Button btn_SaticiEkle;
        private System.Windows.Forms.Button btn_SaticiSil;
    }
}
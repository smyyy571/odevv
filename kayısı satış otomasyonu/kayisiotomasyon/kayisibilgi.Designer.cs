namespace kayisiotomasyon
{
    partial class kayisibilgi
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_StokDurumu = new System.Windows.Forms.Label();
            this.btn_Anasayfa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_miktar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_iban = new System.Windows.Forms.TextBox();
            this.btn_SatinAl = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_adres = new System.Windows.Forms.TextBox();
            this.lbl_fiyat7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stokta ne kadar kaldı";
            // 
            // lbl_StokDurumu
            // 
            this.lbl_StokDurumu.AutoSize = true;
            this.lbl_StokDurumu.Location = new System.Drawing.Point(320, 90);
            this.lbl_StokDurumu.Name = "lbl_StokDurumu";
            this.lbl_StokDurumu.Size = new System.Drawing.Size(64, 22);
            this.lbl_StokDurumu.TabIndex = 1;
            this.lbl_StokDurumu.Text = "label2";
            // 
            // btn_Anasayfa
            // 
            this.btn_Anasayfa.Location = new System.Drawing.Point(13, 13);
            this.btn_Anasayfa.Name = "btn_Anasayfa";
            this.btn_Anasayfa.Size = new System.Drawing.Size(136, 31);
            this.btn_Anasayfa.TabIndex = 2;
            this.btn_Anasayfa.Text = "AnaSayfa";
            this.btn_Anasayfa.UseVisualStyleBackColor = true;
            this.btn_Anasayfa.Click += new System.EventHandler(this.btn_Anasayfa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Satın almak istediğiniz miktar (kg)";
            // 
            // txt_miktar
            // 
            this.txt_miktar.Location = new System.Drawing.Point(406, 161);
            this.txt_miktar.Name = "txt_miktar";
            this.txt_miktar.Size = new System.Drawing.Size(100, 30);
            this.txt_miktar.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "İban Numarası";
            // 
            // txt_iban
            // 
            this.txt_iban.Location = new System.Drawing.Point(406, 198);
            this.txt_iban.Name = "txt_iban";
            this.txt_iban.Size = new System.Drawing.Size(100, 30);
            this.txt_iban.TabIndex = 6;
            // 
            // btn_SatinAl
            // 
            this.btn_SatinAl.Location = new System.Drawing.Point(322, 290);
            this.btn_SatinAl.Name = "btn_SatinAl";
            this.btn_SatinAl.Size = new System.Drawing.Size(184, 37);
            this.btn_SatinAl.TabIndex = 7;
            this.btn_SatinAl.Text = "Satın Al";
            this.btn_SatinAl.UseVisualStyleBackColor = true;
            this.btn_SatinAl.Click += new System.EventHandler(this.btn_SatinAl_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Adres";
            // 
            // txt_adres
            // 
            this.txt_adres.Location = new System.Drawing.Point(406, 243);
            this.txt_adres.Name = "txt_adres";
            this.txt_adres.Size = new System.Drawing.Size(100, 30);
            this.txt_adres.TabIndex = 9;
            // 
            // lbl_fiyat7
            // 
            this.lbl_fiyat7.AutoSize = true;
            this.lbl_fiyat7.Location = new System.Drawing.Point(496, 22);
            this.lbl_fiyat7.Name = "lbl_fiyat7";
            this.lbl_fiyat7.Size = new System.Drawing.Size(48, 22);
            this.lbl_fiyat7.TabIndex = 10;
            this.lbl_fiyat7.Text = "fiyat";
            // 
            // kayisibilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kayisiotomasyon.Properties.Resources.Apricot_PNG_transparent_images_free_download_clipart_pics_Apricot_PNG_Transparent_Image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(956, 635);
            this.Controls.Add(this.lbl_fiyat7);
            this.Controls.Add(this.txt_adres);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_SatinAl);
            this.Controls.Add(this.txt_iban);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_miktar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Anasayfa);
            this.Controls.Add(this.lbl_StokDurumu);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "kayisibilgi";
            this.Text = "Kayısı Bilgi";
            this.Load += new System.EventHandler(this.kayisibilgi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Anasayfa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_miktar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_iban;
        private System.Windows.Forms.Button btn_SatinAl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_adres;
        public System.Windows.Forms.Label lbl_StokDurumu;
        public System.Windows.Forms.Label lbl_fiyat7;
    }
}
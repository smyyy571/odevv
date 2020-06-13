namespace kayisiotomasyon
{
    partial class Saticisil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Saticisil));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_SaticiSec = new System.Windows.Forms.ComboBox();
            this.btn_Satici_Sil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(16, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Yönetici Sayfası";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Satıcı Seç";
            // 
            // cmb_SaticiSec
            // 
            this.cmb_SaticiSec.FormattingEnabled = true;
            this.cmb_SaticiSec.Location = new System.Drawing.Point(150, 89);
            this.cmb_SaticiSec.Name = "cmb_SaticiSec";
            this.cmb_SaticiSec.Size = new System.Drawing.Size(121, 30);
            this.cmb_SaticiSec.TabIndex = 2;
            // 
            // btn_Satici_Sil
            // 
            this.btn_Satici_Sil.Location = new System.Drawing.Point(160, 151);
            this.btn_Satici_Sil.Name = "btn_Satici_Sil";
            this.btn_Satici_Sil.Size = new System.Drawing.Size(111, 32);
            this.btn_Satici_Sil.TabIndex = 3;
            this.btn_Satici_Sil.Text = "Satıcı Sil";
            this.btn_Satici_Sil.UseVisualStyleBackColor = true;
            this.btn_Satici_Sil.Click += new System.EventHandler(this.btn_Satici_Sil_Click);
            // 
            // Saticisil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kayisiotomasyon.Properties.Resources.Apricot_PNG_transparent_images_free_download_clipart_pics_Apricot_PNG_Transparent_Image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(849, 579);
            this.Controls.Add(this.btn_Satici_Sil);
            this.Controls.Add(this.cmb_SaticiSec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Saticisil";
            this.Text = "Satıcı Sil";
            this.Load += new System.EventHandler(this.Saticisil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_SaticiSec;
        private System.Windows.Forms.Button btn_Satici_Sil;
    }
}
namespace kayisiotomasyon
{
    partial class saticisayfası
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
            this.btn_Müsteriler = new System.Windows.Forms.Button();
            this.btn_Satis_Durumu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_AnaSayfa
            // 
            this.btn_AnaSayfa.Location = new System.Drawing.Point(13, 13);
            this.btn_AnaSayfa.Name = "btn_AnaSayfa";
            this.btn_AnaSayfa.Size = new System.Drawing.Size(124, 37);
            this.btn_AnaSayfa.TabIndex = 0;
            this.btn_AnaSayfa.Text = "AnaSayfa";
            this.btn_AnaSayfa.UseVisualStyleBackColor = true;
            this.btn_AnaSayfa.Click += new System.EventHandler(this.btn_AnaSayfa_Click);
            // 
            // btn_Müsteriler
            // 
            this.btn_Müsteriler.Location = new System.Drawing.Point(13, 88);
            this.btn_Müsteriler.Name = "btn_Müsteriler";
            this.btn_Müsteriler.Size = new System.Drawing.Size(181, 45);
            this.btn_Müsteriler.TabIndex = 1;
            this.btn_Müsteriler.Text = "Müşteriler";
            this.btn_Müsteriler.UseVisualStyleBackColor = true;
            this.btn_Müsteriler.Click += new System.EventHandler(this.btn_Müsteriler_Click);
            // 
            // btn_Satis_Durumu
            // 
            this.btn_Satis_Durumu.Location = new System.Drawing.Point(13, 151);
            this.btn_Satis_Durumu.Name = "btn_Satis_Durumu";
            this.btn_Satis_Durumu.Size = new System.Drawing.Size(181, 49);
            this.btn_Satis_Durumu.TabIndex = 2;
            this.btn_Satis_Durumu.Text = "Satış Durumu";
            this.btn_Satis_Durumu.UseVisualStyleBackColor = true;
            this.btn_Satis_Durumu.Click += new System.EventHandler(this.btn_Satis_Durumu_Click);
            // 
            // saticisayfası
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 279);
            this.Controls.Add(this.btn_Satis_Durumu);
            this.Controls.Add(this.btn_Müsteriler);
            this.Controls.Add(this.btn_AnaSayfa);
            this.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "saticisayfası";
            this.Text = "Satıcı Sayfası";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_AnaSayfa;
        private System.Windows.Forms.Button btn_Müsteriler;
        private System.Windows.Forms.Button btn_Satis_Durumu;
    }
}
namespace Tiff2PDF
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.btn = new System.Windows.Forms.Button();
            this.lstbx = new System.Windows.Forms.ListBox();
            this.tbxFolderPath = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtb
            // 
            this.rtb.Location = new System.Drawing.Point(12, 166);
            this.rtb.Name = "rtb";
            this.rtb.Size = new System.Drawing.Size(755, 279);
            this.rtb.TabIndex = 0;
            this.rtb.Text = "";
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(618, 101);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 2;
            this.btn.Text = "Dosya seç";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstbx
            // 
            this.lstbx.FormattingEnabled = true;
            this.lstbx.Location = new System.Drawing.Point(295, 94);
            this.lstbx.Name = "lstbx";
            this.lstbx.Size = new System.Drawing.Size(200, 56);
            this.lstbx.TabIndex = 3;
            // 
            // tbxFolderPath
            // 
            this.tbxFolderPath.Location = new System.Drawing.Point(607, 130);
            this.tbxFolderPath.Name = "tbxFolderPath";
            this.tbxFolderPath.Size = new System.Drawing.Size(100, 20);
            this.tbxFolderPath.TabIndex = 4;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(365, 47);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 41);
            this.button.TabIndex = 5;
            this.button.Text = "Tiff\'i pdfe Çevir";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button);
            this.Controls.Add(this.tbxFolderPath);
            this.Controls.Add(this.lstbx);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.rtb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.ListBox lstbx;
        private System.Windows.Forms.TextBox tbxFolderPath;
        private System.Windows.Forms.Button button;
    }
}


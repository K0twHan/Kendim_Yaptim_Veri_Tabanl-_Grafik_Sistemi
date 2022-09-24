namespace Kendim_Yaptim_Veri_Tabanlı_Grafik_Sistemi
{
    partial class FrmGiris
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Txtilce = new System.Windows.Forms.TextBox();
            this.TxtA = new System.Windows.Forms.TextBox();
            this.TxtB = new System.Windows.Forms.TextBox();
            this.TxtC = new System.Windows.Forms.TextBox();
            this.TxtD = new System.Windows.Forms.TextBox();
            this.TxtE = new System.Windows.Forms.TextBox();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "İlçe Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "A partisi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "B partisi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "C partisi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "D partisi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "E partisi:";
            // 
            // Txtilce
            // 
            this.Txtilce.Location = new System.Drawing.Point(123, 59);
            this.Txtilce.Name = "Txtilce";
            this.Txtilce.Size = new System.Drawing.Size(307, 30);
            this.Txtilce.TabIndex = 6;
            // 
            // TxtA
            // 
            this.TxtA.Location = new System.Drawing.Point(123, 124);
            this.TxtA.Name = "TxtA";
            this.TxtA.Size = new System.Drawing.Size(307, 30);
            this.TxtA.TabIndex = 7;
            // 
            // TxtB
            // 
            this.TxtB.Location = new System.Drawing.Point(123, 179);
            this.TxtB.Name = "TxtB";
            this.TxtB.Size = new System.Drawing.Size(307, 30);
            this.TxtB.TabIndex = 8;
            // 
            // TxtC
            // 
            this.TxtC.Location = new System.Drawing.Point(123, 229);
            this.TxtC.Name = "TxtC";
            this.TxtC.Size = new System.Drawing.Size(307, 30);
            this.TxtC.TabIndex = 9;
            // 
            // TxtD
            // 
            this.TxtD.Location = new System.Drawing.Point(123, 283);
            this.TxtD.Name = "TxtD";
            this.TxtD.Size = new System.Drawing.Size(307, 30);
            this.TxtD.TabIndex = 10;
            // 
            // TxtE
            // 
            this.TxtE.Location = new System.Drawing.Point(123, 334);
            this.TxtE.Name = "TxtE";
            this.TxtE.Size = new System.Drawing.Size(307, 30);
            this.TxtE.TabIndex = 11;
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(26, 378);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(408, 44);
            this.BtnKaydet.TabIndex = 12;
            this.BtnKaydet.Text = "Verileri Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(26, 428);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 44);
            this.button2.TabIndex = 13;
            this.button2.Text = "Grafikleri Göster";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(223, 428);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(211, 44);
            this.button3.TabIndex = 14;
            this.button3.Text = "Çıkış Yap";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(508, 503);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.TxtE);
            this.Controls.Add(this.TxtD);
            this.Controls.Add(this.TxtC);
            this.Controls.Add(this.TxtB);
            this.Controls.Add(this.TxtA);
            this.Controls.Add(this.Txtilce);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGiris";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txtilce;
        private System.Windows.Forms.TextBox TxtA;
        private System.Windows.Forms.TextBox TxtB;
        private System.Windows.Forms.TextBox TxtC;
        private System.Windows.Forms.TextBox TxtD;
        private System.Windows.Forms.TextBox TxtE;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}


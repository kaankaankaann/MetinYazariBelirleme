namespace Metin_Yazari_Belirleme
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.agacaAktarBtn = new System.Windows.Forms.Button();
            this.kelimeleriGetirBtn = new System.Windows.Forms.Button();
            this.lvlKelimeler = new System.Windows.Forms.ListView();
            this.KullanimSayisi = new System.Windows.Forms.ColumnHeader();
            this.Kelime = new System.Windows.Forms.ColumnHeader();
            this.hashOlusturbtn = new System.Windows.Forms.Button();
            this.MetinYukleBtn = new System.Windows.Forms.Button();
            this.stackeOkuBtn = new System.Windows.Forms.Button();
            this.lblCumleSayisi = new System.Windows.Forms.Label();
            this.lblDosyaYolu = new System.Windows.Forms.Label();
            this.lblOrtKelimeSayisi = new System.Windows.Forms.Label();
            this.lvlCumle = new System.Windows.Forms.ListView();
            this.kelimeSayisi = new System.Windows.Forms.ColumnHeader();
            this.cumle = new System.Windows.Forms.ColumnHeader();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.kullanimSayisiLbl = new System.Windows.Forms.Label();
            this.kelimeLbl = new System.Windows.Forms.Label();
            this.kelimeAraBtn = new System.Windows.Forms.Button();
            this.kelimeAraTxt = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // agacaAktarBtn
            // 
            this.agacaAktarBtn.Location = new System.Drawing.Point(14, 16);
            this.agacaAktarBtn.Name = "agacaAktarBtn";
            this.agacaAktarBtn.Size = new System.Drawing.Size(150, 50);
            this.agacaAktarBtn.TabIndex = 8;
            this.agacaAktarBtn.Text = "Ağaca Aktar";
            this.agacaAktarBtn.UseVisualStyleBackColor = true;
            this.agacaAktarBtn.Click += new System.EventHandler(this.agacaAktarBtn_Click);
            // 
            // kelimeleriGetirBtn
            // 
            this.kelimeleriGetirBtn.Location = new System.Drawing.Point(13, 72);
            this.kelimeleriGetirBtn.Name = "kelimeleriGetirBtn";
            this.kelimeleriGetirBtn.Size = new System.Drawing.Size(150, 50);
            this.kelimeleriGetirBtn.TabIndex = 9;
            this.kelimeleriGetirBtn.Text = "En Sık Kullanılan Kelimeleri Getir";
            this.kelimeleriGetirBtn.UseVisualStyleBackColor = true;
            this.kelimeleriGetirBtn.Click += new System.EventHandler(this.kelimeleriGetirBtn_Click);
            // 
            // lvlKelimeler
            // 
            this.lvlKelimeler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.KullanimSayisi,
            this.Kelime});
            this.lvlKelimeler.HideSelection = false;
            this.lvlKelimeler.Location = new System.Drawing.Point(169, 16);
            this.lvlKelimeler.Name = "lvlKelimeler";
            this.lvlKelimeler.Size = new System.Drawing.Size(364, 157);
            this.lvlKelimeler.TabIndex = 10;
            this.lvlKelimeler.UseCompatibleStateImageBehavior = false;
            this.lvlKelimeler.View = System.Windows.Forms.View.Details;
            // 
            // KullanimSayisi
            // 
            this.KullanimSayisi.Text = "Kullanım Sayısı";
            this.KullanimSayisi.Width = 150;
            // 
            // Kelime
            // 
            this.Kelime.Text = "Kelime";
            this.Kelime.Width = 200;
            // 
            // hashOlusturbtn
            // 
            this.hashOlusturbtn.Location = new System.Drawing.Point(15, 16);
            this.hashOlusturbtn.Name = "hashOlusturbtn";
            this.hashOlusturbtn.Size = new System.Drawing.Size(150, 50);
            this.hashOlusturbtn.TabIndex = 11;
            this.hashOlusturbtn.Text = "Hash Tablo Oluştur";
            this.hashOlusturbtn.UseVisualStyleBackColor = true;
            this.hashOlusturbtn.Click += new System.EventHandler(this.hashOlusturbtn_Click);
            // 
            // MetinYukleBtn
            // 
            this.MetinYukleBtn.Location = new System.Drawing.Point(13, 21);
            this.MetinYukleBtn.Name = "MetinYukleBtn";
            this.MetinYukleBtn.Size = new System.Drawing.Size(150, 50);
            this.MetinYukleBtn.TabIndex = 0;
            this.MetinYukleBtn.Text = "Metin Yükle";
            this.MetinYukleBtn.UseVisualStyleBackColor = true;
            this.MetinYukleBtn.Click += new System.EventHandler(this.MetinYukleBtn_Click);
            // 
            // stackeOkuBtn
            // 
            this.stackeOkuBtn.Location = new System.Drawing.Point(14, 77);
            this.stackeOkuBtn.Name = "stackeOkuBtn";
            this.stackeOkuBtn.Size = new System.Drawing.Size(150, 50);
            this.stackeOkuBtn.TabIndex = 1;
            this.stackeOkuBtn.Text = "Stack’e Oku";
            this.stackeOkuBtn.UseVisualStyleBackColor = true;
            this.stackeOkuBtn.Click += new System.EventHandler(this.stackeOkuBtn_Click);
            // 
            // lblCumleSayisi
            // 
            this.lblCumleSayisi.AutoSize = true;
            this.lblCumleSayisi.Location = new System.Drawing.Point(628, 209);
            this.lblCumleSayisi.Name = "lblCumleSayisi";
            this.lblCumleSayisi.Size = new System.Drawing.Size(99, 20);
            this.lblCumleSayisi.TabIndex = 5;
            this.lblCumleSayisi.Text = "Cümle Sayısı: ";
            // 
            // lblDosyaYolu
            // 
            this.lblDosyaYolu.AutoSize = true;
            this.lblDosyaYolu.Location = new System.Drawing.Point(14, 209);
            this.lblDosyaYolu.Name = "lblDosyaYolu";
            this.lblDosyaYolu.Size = new System.Drawing.Size(89, 20);
            this.lblDosyaYolu.TabIndex = 12;
            this.lblDosyaYolu.Text = "Dosya Yolu: ";
            // 
            // lblOrtKelimeSayisi
            // 
            this.lblOrtKelimeSayisi.AutoSize = true;
            this.lblOrtKelimeSayisi.Location = new System.Drawing.Point(913, 209);
            this.lblOrtKelimeSayisi.Name = "lblOrtKelimeSayisi";
            this.lblOrtKelimeSayisi.Size = new System.Drawing.Size(169, 20);
            this.lblOrtKelimeSayisi.TabIndex = 6;
            this.lblOrtKelimeSayisi.Text = "Ortalama Kelime Sayısı: ";
            // 
            // lvlCumle
            // 
            this.lvlCumle.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.kelimeSayisi,
            this.cumle});
            this.lvlCumle.HideSelection = false;
            this.lvlCumle.Location = new System.Drawing.Point(169, 21);
            this.lvlCumle.Name = "lvlCumle";
            this.lvlCumle.Size = new System.Drawing.Size(979, 172);
            this.lvlCumle.TabIndex = 4;
            this.lvlCumle.UseCompatibleStateImageBehavior = false;
            this.lvlCumle.View = System.Windows.Forms.View.Details;
            // 
            // kelimeSayisi
            // 
            this.kelimeSayisi.Text = "Kelime Sayısı";
            this.kelimeSayisi.Width = 100;
            // 
            // cumle
            // 
            this.cumle.Text = "Cümle";
            this.cumle.Width = 875;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lvlCumle);
            this.panel1.Controls.Add(this.MetinYukleBtn);
            this.panel1.Controls.Add(this.lblOrtKelimeSayisi);
            this.panel1.Controls.Add(this.stackeOkuBtn);
            this.panel1.Controls.Add(this.lblDosyaYolu);
            this.panel1.Controls.Add(this.lblCumleSayisi);
            this.panel1.Location = new System.Drawing.Point(15, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1168, 257);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lvlKelimeler);
            this.panel2.Controls.Add(this.agacaAktarBtn);
            this.panel2.Controls.Add(this.kelimeleriGetirBtn);
            this.panel2.Location = new System.Drawing.Point(15, 290);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(575, 188);
            this.panel2.TabIndex = 14;
            // 
            // kullanimSayisiLbl
            // 
            this.kullanimSayisiLbl.AutoSize = true;
            this.kullanimSayisiLbl.Location = new System.Drawing.Point(191, 93);
            this.kullanimSayisiLbl.Name = "kullanimSayisiLbl";
            this.kullanimSayisiLbl.Size = new System.Drawing.Size(115, 20);
            this.kullanimSayisiLbl.TabIndex = 15;
            this.kullanimSayisiLbl.Text = "Kullanım Sayısı: ";
            // 
            // kelimeLbl
            // 
            this.kelimeLbl.AutoSize = true;
            this.kelimeLbl.Location = new System.Drawing.Point(191, 59);
            this.kelimeLbl.Name = "kelimeLbl";
            this.kelimeLbl.Size = new System.Drawing.Size(62, 20);
            this.kelimeLbl.TabIndex = 14;
            this.kelimeLbl.Text = "Kelime: ";
            // 
            // kelimeAraBtn
            // 
            this.kelimeAraBtn.Location = new System.Drawing.Point(15, 72);
            this.kelimeAraBtn.Name = "kelimeAraBtn";
            this.kelimeAraBtn.Size = new System.Drawing.Size(150, 50);
            this.kelimeAraBtn.TabIndex = 13;
            this.kelimeAraBtn.Text = "Kelime Ara";
            this.kelimeAraBtn.UseVisualStyleBackColor = true;
            this.kelimeAraBtn.Click += new System.EventHandler(this.kelimeAraBtn_Click);
            // 
            // kelimeAraTxt
            // 
            this.kelimeAraTxt.Location = new System.Drawing.Point(190, 16);
            this.kelimeAraTxt.Name = "kelimeAraTxt";
            this.kelimeAraTxt.Size = new System.Drawing.Size(137, 27);
            this.kelimeAraTxt.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.kelimeAraTxt);
            this.panel3.Controls.Add(this.kullanimSayisiLbl);
            this.panel3.Controls.Add(this.hashOlusturbtn);
            this.panel3.Controls.Add(this.kelimeLbl);
            this.panel3.Controls.Add(this.kelimeAraBtn);
            this.panel3.Location = new System.Drawing.Point(644, 290);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(539, 186);
            this.panel3.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 488);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Metin Yazarı Belirleme";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button agacaAktarBtn;
        private System.Windows.Forms.Button kelimeleriGetirBtn;
        private System.Windows.Forms.ListView lvlKelimeler;
        private System.Windows.Forms.ColumnHeader KullanimSayisi;
        private System.Windows.Forms.ColumnHeader Kelime;
        private System.Windows.Forms.Button hashOlusturbtn;
        private System.Windows.Forms.Button MetinYukleBtn;
        private System.Windows.Forms.Button stackeOkuBtn;
        private System.Windows.Forms.Label lblCumleSayisi;
        private System.Windows.Forms.Label lblDosyaYolu;
        private System.Windows.Forms.Label lblOrtKelimeSayisi;
        private System.Windows.Forms.ListView lvlCumle;
        private System.Windows.Forms.ColumnHeader kelimeSayisi;
        private System.Windows.Forms.ColumnHeader cumle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button kelimeAraBtn;
        private System.Windows.Forms.TextBox kelimeAraTxt;
        private System.Windows.Forms.Label kullanimSayisiLbl;
        private System.Windows.Forms.Label kelimeLbl;
        private System.Windows.Forms.Panel panel3;
    }
}

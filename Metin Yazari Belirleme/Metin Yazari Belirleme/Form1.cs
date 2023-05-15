using Metin_Yazari_Belirleme.Sınıflar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metin_Yazari_Belirleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            stackeOkuBtn.Enabled = false;
            kelimeleriGetirBtn.Enabled = false;
            hashOlusturbtn.Enabled = false;
            hashOlusturbtn.Enabled = false;
            agacaAktarBtn.Enabled = false;
            kelimeAraBtn.Enabled = false;
        }
        Paragraf paragraf;
        private void MetinYukleBtn_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan dosya seçilmesi beklenir. Sadece txt uzantılı dosyalar açılabilir.
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "txt files (*.txt)|*.txt";
            file.ShowDialog();            

            // Seçilen dosya okunur ve sınıfta tutulur.
            StreamReader reader = new StreamReader(file.OpenFile());
            lblDosyaYolu.Text = "Dosya Yolu: " + file.FileName;
            string fileContent = reader.ReadToEnd();            
            paragraf = new Paragraf(fileContent);

            MetinYukleBtn.Enabled = false;
            stackeOkuBtn.Enabled = true;         
        }
        
        private void stackeOkuBtn_Click(object sender, EventArgs e)
        {
            // Bölünen cümleler ListView'de görüntülenir. Paragrafa dair diğer bilgier de diğer form kontrollerinde görüntülenir.
            paragraf.CumlelereBol();
            Cumle[] cumleler =  paragraf.Cumleler.ToArray();
            int toplamKelimeSayisi = 0;
            for (int i = 0; i < cumleler.Length; i++)
            {
                ListViewItem item = new ListViewItem(new string[] { cumleler[i].Kelimeler.Count.ToString(), cumleler[i].Metin });
                lvlCumle.Items.Add(item);
                toplamKelimeSayisi += cumleler[i].Kelimeler.Count;
            }
            lblCumleSayisi.Text = "Cümle Sayısı: " + paragraf.Cumleler.Count;
            lblOrtKelimeSayisi.Text = "Ortalama Kelime Sayısı: " + toplamKelimeSayisi / cumleler.Length;

            stackeOkuBtn.Enabled = false;
            agacaAktarBtn.Enabled = true;
        }

        Heap heapTree;
        private void agacaAktarBtn_Click(object sender, EventArgs e)
        {
            // 'KelimeKullanim' sınıfı kelimeyi ve kelimenin kullanım sayısını tutar. 
            KelimeKullanim[] dizi = paragraf.KelimeKullanimSayisiBul();
            heapTree = new Heap(dizi.Length);
            foreach (var item in dizi)
                heapTree.Insert(item);

            agacaAktarBtn.Enabled = false;
            kelimeleriGetirBtn.Enabled = true;
        }

        KelimeKullanim[] kelimeKullanimlari;
        private void kelimeleriGetirBtn_Click(object sender, EventArgs e)
        {
            // Kelimeler ve kullanım sayıları ListView kontrolünde görüntülenir.
            kelimeKullanimlari = heapTree.Sort();
            int count;
            if (kelimeKullanimlari.Length > 5) count = 5;
            else count = kelimeKullanimlari.Length;

            for (int i = 0; i < count; i++)
            {
               ListViewItem item = new ListViewItem(new string[] { kelimeKullanimlari[i].kullanimSayisi.ToString(), kelimeKullanimlari[i].kelime });
               lvlKelimeler.Items.Add(item);
            }
            kelimeleriGetirBtn.Enabled = false;
            hashOlusturbtn.Enabled = true;         
        }

        HashMap hashMap;
        private void hashOlusturbtn_Click(object sender, EventArgs e)
        {
            // 'KelimeKullanim' sınıfının nesneleri Hash Map'e eklenir. Buradaki anahtar kelimedir.
            hashMap = new HashMap(kelimeKullanimlari.Length);
            for (int i = 0; i < kelimeKullanimlari.Length; i++)
            {
                hashMap.Add(kelimeKullanimlari[i].kelime, kelimeKullanimlari[i]);
            }
            hashOlusturbtn.Enabled = false;
            kelimeAraBtn.Enabled = true;
        }

        private void kelimeAraBtn_Click(object sender, EventArgs e)
        {
            // Kullanıcan alınan kelime ön işlenir ve bu kelime anahtar olarak Hash Map üzerinde aranır.
            string kelime = Regex.Replace(kelimeAraTxt.Text, @"\W(?=\s)|(?<=[ ])\W+|'\w+", "").ToLower();
            KelimeKullanim search = hashMap.Search(kelime);
            if (search == null) MessageBox.Show("Aradığınız kelime bulunamadı");
            else
            {
                kelimeLbl.Text = "Kelime: " + search.kelime;
                kullanimSayisiLbl.Text = "Kullanım Sayısı: " + search.kullanimSayisi.ToString();
            }
        }
    }
}

using Metin_Yazari_Belirleme.Sınıflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Metin_Yazari_Belirleme
{
    public class Paragraf
    {
        public string Metin { get; set; }
        public Stack<Cumle> Cumleler { get; set; }     
        
        public Paragraf(string metin)
        {
            Metin = metin;
            Cumleler = new Stack<Cumle>();
        }

        // Regex kütüphanesi yardımıyla paragrafı cümlelere ayırırır ve 'Cumleler' değişkenine atar.
        public void CumlelereBol()
        {
            string[] CumlelerArray = Regex.Split(Metin, @"(?<=[\.!\?])\s+");
            for (int i = 0; i < CumlelerArray.Length; i++)
            {
                Cumle cumle = new Cumle(CumlelerArray[i], i+1);
                Cumleler.Push(cumle);
            }
        }

        // Regex kütüphanesi yardımıyla paragrafı kelimelere ayırırır ve kelimeleri ön işler.
        // Linq kütüphanesi yardımıyla kelimeler ve kelimelerin kullanım sayısı 'KelimeKullanim' sınıfına atanır.
        public KelimeKullanim[] KelimeKullanimSayisiBul()
        {
            string pattern = @"\W(?=\s)(?= )|(?<=[ ])\W+|'\w+(?= )";
            string onIslenmisMetin = Regex.Replace(Metin, @"[\.!\?]", " ");
            onIslenmisMetin = Regex.Replace(onIslenmisMetin, pattern, "").ToLower();
            KelimeKullanim[] siralanmisKelimeler = onIslenmisMetin
              .Split(' ')
              .GroupBy(x => x)
              .Select(x => new KelimeKullanim(x.Key,x.Count()))                  
              .ToArray();
            return siralanmisKelimeler;
        }
    }
}

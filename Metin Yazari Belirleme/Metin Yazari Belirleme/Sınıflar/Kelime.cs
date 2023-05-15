using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Metin_Yazari_Belirleme.Sınıflar
{
    public class Kelime
    {
        public string OrijinalKelime { get; set; }
        public string OnIslenmisKelime { get; set; }
        public int KelimeSirasi { get; set; }

        public Kelime(string orijinalKelime, int kelimeSirasi)
        {
            OrijinalKelime = orijinalKelime;
            KelimeSirasi = kelimeSirasi;
            KelimeOnIsle();
        }

        // Kelimeyi ön işler ve 'OnIslenmisKelime' değişkenine atar.
        public void KelimeOnIsle()
        {
            string pattern = @"\W(?=\s)|(?<=[ ])\W+|'.(?:\w)";
            OnIslenmisKelime = Regex.Replace(OrijinalKelime, pattern, "").ToLower();
        }
    }
}

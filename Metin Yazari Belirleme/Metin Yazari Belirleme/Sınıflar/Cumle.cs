using Metin_Yazari_Belirleme.Sınıflar;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Metin_Yazari_Belirleme
{
    public class Cumle 
    {
        public string Metin { get; set; }
        public int CumleSirasi { get; set; }
        public Stack<Kelime> Kelimeler { get; set; }

        public Cumle(string metin, int cumleSirasi)
        {
            Metin = metin;
            CumleSirasi = cumleSirasi; 
            Kelimeler = new Stack<Kelime>();
            KelimelereBol();
        }

        // Cümleyi kelimelere Ayırır ve 'Kelimeler' değişkenine atar.
        public void KelimelereBol()
        {
            string[] KelimelerArray = Regex.Split(Metin, " ");
            for (int i = 0; i < KelimelerArray.Length; i++)
            {
                Kelime kelime = new Kelime(KelimelerArray[i], i+1);
                Kelimeler.Push(kelime);
            }
        }
    }
}

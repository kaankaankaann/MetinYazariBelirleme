using System;
using System.Collections.Generic;
using System.Text;

namespace Metin_Yazari_Belirleme.Sınıflar
{
    public class KelimeKullanim
    {
        public string kelime { get; set; }
        public int kullanimSayisi { get; set; }

        public KelimeKullanim(string kelime, int kullanimSayisi)
        {
            this.kelime = kelime;
            this.kullanimSayisi = kullanimSayisi;
        }
    }
}

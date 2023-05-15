using Metin_Yazari_Belirleme.Sınıflar;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metin_Yazari_Belirleme
{
    public class LinkedListHashEntry
    {
        public string key { get; set; }
        public KelimeKullanim value { get; set; }
        public LinkedListHashEntry next { get; set; }
        public LinkedListHashEntry(string key, KelimeKullanim value)
        {
            this.key = key;
            this.value = value;
            this.next = null;
        }
    }
}

using Metin_Yazari_Belirleme.Sınıflar;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metin_Yazari_Belirleme
{
    public class HeapNode
    {
        public KelimeKullanim Value { get; set; }
        public HeapNode(KelimeKullanim value)
        {
            Value = value;
        }
    }
}

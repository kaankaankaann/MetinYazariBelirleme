using Metin_Yazari_Belirleme.Sınıflar;

namespace Metin_Yazari_Belirleme
{
    public interface IHeap
    {
        bool Insert(KelimeKullanim value);
        bool IsEmpty();
        void MoveToDown(int index);
        void MoveToUp(int index);
        HeapNode RemoveMax();
        KelimeKullanim[] Sort();
    }
}
using Metin_Yazari_Belirleme.Sınıflar;

namespace Metin_Yazari_Belirleme
{
    public interface IHashMap
    {
        void Add(string key, KelimeKullanim value);
        int HashValue(string key);
        KelimeKullanim Search(string key);
    }
}
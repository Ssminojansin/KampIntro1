internal class Program
{
    
    private static void Main(string[] args)
    {
        //type safety - tip güvenliği
        //Do not repeat yourself - Kendini tekrarlama 

        string kategoriEtiketi = "Kategori";
        int ogrenciSayisi = 32000;
        double faizOrani = 1.45;
        float krediOrani = 4.50f;
        bool sistemeGirisYapmisMi = false;

        double dolarinDünküDegeri = 7.35;
        double dolarinBugünküDegeri = 7.45;

        if (dolarinDünküDegeri > dolarinBugünküDegeri)
        {
            Console.WriteLine("Azalış Butonu");
        } else if (dolarinDünküDegeri<dolarinBugünküDegeri)
        {
            Console.WriteLine("Artış Butonu");
        }
        else
        {
            Console.WriteLine("Değişmedi Butonu");
        }








        if (sistemeGirisYapmisMi == true)
        {
            Console.WriteLine("Kullanıcı Ayarları Butonu");
        }
        else
        {
            Console.WriteLine("Giriş Yap Butonu");
        }









        


    }
}
using Metotlar;

internal class Program
{
    private static void Main(string[] args)
    {
        //Do not repeat yourself -DRY

        //Encapsulation - Classlara sonradan bir property eklediğimizde sayfa hata vermiyor düzenli oluyor. (Kapsülleme)

        Urun urun1 = new Urun();
        urun1.Adi = "Elma";
        urun1.Aciklama = "Amasya Elması";
        urun1.Fiyati = 15;
        urun1.StockAdedi = 10;

        Urun urun2 = new Urun();
        urun2.Adi = "Karpuz";
        urun2.Aciklama = "Diyarbakır Karpuzu";
        urun2.Fiyati = 80;
        urun2.StockAdedi = 20;


        Urun[] urunler = new Urun[] { urun1, urun2 };

        //type safety - veri güvenliği
        foreach (Urun urun in urunler)
        {
            Console.WriteLine("Ürün Adı : " + urun.Adi + "\nÜrün Açıklaması : " +  urun.Aciklama + "\nÜrün Fiyatı : " +  urun.Fiyati);
            Console.WriteLine("--------------------------------------");
        }


        Console.WriteLine("------------Metotlar----------------");

        //Instance - Clas örneği oluşturmak
        SepetManager sepetManager = new SepetManager();
        sepetManager.Ekle(urun1);
        sepetManager.Sil(urun2);

        Console.WriteLine("-------------------------------");

        sepetManager.Ekle2("Şeftali", "Bursa Şeftalisi", 15); 



    }

    
}
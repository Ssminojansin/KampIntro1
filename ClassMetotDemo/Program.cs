using ClassMetotDemo;

internal class Program
{
    private static void Main(string[] args)
    {
       Musteri musteri1 = new Musteri();
        musteri1.Adi = "Coskun";
        musteri1.Soyadi = "Temenni";
        musteri1.Cinsiyeti = "Erkek";
        musteri1.Yasi = 30;

        Musteri musteri2 = new Musteri();
        musteri2.Adi = "Büsra";
        musteri2.Soyadi = "Temenni";
        musteri2.Cinsiyeti = "Kadın";
        musteri2.Yasi = 26;

        Musteri musteri3 = new Musteri();
        musteri3.Adi = "Barıs";
        musteri3.Soyadi = "Temenni";
        musteri3.Cinsiyeti = "Erkek";
        musteri3.Yasi = 25;

        Musteri musteri4 = new Musteri();
        musteri4.Adi = "Nihal";
        musteri4.Soyadi = "Temenni";
        musteri4.Cinsiyeti = "Kadın";
        musteri4.Yasi = 52;


        MusteriManager musteriManager = new MusteriManager();
        musteriManager.Ekle(musteri1);
        musteriManager.Sil(musteri2);

        Console.WriteLine("----------------------------------------");

        musteriManager.Ekle(musteri3);
        musteriManager.Listele(musteri4);



    }
}

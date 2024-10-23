internal class Program
{
    private static void Main(string[] args)
    {

       /* Bir programda çok sayıda koşul kontrolü ve bunların sonucuna göre gerçekleştirilmesi gereken işlemler varsa,
         if-else yapıları ile akışın izlenmesi zorlaşabilir.Böyle durumlar genellikle switch deyiminin kullanılmasının gerekli olacağı durumlardır. 
         switch deyimi, tek bir ifadenin değerine göre sınırsız sayıda çalıştırma yolu belirlemeyi sağlayan bir komuttur.*/


        // Console.WriteLine("Adınızı girin : ");
        // string ad = Console.ReadLine();
        //  Console.WriteLine(ad);


        Console.WriteLine("Lütfen 1. sayıyı giriniz : ");
       int sayi1 =Convert.ToInt32( Console.ReadLine());
        Console.WriteLine("lütfen 2.sayıyı giriniz : ");
        int sayi2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Lütfen yapmak istediğiniz işlemi seçiniz : ");
        Console.WriteLine("\n1 Toplama \n2 Çıkartma \n3 Çarpma \n4 Bölme");
        int islem = Convert.ToInt32(Console.ReadLine());

        switch (islem)
        {
            case 1: 
                Console.WriteLine("İşlem sonucu :" + (sayi1 + sayi2));
                break;
            case 2:
                Console.WriteLine("işlem sonucu :" + (sayi1 - sayi2));
                break;
            case 3:
                Console.WriteLine("işlem sonucu :"+ (sayi1 * sayi2));
                break;
            case 4:
                Console.WriteLine("işlem sonucu :" + (sayi1/sayi2));
                break;
                default:
                break;
                Console.WriteLine("Hatalı Tuşlama");

        }
        















        /* Console.Write("1. Sayiyi giriniz: ");
         int sayi1 = Convert.ToInt32(Console.ReadLine());
         Console.Write("2.Sayiyi giriniz: ");
         int sayi2 = Convert.ToInt32(Console.ReadLine());

         Console.WriteLine("\n1. Toplama\n2.Çıkarma\n3.Çarpma\n4.Bölme");
         Console.Write("\nİsleminizi seciniz: ");
         int islem = Convert.ToInt32(Console.ReadLine());
         switch (islem)
         {
             case 1:
                 Console.WriteLine("İslemin sonucu = " + (sayi1 + sayi2));
                 break;
             case 2:
                 Console.WriteLine("İslemin sonucu = " + (sayi1 - sayi2));
                 break;
             case 3:
                 Console.WriteLine("İslemin sonucu = " + (sayi1 * sayi2));
                 break;
             case 4:
                 Console.WriteLine("İslemin sonucu = " + (sayi1 / sayi2));
                 break;
             default:
                 Console.WriteLine("Yanlis secim yaptınız !!");
                 break;
         }
         Console.ReadLine();*/

    }
}
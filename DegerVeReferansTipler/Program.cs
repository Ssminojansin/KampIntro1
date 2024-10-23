internal class Program
{
    private static void Main(string[] args)
    {
        int sayi1 = 10;
        int sayi2 = 30;
        sayi1 = sayi2;
        sayi2 = 65;

        //sayi1 kaçtır??

        Console.WriteLine(sayi1);

        int[] sayilar1 = new int[] { 10, 20, 30 };
        int[] sayilar2 = new int[] { 100, 200, 300 };
        sayilar1 = sayilar2;
        sayilar2[0] = 999;
        //sayilar1[0] kaçtır ??

        Console.WriteLine(sayilar1[0]);

        // int , decimal , float , double , bool = Değer Tipleridir.

        //Array , Class , Interface = Referans Tiplerdir.

        // Bellekte Stack ve Heap diye iki bölüm vardır. Değer tipleri Stackte gerçekleşir sadece değeri kopyalar işi biter.
        //Ancak Referans tipler Heapde gerçekleşir. New dediğimiz anda heapte yeni bir alan oluşturur. 




    }
}
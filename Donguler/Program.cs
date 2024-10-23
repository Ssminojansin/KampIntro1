internal class Program
{
    private static void Main(string[] args)
    {
        //blok kavramı mevcuttur. Şart sağlandıkça döner döner yazdırır.
        // i++ i yi birer arttır demektir. 
        // i=i+2 ya da i+=2 yzaarsak i yi ikişer ikişer arttır demektir.

        //Array- Dizilerde tutmamı gerekir
       //string kurs1 = "Yazılım geliştirme Kampı";
       // string kurs2 = "Programlamaya başlangıç için temel kurs";
       //string kurs3 = "Java";


        string[] kurslar = new string[] { "Yazılım geliştirme Kampı" , "Programlamaya başlangıç için temel kurs", "Java","Python"};

       /* foreach (var kurs in kurslar)
        {
            Console.WriteLine(kurs);
        }*/

        //for daha geniş kapsamlı verileri dolaşmak için kullanılır.
        for (int i = 0; i < kurslar.Length; i++ )
        {
            Console.WriteLine(kurslar[i]);
        }


        Console.WriteLine("---------------------------------------");
       
        //foreach dizileri daha kolay dolaşmaya yarar.
        foreach (var kurs in kurslar)
        {
            Console.WriteLine(kurs);
        }


        Console.WriteLine("Footer - Sayfa sonu");



    }
}
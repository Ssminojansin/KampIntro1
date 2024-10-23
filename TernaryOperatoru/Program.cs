using System.Linq.Expressions;

internal class Program
{
    private static void Main(string[] args)
    {
        //Ternary operatörü : 
        //Şarta bağlı değer döndüren bir operatördür. Bir değişkene ,
        //metoda ve ya property'e değer atarken eğer ki bu değer şarta göre fark edecekse
        //tek satırda ya da satır bazlı bu şart kontrolünü yaparak duruma göre değer döndürmemizi sağlayan kalıpsal operatördür.

        // ......şart/durum ....... ? Eğerki şart doğru ise buradaki değer dönecek (true ise) : Yok şart yanlış ise buradaki değer dönecektir (false ise)

        //Kural ise : Dönecek değerler ynı türde olmalıdır.

        bool medeniHal = true;
        string mesaj = medeniHal == true? "Evlilere Kampanya..." : "Bekarlara Kampana...";
        Console.WriteLine(mesaj);


        
      

        

    }
}
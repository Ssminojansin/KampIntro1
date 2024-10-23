using Matematik;

internal class Program
{
    private static void Main(string[] args)
    {
        DortIslem dortIslem = new DortIslem();
        dortIslem.Topla(5,6);

        Console.WriteLine("----------------");

        dortIslem.Çıkart(15,9);

        Console.WriteLine("----------------");

        dortIslem.Çarpma(10,7);

        Console.WriteLine("----------------");

        dortIslem.Bölme(4,2);
    }
}
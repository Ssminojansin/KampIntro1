internal class Program
{
    private static void Main(string[] args)
    {
       Kurs kurs1 = new Kurs();
        kurs1.KursAdi = "C#";
        kurs1.Egitmen = "Coskun Temenni";
        kurs1.IzlenmeOrani = 70;


        Kurs kurs2 = new Kurs();
        kurs2.KursAdi = "C++";
        kurs2.Egitmen = "Barıs Temenni";
        kurs2.IzlenmeOrani = 64;

        Kurs kurs3 = new Kurs();
        kurs3.KursAdi = "Python";
        kurs3.Egitmen = "Busra Temenni";
        kurs3.IzlenmeOrani = 80;

        Kurs kurs4 = new Kurs();
        kurs4.KursAdi = "Java";
        kurs4.Egitmen = "Nihal Temenni";
        kurs4.IzlenmeOrani = 40;

        // Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);


        Kurs[] kurslar = new Kurs[] { kurs1,kurs2, kurs3,kurs4 };

        foreach (var kurs in kurslar)
        {
            Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);

        }

    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen  { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
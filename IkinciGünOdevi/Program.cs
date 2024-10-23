using IkinciGünOdevi;
using System.Net.Http.Headers;

internal class Program
{
    private static void Main(string[] args)
    {
        Products products1 = new Products();
        products1.ProdutcName = "Spor Ayakkabı";
        products1.ProductDescription = "Mavi-Beyaz";
        products1.ProductPrice = 1000;

        Products products2 = new Products();
        products2.ProdutcName = "Mont";
        products2.ProductDescription = "Siyah-Beyaz";
        products2.ProductPrice = 1500;

        Products products3 = new Products();
        products3.ProdutcName = "Pantolon";
        products3.ProductDescription = "Siyah";
        products3.ProductPrice = 800;

        Products products4 = new Products();
        products4.ProdutcName = "T-Shirt";
        products4.ProductDescription = "Beyaz";
        products4.ProductPrice = 600;


        Products[] product = new Products[] {products1,products2,products3,products4 };

        for (int i = 0; i < product.Length; i++)
        {
            Console.WriteLine(product[i].ProdutcName + " - " + product[i].ProductDescription + " - " + product[i].ProductPrice);
        }


        Console.WriteLine("-------------------------------------");


        int urun = 0;
        while (urun<product.Length)
        {
            Console.WriteLine(product[urun].ProdutcName + " - " + product[urun].ProductDescription + " - " + product[urun].ProductPrice);
            urun++;
        }


        Console.WriteLine("----------------------------------------");

        foreach (var uruns in product)
        {
            Console.WriteLine(uruns.ProdutcName + " - " + uruns.ProductDescription + " - " + uruns.ProductPrice);
        }




    }
}
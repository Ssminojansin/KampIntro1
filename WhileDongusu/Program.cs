using WhileDongusu;

internal class Program
{
    private static void Main(string[] args)
    {


        Product product1 = new Product();
        product1.ProductName = "Spor Ayakakkabısı";
        product1.ProductDescription = "Futbol Ayakkabısı";
        product1.ProductPrice = 100;

        Product product2 = new Product();
        product2.ProductName = "Spor Ayakakkabısı";
        product2.ProductDescription = "Basketbol Ayakkabısı";
        product2.ProductPrice = 200;

        Product product3 = new Product();
        product3.ProductName = "Spor Ayakakkabısı";
        product3.ProductDescription = "Tenis Ayakkabısı";
        product3.ProductPrice = 300;

        Product[] products = new Product[] { product1, product2, product3 };




        int i = 0;

        while (i <products.Length)
        {

            Console.WriteLine("Ürün Adı : " + products[i].ProductName + "\nÜrün açıklaması :" + products[i].ProductDescription
                + "\nÜrün Fiyatı :" + products[i].ProductPrice);

            break;

        }


        int sayac = 10;
        while (sayac >=0)
               
        {
            Console.WriteLine(sayac);
            sayac--;
        }

    }
}
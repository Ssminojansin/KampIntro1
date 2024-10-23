using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müsteri Eklendi  :  " + musteri.Adi + "  " +  musteri.Soyadi);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müsteri Silindi  :  " + musteri.Adi + "  " + musteri.Soyadi);
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Müsteri Listelendi  :  " + musteri.Adi + "  " + musteri.Soyadi);
                }
    }
}

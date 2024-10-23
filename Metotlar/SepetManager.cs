using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class SepetManager
    {

        //Naming Convention - İsim kullanımı 
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi  :  " + urun.Adi);
        }

        //Hatalı Kullanım çünkü yeni bir özellik eklendiğinde hata oluşturur.
        public void Ekle2(string Adi, string Aciklama, double Fiyati)
        {
            Console.WriteLine("Sepete Eklendi  :  " + Adi);
                }

        public void Sil(Urun urun)
        {
            Console.WriteLine("Sepetten Kaldırıldı  :  " + urun.Adi);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class SepetManager
    {
        //naming convention
        public void Ekle (Urun urun) //parantez içinde sepete ne ekleyeceğimizi verdik.(Parametre)
        {
            if(urun.StokAdedi == null || urun.StokAdedi <= 0)
            {
                Console.WriteLine("hata");
            }
            else
            {

                Console.WriteLine("Tebrikler. Sepete eklendi : " + urun.Adi);
            }

        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat,int stokadedi) 
            //Bir class içinde birden fazla metot olabilir.
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urunAdi);
        }
    }
}

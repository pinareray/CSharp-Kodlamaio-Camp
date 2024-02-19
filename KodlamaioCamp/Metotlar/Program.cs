using System;

namespace Metotlar //Metotlar tekrar tekrar kullanabilirliği sağlayan kod bloklarıdır.
{
    class Program
    {

        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması"; 

            string[] meyveler = new string[] { };
             
            Urun urun1 = new Urun(); //class oluşturuyor.
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";
            urun2.StokAdedi = 5;

            Urun[] urunler = new Urun[] {urun1, urun2};

            //type-safe
            foreach (Urun urun in urunler) //tüm ürünleri tek tek ekrana basacak.
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.StokAdedi);
                Console.WriteLine("-------------------");
            }
                Console.WriteLine("-------Metotlar-------");
                //instance-örnek
                //encapsulation-kapsülleme
                SepetManager sepetManager = new SepetManager(); //class oluşturduk.
                sepetManager.Ekle(urun1); //Metodu çağırdık. 
                sepetManager.Ekle(urun2);

                sepetManager.Ekle2("Armut", "Yeşil Armut", 12,10);
                sepetManager.Ekle2("Elma", "Yeşil Elma", 12,9);
                sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12,8);

            }

            // diziler çoğul isimlendirilir, içinde birden fazla data,veri içerir. 
            // classlar bize kolaylık sağlar, düzene sokar. 


        }
    }



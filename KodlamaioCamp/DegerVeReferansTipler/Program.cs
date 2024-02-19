using System;

namespace DegerVeReferansTipler
{

    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            // sayi1 ?? 30 yes- sayi2 de artık 65 oldu.

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1?? 999 
           /*int, decimal, float, double, bool = deger tip
           array, class, interface = referans tip
           bellekte stack ve heap diye iki tane alan var ve biz bir değişken tanımladığımızda
           değer tip olanlar stackte gerçekleşir. Yani biz sayi1 diye bir şey tanımlayıp
           ona değer verdiğimizde bu stackte çalışır. Örnek 2 için ise stack de sayilar1 diye bir 
           değer oluşur heap de ise bir array [10,20,30] açılır. İki değer aynı adres adını alır
           bu adresi new oluşturur ve stack'i heap'e bağlar.*/



        }
    }
}
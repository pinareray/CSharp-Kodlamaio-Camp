using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(string Musteriadi, string Soyadi, int Hesapno)
        {
            Console.WriteLine("Musteri Eklendi :" + Musteriadi);
        }

        public void Listele(string Musteriadi, string Soyadi, int Hesapno)

        {
            Console.WriteLine("------Müşteri Bilgileri-----");
            Console.WriteLine(Musteriadi);
            Console.WriteLine(Soyadi);
            Console.WriteLine(Hesapno);


        }

        public void Sil(string Musteriadi)
        {
            Console.WriteLine("Müşteri Silindi : " + Musteriadi);
        }

    }
}

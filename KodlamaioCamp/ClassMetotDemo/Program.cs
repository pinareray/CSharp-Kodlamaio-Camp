using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo;

class Musteri
{
    public string MusteriAdi { get; set; }
    public string Soyadi { get; set; }
    public int HesapNo { get; set; }


}
public class Program
{
    static void Main(string[] args)
    {
        Musteri musteri1 = new Musteri();
        musteri1.MusteriAdi = "Mustafa";
        musteri1.Soyadi = "Yılmaz";
        musteri1.HesapNo = 10;

        Musteri musteri2 = new Musteri();
        musteri2.MusteriAdi = "Pelin";
        musteri2.Soyadi = "Keskin";
        musteri2.HesapNo = 13;

        Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

        foreach (var Musteri in musteriler)
        {
            Console.WriteLine(Musteri.MusteriAdi);
            Console.WriteLine(Musteri.Soyadi);
            Console.WriteLine(Musteri.HesapNo);
        }

        MusteriManager musterimanager = new MusteriManager();
        musterimanager.Listele("Mustafa", "Yılmaz", 10);
        musterimanager.Listele("Pelin", "Keskin", 13);

        musterimanager.Ekle("Ceyda", "Deve", 17);
        musterimanager.Sil("Mustafa");

    }

}





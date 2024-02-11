using System;
using System.Diagnostics.Tracing;

namespace Donguler;

class Program
{
    static void Main(string[] args)
    {
        string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
        string kurs2 = "Programlamaya başlangıç için temel kurs";
        string kurs3 = "Java";

        //array - dizi 

        string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı",
            "Programlamaya başlangıç için temel kurs",
            "Java","Python" };
        for (int i = 0; i<kurslar.Length; i++)
        {
            Console.WriteLine(kurslar[i]);
        }
        Console.WriteLine("For bitti");

        //foreach dizi temelli yapıları tek tek dönmeye yarıyor.
        //foreach dizilere uygulanır.Kurs yazan kısım alias'dır. abc,xyz de desek çalışırdı.
         
        foreach (string kurs in kurslar)
        {
            Console.WriteLine(kurs);
        }

        Console.WriteLine("sayfa sonu-footer");
    }

}


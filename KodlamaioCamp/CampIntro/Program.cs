﻿using System;

namespace CampIntro;

class Program
{
    static void Main(string[] args)
    {
        //type safety- tip güvenliği
        // do not your repeat self
        // değet tutucu,alias - kategoriEtiketi
        string kategoriEtiketi = "Kategoriler";
        int ogrenciSayisi = 32000;
        double faizOrani = 1.45;
        bool sistemeGirisYapmisMi = true;
        double dolarDun = 7.35;
        double dolarBugun = 7.45;

        if (dolarDun>dolarBugun)
        {
            Console.WriteLine("Azalış Butonu");
        }
        else if(dolarBugun>dolarDun)
        {
            Console.WriteLine("Artış Butonu");
        }
        else 
        {
            Console.WriteLine("Değişmedi Butonu");
        }

        if(sistemeGirisYapmisMi == true)
        {
            Console.WriteLine("Kullanıcı Ayarları Butonu");
        }
        else
        {
            Console.WriteLine("Giris Yap Butonu");
        }

        Console.WriteLine(kategoriEtiketi);
     
    }
}
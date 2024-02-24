using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
     class Product
    {
        public int Id { get; set; } 
        public int CategoryId { get; set; }//referans anahtarları 2. sıraya yazılsa daha iyi.
        public string ProductName { get; set; } //ürünismi
        public double UnitPrice { get; set; } //fiyatı
        public int UnitsInStock  { get; set; } //stokadedi

    }
}

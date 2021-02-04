using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class sepetManager
    {
        public void Ekle(product product1)
        {
            Console.WriteLine("sepete eklendi : "  +product1.Adi);
        }

        public void Ekle2(string productName, string productExplain, double productFiyat,int stok)
        {
            Console.WriteLine("ürün eklendi : " + productName);
        }
    }
}

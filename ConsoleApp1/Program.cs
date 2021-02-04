using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            product product = new product();
            product.Adi = "elma";
            product.Fiyati = 15;
            product.Aciklama = "amasya elması";
            product.stokadedi = 7;


            product product1 = new product();
            product1.Adi = "kivi";


            product[] products = new product[] {product,product1 };
            foreach (var productt  in products)
            {
                Console.WriteLine(productt.Adi)  ;
                Console.WriteLine(productt.Fiyati);
            }



            Console.WriteLine("---------metotlar---------");
            sepetManager Sepetmanager = new sepetManager();
            Sepetmanager.Ekle(product);
            Sepetmanager.Ekle(product1);
            Sepetmanager.Ekle2("karpuz","diyarbakır",12,8);
        }
    }
}

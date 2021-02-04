using System;

namespace degervereferanstip
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int s1 = 10;
            int s2 = 30;
            s1 = s2;
            s2 = 65;
            Console.WriteLine("s1:"+s1, "s2);
        }
    }
}

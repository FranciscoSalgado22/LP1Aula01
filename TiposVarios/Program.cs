using System;

namespace TiposVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            int var = -10;
            long varl = 20L;
            uint varu = 10U;
            Console.WriteLine(var);
            Console.WriteLine(varl);
            Console.WriteLine(varu);
            char a = '\u0071';
            char b = '\u003E';
            char c = '\u0031';
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c); 
            double d = 5.10;
            float f = 64.39f;
            decimal m = 3.1415m;
            Console.WriteLine(d);
            Console.WriteLine(f);
            Console.WriteLine(m); 
            bool t = true;
            bool fl = 3 > 9;
            Console.WriteLine(t);
            Console.WriteLine(fl); 
        }
    }
}

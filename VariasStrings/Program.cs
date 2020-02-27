using System;
using System.Text;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string sn = "Normal String";
            string sd = "Esta string\n recebe um enter e\t executa um tab";
            string slink = @"C:\Users\a21902823\Desktop\LP1\LP1Aula1";
            string suni = "Esta string tem um unicode - \u00A3";
            Console.WriteLine(sn);
            Console.WriteLine(sd);
            Console.WriteLine(slink);
            Console.WriteLine(suni);
            int x = 50;
            int y = 64;
            string sc = "Ola " + 2 + " como é";
            string scx = "Numero " + x;
            Console.WriteLine(sc);
            Console.WriteLine(scx);
            sc += scx;
            Console.WriteLine(sc);
            string sci = $"O valor de y é {y}";
            string scim = $"{x} vezes {y} é igual a {x*y}";
            Console.WriteLine(sci);
            Console.WriteLine(scim);
            string sf = String.Format("Gosto de {0} e do nº {1}", "batata", 12);
            Console.WriteLine(sf);
            Console.WriteLine("Vou a {0} e o numero de y é {1}", "praia", y);
        }
    }
}

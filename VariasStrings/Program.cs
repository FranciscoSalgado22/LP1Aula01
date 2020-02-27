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
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;

            Console.WriteLine("Comparação de dois números distintos:");
            Console.Write("Digite o valor do primeiro N°:");
            a = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor do segundo N°:");
            b = double.Parse(Console.ReadLine());

            if (a > b) { Console.WriteLine($"O número {a} é maior."); }
            if (a < b) { Console.WriteLine($"O número {b} é maior."); }
            else { Console.WriteLine($"Ambos os números são iguais."); }

        }
    }
}

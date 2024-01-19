using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            long prod = 1;
            for (int i = 1; i <= n; i++) { 
                sum += i;
                prod *= i;
            }
            Console.WriteLine("Suma: " + sum + "\n" + "Produsul: " + prod);
        }
    }
}

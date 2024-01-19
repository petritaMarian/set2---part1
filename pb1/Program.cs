using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, x, evenNum = 0;
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                x  = int.Parse(Console.ReadLine());
                if (x % 2 == 0)  evenNum += 1; 
            }
            Console.WriteLine("Sunt " + evenNum + " numere pare");
        }
    }
}

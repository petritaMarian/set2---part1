using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace pb4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            int x, poz = -1;
            
            for (int i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x == a) poz = i;
            }
            Console.WriteLine(poz);
        }
    }
}

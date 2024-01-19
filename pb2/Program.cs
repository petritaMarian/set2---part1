using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, posNum = 0, negNum = 0, zeroNum = 0;
            float x;
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                x = float.Parse(Console.ReadLine());
                if (x > 0) posNum += 1;
                else if (x < 0) negNum += 1;
                else zeroNum += 1;
            }
            Console.WriteLine("Sunt " + posNum + " numere pozitive, " + negNum + " negative si " + zeroNum + " zerouri");
        }
    }
}

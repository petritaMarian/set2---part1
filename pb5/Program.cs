using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x, pozNum = 0;

            for (int i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x == i) pozNum += 1;
            }
            Console.WriteLine(pozNum);
        }
    }
}

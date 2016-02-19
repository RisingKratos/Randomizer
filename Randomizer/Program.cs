using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomizer
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[7, 7];

            Random rand = new Random();

            for (int i = 0; i < 10; ++i)
            {
                a[rand.Next(0, 7), rand.Next(0, 7)] = rand.Next(0,10);
            }
        }
    }
}

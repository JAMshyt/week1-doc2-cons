using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            for(int i = 0; i < 5; i++)
            {
                int j = 1;
                for (; j < x; )
                {
                    Console.Write(j);
                    j++;
                }
                Console.WriteLine();
                x++;
            }
        }
    }
}

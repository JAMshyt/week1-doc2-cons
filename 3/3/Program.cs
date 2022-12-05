using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A=0, B, X = 0, Y = 0, count=0;
            do
            {
                do
                {
                    try
                    {
                        Console.Write("Введите диапазон А: ");
                        A = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Error");
                    }
                } while (true);

                do
                {
                    try
                    {
                        Console.Write("Введите диапазон B: ");
                        B = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.Write("Error");

                    }
                } while (true);

                if (A <= B)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("А должно быть >= B");
                }
            }while(true);

            do
            {
                try
                {
                    Console.Write("Введите X и Y: ");
                    X = Convert.ToInt32(Console.ReadLine());
                    Y = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.Write("(только цифры)");
                }
            } while (true);
            Console.WriteLine("Do while");
            int i = A;
            do
            {
                if (i % 10 == X || i % 10 == -X || i % 10 == Y || i % 10 == -Y)
                {
                    Console.WriteLine(i);
                    count++;
                }
                i++;
            } while (i <= B & count<5);
            Console.WriteLine("While");
            i = A;
            count = 0;
            while (i <= B & count < 5)
            {
                if (i % 10 == X || i % 10 == -X || i % 10 == Y || i % 10 == -Y)
                {
                    Console.WriteLine(i);
                    count++;
                }
                i++;
            }
            count = 0;
            Console.WriteLine("For");
            for (int j = A; j <= B & count < 5; j++)
            {
                if (j % 10 == X || j % 10 == -X || j % 10 == Y || j % 10 == -Y)
                {
                    Console.WriteLine(j);
                    count++;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Разв.и_цикл._1_К
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                float x, y;
                do
                {
                    try
                    {
                        Console.Write("x=");
                        x = float.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Ошибка");
                    }
                } while (true);
                do
                {
                    try
                    {
                        Console.Write("y=");
                        y = float.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Ошибка");
                    }
                } while (true);
                if (x < 50 && y < 25)
                {
                    Console.WriteLine("Внутри");
                }
                else if ((x == 50 & y <= 25) || (x <= 50 & y == 25))
                {
                    Console.WriteLine("На границе");
                }
                else Console.WriteLine("Вне");
            }
        }
    }
}

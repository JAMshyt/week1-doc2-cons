using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Разв.и_цикл._2_К
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                DateTime today = DateTime.Now;
                int days;
                do
                {
                    try
                    {
                        Console.Write("Кол-во дней: ");
                        days = Convert.ToInt32(Console.ReadLine());
                        if (days < 0) Console.WriteLine("Выв ввели отрицательное кол-во");
                        else break;
                    }
                    catch
                    {
                        Console.WriteLine("Ошибка");
                    }
                } while (true);
                var d = today.AddDays(-days).ToString("dd.MM.yyyy");
                Console.WriteLine("Дата: "+d);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW23
{
    class Program
    {
        public static ulong Fac()
        {
            ulong a;
            Console.WriteLine("Введите факториал (число больше 0):");
            bool result = ulong.TryParse(Console.ReadLine(), out a);
            if (result && a > 0)
            {
                Console.WriteLine($"Вы ввели значение {a}");
            }
            else
            {
                Console.WriteLine("Введите корректные данные");
            }
            ulong factotial = 1;
            for (ulong i = 2; i <= a; i++)
            {
                factotial *= i;
            }
            return factotial;
        }
        static void Main(string[] args)
        {
            ulong p=FacAsync().Result;
            Console.WriteLine($"Значение факториала равно {p}");
            Console.ReadKey();
        }
        static async Task<ulong> FacAsync()
        {
            ulong result=await Task.Run(() => Fac());
            return result;
        }
    }
}

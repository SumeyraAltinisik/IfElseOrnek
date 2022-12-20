using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vize notunu giriniz:");
            int vize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Final notunu giriniz:");
            int final = Convert.ToInt32(Console.ReadLine());

            double basariNotu = vize * 0.4 + final * 0.6;

            if (basariNotu>=60)
            {
                Console.WriteLine("Geçtiniz.");
            }
            else if (basariNotu >= 50)
            {
                Console.WriteLine("Şartlı geçtiniz.");
            }
            else
            {
                Console.WriteLine("Kaldınız.");
            }

            int i = 63;

            switch (i)
            {
                case int n when (n >= 100):
                    Console.WriteLine($"I am 100 or above: {n}");
                    break;

                case int n when (n < 100 && n >= 50):
                    Console.WriteLine($"I am between 99 and 50: {n}");
                    break;

                case int n when (n < 50):
                    Console.WriteLine($"I am less than 50: {n}");
                    break;
            }
            Console.ReadKey();
        }
    }
}

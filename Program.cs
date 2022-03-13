using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_HW_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Money a = new Money(20, 10);
            Money b = new Money(10, 20);
            int c = 3;
            Console.Write("Сложение: ");
            Console.WriteLine($"{a} + {b} = {a+b}");
            Console.WriteLine();
            Console.Write("Вычитание: ");
            Console.WriteLine($"{a} - {b} = {a-b}");
            Console.WriteLine();
            Console.Write("Умножение на целое: ");
            Console.WriteLine($"{a} * {c} = {a*c}");
            Console.WriteLine();
            Console.Write("Деление на целое: ");
            Console.WriteLine($"{a} / {c} = {a/c}");
            Console.WriteLine();
            a++;
            Console.WriteLine($"Увеличенное на 1: {a} ") ;
            a--;
            Console.WriteLine($"Уменьшенное на 1: {a} ");




        }
    }
}

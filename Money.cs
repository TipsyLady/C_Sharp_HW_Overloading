using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_HW_Overloading
{
    class Money
    {
        private int grivna { get; set; }
        private int kopeyka { get; set; }

        //Конструктор
        public Money (int gri, int kop)
        {
            grivna = gri;
            kopeyka = kop;
        }

        //Перегрузки операторов
        //Сложение

        public static Money operator+(Money a, Money b)
        {
            int Res = ((a.grivna + b.grivna) * 100) + a.kopeyka + b.kopeyka;
            return new Money(Res / 100, Res % 100);
        }

        //Сравнение
        public static bool operator<(Money a, Money b)
        {
            if (a.grivna < b.grivna)
                return true;
            else if (a.grivna > b.grivna)
                return false;
            else if (a.kopeyka < b.kopeyka)
                return true;
            else return false;
            
        }
        public static bool operator>(Money a, Money b)
        {
            if (a.grivna < b.grivna)
                return false;
            else if (a.grivna > b.grivna)
                return true;
            else if (a.kopeyka < b.kopeyka)
                return false;
            else return true;

        }

        public static bool operator==(Money a, Money b)
        {
            if (a.grivna == b.grivna && a.kopeyka == b.kopeyka)
                return true;
            else return false;
        }
        public static bool operator !=(Money a, Money b)
        {
            if (a.grivna != b.grivna && a.kopeyka != b.kopeyka)
                return true;
            else return false;
        }
        //Вычитание
        public static Money operator-(Money a, Money b)
        {
            if (a < b)
            {
                Console.WriteLine("Operation can not be executed");
                return null;
            }
            else
            {
                int Res = ((a.grivna - b.grivna) * 100) + (a.kopeyka - b.kopeyka);
                return new Money(Res / 100, Res % 100);
            }
        }
        // Умножение
        public static Money operator *(Money a, int b)
        {
            int Res = (a.grivna * 100 + a.kopeyka) * b;
            return new Money(Res / 100, Res % 100);
        }
        // Деление
        public static Money operator /(Money a, int b)
        {
            try
            {
                int Res = (a.grivna * 100 + a.kopeyka) / b;
                return new Money(Res / 100, Res % 100);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Divide by zero is restricted");
                return new Money(a.grivna, a.kopeyka);
            }
            
        }
            //Увеличение на 1 копейку
            public static Money operator++(Money a)
        {
            a.kopeyka += 1;
            if (a.kopeyka>=100)
            {
                a.grivna += 1;
                a.kopeyka = 0;
            }
            return new Money(a.grivna, a.kopeyka);
        }

        //Уменьшение на 1 копейку
        public static Money operator --(Money a)
        {
            a.kopeyka -= 1;
            if (a.kopeyka == 0)
            {
                a.grivna -= 1;
                a.kopeyka = 99;
            }
            return new Money(a.grivna, a.kopeyka);
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
        public bool Equals(Money obj)
        {
            if (obj is Money)
            {
                Money a = (Money)obj;
                return a.grivna == this.grivna && a.kopeyka == this.kopeyka;
            }
                return false;
        }

        //ToString метод
        public override string ToString()
        {
            return $"{grivna}g. {kopeyka}k.";
        }
    }
}

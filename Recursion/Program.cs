using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    /* Коньков
     * a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
       б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
     */
    class Program
    {

        private static void Print(int a, int b)
        {
            if (a <= b)
            {
                Console.Write(a);
                Print(++a, b);
            }
        }

        private static int Sum(int a, int b)
        {
            
            if (a <= b)
            {                
               return  a+Sum(++a, b);
            }
            return 0;
        }


        static void Main(string[] args)
        {
            Console.Write("Укажите первое число:");
            int begin = Convert.ToInt32(Console.ReadLine());
            Console.Write("Укажите второе число, больше первого:");
            int end = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Последовательность чисел от {0} до {1}",begin,end);
            Print(begin, end);
            Console.WriteLine("");
            Console.WriteLine("Сумма чисел от {0} до {1} равна {2}",begin,end,Sum(begin, end));
            Console.ReadLine();

        }
    }
}

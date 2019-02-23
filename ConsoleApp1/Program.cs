using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /* Коньков
     * Написать метод, возвращающий минимальное из трёх чисел.
     * 
     */
    class Program
    {
        static private int min(int one, int two, int three)
        {
            int a = (one > two) ? two : one;
            return a>three?three: a;
        }

        static private int min(String one, String two, String three)
        {
            return min(Convert.ToInt32(one), Convert.ToInt32(two), Convert.ToInt32(three));
        }


        static void Main(string[] args)
        {
            do {
                Console.WriteLine("");
                Console.Write("Введите 3 числа через запятую: ");
                String[] s = Console.ReadLine().Split(',');
                if (s.Length > 2)
                    Console.WriteLine($"Минимальное число из введённых - {min(s[0], s[1], s[2])}");
                else Console.WriteLine("Нужно указать не неменее 3х чисел...");
                Console.WriteLine("Продолжить (y - да) ?");
            }
            while (Console.ReadKey(true).KeyChar =='y');
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumNumber
{
    /* Коньков
     * С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечётных положительных чисел.
     */
    class Program
    {

        static private int summ;

        static private void sumIf(int num)
        {
            if ((num % 2 != 0 ) && (num > 0))
            {
                summ += num;
            }
        }

        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Вводите по одному числа, когда закончите - введите 0 :");
            do
            {
                 num = Convert.ToInt32(Console.ReadLine());
                sumIf(num);
            } while (num != 0);

            Console.WriteLine($"Сумма нечётных положительных чисел = {summ}");
            Console.ReadLine();
        }

        

    }
}

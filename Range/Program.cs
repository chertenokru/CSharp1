using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Range
{
    /* 
     * 3.
     а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
     б) *Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;
*/
    class Program
    {
        public static Double range(int x1, int y1,int  x2,int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Точка 1");
            Console.Write("x = ");
            Int32 x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y = ");
            Int32 y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Точка 2");
            Console.Write("x = ");
            Int32 x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y = ");
            Int32 y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(range(x1,y1,x2,y2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMT
{
    /*
     * 2. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах
     */ 
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Укажите Ваш вес (кг): ");
            Decimal weight = Convert.ToDecimal(Console.ReadLine().Replace('.', ','));
            Console.Write("Укажите Ваш рост (м): ");
            Decimal height = Convert.ToDecimal(Console.ReadLine().Replace('.',','));

            Console.WriteLine($"Ваш индекс массы тела (ИМТ) ={weight/(height*height)}");
            Console.ReadKey();

        }
    }
}

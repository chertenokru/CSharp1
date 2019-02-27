using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
 

    class Program
    {
        /// <summary>
        /// Осуществляет ввод комплексного числа с проверкой корректности
        /// </summary>
        /// <returns>Введенное комплексное число</returns>
        private static Complex InputComplex()
        {
            bool res = false;
            double a = 0;
            double b = 0;
            do
            {
                Console.Write("Введите комплексное число через ; - вещественная_часть;мнимая_часть :");
                string[] str = Console.ReadLine().Split(';');
                if (str.Length==2)
                {
                    res = Double.TryParse(str[0].Replace('.',','), out a);
                    if (res)
                    {
                        res = Double.TryParse(str[1].Replace('.', ','), out b);
                    }

                }
                Console.WriteLine((res) ? "ok" : "ошибка, повторите ввод");
            } while (!res);
            return new Complex(a,b);
        }

        /// <summary>
        /// Калькулятор комплексных чисел, выполняет 3 операции *,-,+
        /// </summary>
        /// <param name="args">не используется</param>
        static void Main(string[] args)
        {
            bool repeat = false;
            Complex a1, a2, a3 = null;
            do {
                
                    Console.WriteLine("Выберите операцию -,+,*");
                    string op = Console.ReadLine();

                repeat = !(op == "-" || op == "+" || op == "*");

                if (!repeat)
                {
                    a1 = InputComplex();
                    a2 = InputComplex();
                    Console.Write($"{a1} {op} {a2} = ");
                    switch (op)
                    {
                        case "-":
                            {
                                a3 = Complex.Minus(a1, a2);
                                break;
                            }
                        case "+":
                            {
                                a3 = Complex.Plus(a1, a2);
                                break;
                            }
                        case "*":
                            {
                                a3 = Complex.Multi(a1, a2);
                                break;
                            }

                    }
                    Console.WriteLine(a3);
                    Console.WriteLine("Для продолжения напечатайте y");
                }
                else
                {
                    Console.WriteLine("Неверно введена операция !");
                }               

            } while (repeat || Console.ReadLine() == "y");



        }
    }
}

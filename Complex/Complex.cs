using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
    /// <summary>
    /// Класс реализующий работу с комплексными числами
    /// </summary>
        class Complex
        {
        /// <summary>
        /// Мнимая часть
        /// </summary>
        private double b;
        /// <summary>
        /// вещественная часть
        /// </summary>
        private double a;

        public double A { get => a; set => a = value; }
        public double B { get => b; set => b = value; }

        /// <summary>
        /// Сложение комплексных чисел
        /// </summary>
        /// <param name="a1">Число 1</param>
        /// <param name="a2">Число 2</param>
        /// <returns>Результат</returns>
        public static Complex Plus(Complex a1, Complex a2)
        {
            return new Complex(a1.a + a2.a, a1.b + a2.b);
        }
        /// <summary>
        /// Вычитание комплексных числе
        /// </summary>
        /// <param name="a1">Число 1</param>
        /// <param name="a2">Число 2</param>
        /// <returns>Результат</returns>
        public static Complex Minus(Complex a1, Complex a2)
        {
            return new Complex(a1.a - a2.a, a1.b - a2.b);
        }

        /// <summary>
        /// Умножение комплексных чисел
        /// </summary>
        /// <param name="a1">Число 1</param>
        /// <param name="a2">Число 2</param>
        /// <returns>Результат</returns>
        public static Complex Multi(Complex a1, Complex a2)
        {
            return new Complex(a1.a * a2.a - a1.b *a2.b, a1.b * a2.a + a1.a * a2.b);
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="a">вещественная часть</param>
        /// <param name="b">мнимая часть</param>
        public Complex(double a, double b)
            {
                this.a = a;
                this.b = b;
            }

        /// <summary>
        /// Визуализация
        /// </summary>
        /// <returns></returns>
            public override string ToString()
            {
                return $" ({a} + {b}i)";
            }
        }
    
}

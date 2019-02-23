using System;

namespace Lesson1
{
    /*
      1. Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку.
        а) используя склеивание;
        б) используя форматированный вывод;
        в) *используя вывод со знаком $.
     */

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Укажите имя:");
            String firstName = Console.ReadLine();
            Console.Write("Укажите фамилию:");
            String lastName = Console.ReadLine();
            Console.Write("Укажите возраст:");
            String age = Console.ReadLine();
            Console.Write("Укажите рост:");
            String height = Console.ReadLine();
            Console.Write("Укажите вес:");
            String weight = Console.ReadLine();

            Console.WriteLine("Имя: "+firstName+" Фамилия: "+lastName+" Возраст: "+age+" Рост: "+height+" Вес: "+weight);
            Console.WriteLine("Имя: {0} Фамилия: {1} Возраст: {2} Рост: {3} Вес: {4}", firstName, lastName, age, height, weight);
            Console.WriteLine($"Имя: {firstName} Фамилия: {lastName} Возраст: {age} Рост: {height} Вес: {weight}");
            Console.ReadKey();

        }
    }
}





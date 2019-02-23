using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckLogin
{
    /* Коньков
     * Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.
     * На выходе истина, если прошел авторизацию, и ложь, если не прошел 
     * (Логин: root, Password: GeekBrains). 
     * Используя метод проверки логина и пароля, написать программу: 
     * пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
     * С помощью цикла do while ограничить ввод пароля тремя попытками.
     */

    class Program
    {
        private static readonly String PASSWORD = "GeekBrains";
        private static readonly String LOGIN = "root";

        private static bool checkLoginPassword(String login, String password)
        {
            return (login == LOGIN && password == PASSWORD);
        }

        static void Main(string[] args)
        {
            int count = 0;
            bool result = false;
            String login;
            String password;
            do
            {
                count++;
                Console.Write("Попытка № {0} Введите логин: ",count);
                login = Console.ReadLine();
                Console.Write("Введите пароль: ");
                password = Console.ReadLine();
                result = checkLoginPassword(login, password);                

            } while (count<3 & !result);

            if (!result)
            {
                Console.WriteLine("Ваши попытки закончились!");
                Console.ReadLine();
                return;
            }
            else Console.WriteLine("Вы успешно авторизировались !");

            Console.WriteLine("Теперь мы знаем, что вы знаете пароль!");
            Console.ReadLine();

        }
    }
}

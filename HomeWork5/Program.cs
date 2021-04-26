using System;
using System.Text.RegularExpressions;

namespace HomeWork5
{
    // Суханов 
    class Program
    {
        // Создать программу, которая будет проверять корректность ввода логина.
        // Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры,
        // при этом цифра не может быть первой
        static void Login()          // а) без использования регулярных выражений;
        {
            Console.Write("Введите логин: ");
            string log = Console.ReadLine();
            char[] x = log.ToCharArray();
            if (!char.IsDigit(x[0]) && x.Length < 11 && x.Length > 1) // Проверка на то, что первый элемент не цифра, а также длины логина
            {
                for (int i = 0; i < x.Length; i++)
                {
                    if (!(char.IsDigit(x[i]) || x[i] >= 'a' && x[i] <= 'z' || x[i] >= 'A' && x[i] <= 'Z')) // Проверка содержащихся символов
                    {
                        Console.WriteLine("Допускаются только цифры и буквы латинского алфавита!");
                        return;
                    }
                }
                Console.WriteLine("Логин указан корректно!");
            }
            else Console.WriteLine("Логин должен содержать от 2 до 10 символов и начинаться с латинской буквы!");
        }
        static void RegLogin()         // б) ** с использованием регулярных выражений.
        {
            Regex q = new Regex(@"^[a-zA-Z]{1}[\da-zA-Z]{1,9}$"); 
            Console.Write("Введите логин: ");
            string log = Console.ReadLine();
            Console.WriteLine(q.IsMatch(log)); // Возвращает правду либо ложь, если логин подходит под условие либо нет. 
        }
        static void Main(string[] args)
        {
            Login();
            RegLogin();
        }
    }
}

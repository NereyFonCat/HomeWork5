using System;
using System.Linq;

namespace HomeWork5._3
{
    // Суханов
    // *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
    // Например: badc являются перестановкой abcd.
    class Program
    {
        // Толком не понял, как сделать это вручную... Полазил по программе, нашёл метод, который уже умеет так делать... 
        static bool isThisPermutation(string s1, string s2)
        {
            return s1.Select(Char.ToUpper).OrderBy(x => x).SequenceEqual(s2.Select(Char.ToUpper).OrderBy(x => x));
        }
        static void Main(string[] args)
        {
            string s1 = "badc"; // Сделал по примеру, предложенному задачей. Вывод делал истины либо лжи. 
            string s2 = "abcd";
            Console.WriteLine(isThisPermutation(s1, s2));
        }
    }
}

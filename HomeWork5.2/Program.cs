using System;

namespace HomeWork5._2
{
    // Суханов
    // Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
    // б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
    // в) Найти самое длинное слово сообщения.
    // г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
    // д) *** Создать метод, который производит частотный анализ текста.
    // В качестве параметра в него передается массив слов и текст,
    // в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст.
    // Здесь требуется использовать класс Dictionary.
    static class Message
    {
        public static void LenText(string a, int n)     // а) Вывести только те слова сообщения, которые содержат не более n букв.
        {
            int r = 0;
            int t = 0;
            char[] e = a.ToCharArray();
            for (int i = 0; i <= e.Length; i++)
            {                                        // В этой задаче совершенно запутался, работает не так как надо. 
                if (i == e.Length && r - t <= n)     // Вывод идёт в некоторых случаях через мой пробел, в некоторых случаях через 2-3 пробела... 
                {
                    for (int j = i - n; j < i; j++)
                        Console.Write(e[j]);
                }
                else
                {
                    if (char.IsLetter(e[i]))
                    {
                        r++;
                    }
                    else
                    {
                        if (r - t <= n)
                        {
                            for (int j = i - n; j < i; j++)
                                Console.Write(e[j]);
                        }
                        r++;
                        t = r;
                        Console.Write(" ");
                    }
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string a = "jjf jj jhh n nn sgsdg sd sd gsd d d s sff s df";
            Message.LenText(a, 2);
        }
    }
}

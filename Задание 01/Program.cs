using System;
using System.Collections.Generic;

namespace Задание_01
//1.Дана строка, содержащая скобки трёх видов (круглые, квадратные и фигурные) и любые другие символы.
//Проверить, корректно ли в ней расставлены скобки. Например, в строке ([]{})[] скобки расставлены корректно, а в строке ([]] — нет.

//Указание: задача решается однократным проходом по символам заданной строки слева направо;
//для каждой открывающей скобки в строке в стек помещается соответствующая закрывающая,
//каждая закрывающая скобка в строке должна соответствовать скобке из вершины стека
//(при этом скобка с вершины стека снимается); в конце прохода стек должен быть пуст.
{
    class Program
    {
        static void Main(string[] args)
        {
        ReadString:
            Console.WriteLine("Здравствуйте!!");
            Console.WriteLine("Вас приветствует анализатор корретности расстановок скобок в строке!");

            //Получаем строку с клавиатуры
            Console.WriteLine("Введите строку для анализа рассатановки скобок:");
            string originalString = Console.ReadLine();
            if (originalString == "") { Console.WriteLine("Пустая строка"); goto ReadString; }

            //В соответствии с указанием объявляем объект типа Stack
            Stack<char> bracketStack = new Stack<char>();

            //С помощью цикла посимвольно проводится анализ содержимого строки в соответствиис указанием из задания
            for (byte i = 0; i < originalString.Length; i++)
            {
                if (originalString[i] == '(') { bracketStack.Push(')'); }
                if (originalString[i] == '[') { bracketStack.Push(']'); }
                if (originalString[i] == '{') { bracketStack.Push('}'); }

                if ((originalString[i] == ')') && (bracketStack.Count != 0) && (bracketStack.Peek() == ')'))
                { bracketStack.Pop(); }

                if ((originalString[i] == ']') && (bracketStack.Count != 0) && (bracketStack.Peek() == ']'))
                { bracketStack.Pop(); }

                if ((originalString[i] == '}') && (bracketStack.Count != 0) && (bracketStack.Peek() == '}'))
                { bracketStack.Pop(); }
            }

            //Проверка: если все скобки закрыты корректно, то стэк пуст !
            if (bracketStack.Count == 0) { Console.WriteLine("Скобки в данной строке расставлены корректно."); }
            else { Console.WriteLine("Некорректно расставлены скобки в данной строке."); }

            Console.WriteLine("До свидания !");
            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1.Samples
{
    class Operators
    {
        // Не обращайте внимания на конструкцию
        static Operators()
        {
            int variable = 12;
            int newVariable;
            // С переменными численных типов можно проводить арифметические операции
            newVariable = variable + 4;
            newVariable = variable*variable;
            newVariable = variable/6;
            newVariable = variable - 10;
            newVariable = variable%5;

            bool statement;
            // В переменные типа bool можно записывать результаты логических операций
            statement = 5 == 5;
            statement = 3 != 7;
            statement = 7 > 4;
            statement = 4 >= 7;

            var testString = "This";
            //Строки можно складывать (это называется конкатенацией)
            testString = testString + " is";
            testString = testString + " Sparta!";

            // Существуют условные операторы - if, switch. Они позволяют программе выбирать дальнейшие действия в зависимости от условий
            // Первый оператор позволяет проверить одно условие и выбрать то или иное действие
            // Второй позволяет проверить множество условий и для каждого обозначить своё действие
            // Оператор if выглядит так: 
            if (statement)
            {
                Console.WriteLine("Statement is true");
            }
            else
            {
                Console.WriteLine("Statement is false");
            }

            //Оператор switch выглядит так:
            switch (newVariable)
            {
                case 0:
                    Console.WriteLine("This is 0");
                    break;
                case 1:
                    Console.WriteLine("This is 1");
                    break;
                case 2:
                    Console.WriteLine("This is 2");
                    break;
                default:
                    Console.WriteLine("default");
                    break;
            }

            //Циклы позволяют программисту избавиться от необходимости писать одинаковый код множество раз
            //Циклы бывают с предусловием, постусловием и со счётчиком.
            //Содержимое цикла с предусловием будет выполняться только тогда, когда условие выполняется
            //Цикл с постусловием проверяет условие только в конце итерации, а значит содержимое цикла выполнится как минимум один раз
            //Цикл со счётчиком является частным случаем цикла с предусловием, в котором условием является достижение счётчика заданной величины
            while (statement)
            {
                Console.WriteLine("Я выполняюсь");
            }

            do
            {
                Console.WriteLine("Я всё ещё выполняюсь");
            } while (statement);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Я выполняюсь " + i + "-ый раз");
            }
        }
    }
}

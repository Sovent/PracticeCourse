using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1.Samples
{
    class Methods
    {
        // Методы - логически-обособленные структурные единицы программы
        // Можно рассматривать метод как подпрограмму, получающую исходные данные извне,
        // производящую нужные вычисления и возвращающую некий результат своих вычислений
        // Объявление метода в C# выглядит так
        // [модификаторы_доступа] возвращаемый_тип название_метода([входные параметры]) { тело_метода; ключевое_слово_return; }
        public int DoubleUp(int numberToDouble)
        {
            int result = numberToDouble*2;
            return result;
        }

        // Если методу для работы не требуется никаких входных данных, при объявлении не нужно указывать никаких параметров
        // Если метод не должен возвращать никаких результатов (важен лишь факт его работы), то возвращаемым типом нужно указать "void"
        private DateTime GetCurrentTime()
        {
            return DateTime.Now;
        }

        protected static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        // Использование методов
        // Объявленный в том же классе метод можно использовать, просто указав имя метода
        // и параметры для него (или оставив пустые скобки, если он не принимает параметров)
        // В случае, если возвращаемый тип метода не "void", результаты вычисления можно сохранить в соответствующую возвращаемому значению переменную

        public Methods()
        {
            int originalNumber = 3;
            int doubledNumber = DoubleUp(originalNumber);
            Console.WriteLine(doubledNumber);
            Console.WriteLine(GetCurrentTime());
            PrintArray(new int[] {4, 5, 2, 6, 5});
        }
    }
}

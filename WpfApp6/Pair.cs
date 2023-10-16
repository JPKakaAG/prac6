using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class Pair
    {
        public int First { get; set; }
        public int Second { get; set; }

        /// <summary>
        /// Конструктор, принимающий значения для обоих чисел в паре
        /// </summary>
        /// <param name="first"> первое число из пары</param>
        /// <param name="second"> второе число из пары</param>
        public Pair(int first, int second)
        {
            First = first;
            Second = second;
        }

        /// <summary>
        /// Перегрузка оператора умножения для пар
        /// </summary>
        /// <param name="a">первое число из второй пары</param>
        /// <param name="b">второе число из второй пары</param>
        /// <returns>возвращает результат перемножения</returns>
        public static Pair operator *(Pair a, Pair b)
        {
            int resultFirst = a.First * b.First;
            int resultSecond = a.Second * b.Second;
            return new Pair(resultFirst, resultSecond);
        }

        /// <summary>
        /// Перегрузка оператора инкремента для удвоения пары чисел
        /// </summary>
        /// <param name="p">объект</param>
        /// <returns>возвращает результат удвоения пары чисел</returns>
        public static Pair operator ++(Pair p)
        {
            int doubledFirst = p.First * 2;
            int doubledSecond = p.Second * 2;
            return new Pair(doubledFirst, doubledSecond);
        }
    }
}

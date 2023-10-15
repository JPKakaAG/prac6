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

        public Pair(int first, int second)
        {
            First = first;
            Second = second;
        }

        public static Pair operator *(Pair a, Pair b)
        {
            int resultFirst = a.First * b.First;
            int resultSecond = a.Second * b.Second;
            return new Pair(resultFirst, resultSecond);
        }

        public static Pair operator ++(Pair p)
        {
            int doubledFirst = p.First * 2;
            int doubledSecond = p.Second * 2;
            return new Pair(doubledFirst, doubledSecond);
        }
    }
}

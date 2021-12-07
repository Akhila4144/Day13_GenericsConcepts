using System;
using System.Collections.Generic;
using System.Text;

namespace Refactor1OfMax
{
    class GenericMax<T> where T : IComparable
    {
        public T n1, n2, n3;
        public GenericMax(T n1, T n2, T n3)
        {
            this.n1 = n1;
            this.n2 = n2;
            this.n3 = n3;
        }
        public static T MaxValue(T n1, T n2, T n3)
        {
            if (n1.CompareTo(n2) > 0 && n1.CompareTo(n3) > 0 || n1.CompareTo(n2) >= 0 && n1.CompareTo(n3) > 0 || n1.CompareTo(n2) > 0 && n1.CompareTo(n3) > 0)
            {
                Console.WriteLine(n1 + " Greater than " + n2 + " and " + n3);
            }
            else if (n2.CompareTo(n1) > 0 && n2.CompareTo(n3) > 0 || n2.CompareTo(n1) >= 0 && n2.CompareTo(n3) > 0 || n2.CompareTo(n1) > 0 && n2.CompareTo(n3) > 0)
            {
                Console.WriteLine(n2 + " Greater than " + n1 + " and " + n3);
            }
            else if (n3.CompareTo(n1) > 0 && n3.CompareTo(n2) > 0 || n3.CompareTo(n1) >= 0 && n3.CompareTo(n2) > 0 || n3.CompareTo(n1) > 0 && n3.CompareTo(n2) > 0)
            {
                Console.WriteLine(n3 + " Greater than " + n1 + " and " + n2);
            }
            return default;
        }
    }
}

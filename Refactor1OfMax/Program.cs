using System;

namespace Refactor1OfMax
{
    class Program
    {
        static void Main(string[] args)
        {

            GenericMax<int>.MaxValue(10, 2, 4);
            GenericMax<double>.MaxValue(10.5, 22.5, 14.6);
            GenericMax<String>.MaxValue("apple", "peach", "banana");
        }
    }
}

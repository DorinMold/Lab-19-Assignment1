using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab_19_Assignment1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] Integers = new int[Int16.MaxValue];
            IntegerCollection CollectionInt = new IntegerCollection();

            foreach ( short j in CollectionInt )
            {
                Integers[j] = j;
            }
            Console.WriteLine("Colectia Integers are primul element: " + Integers[0].ToString());
            Console.WriteLine("Colectia Integers are ultimul element: " + Integers[Int16.MaxValue - 1].ToString());

            OddIntegers();

        }

        static void OddIntegers ()
        {
            IntegerCollection CollectionInt = new IntegerCollection(20);
            int i = 0;
            int j = 0;

            int[] OddIntegers = new int[11];

            foreach ( var item in CollectionInt)
            {
                if (i % 2 != 0)
                {
                    OddIntegers[j] = (Int16) item;
                    Console.WriteLine($"Colectia OddIntegers are elementul {j}: { OddIntegers[j].ToString() } ");
                    j++;
                }
                i++;
            }
        }
    }

    class IntegerCollection : IEnumerable
    {
        int? x = 0;

        public IntegerCollection(int? a = null)
        {
            this.x = a;
        }

        public IEnumerator GetEnumerator()
        {
            short i = 0;
            do
            {
                if (i == short.MaxValue || (!(this.x is null) && this.x == i)) yield break;
                yield return i;
                i++;
            } while (true);
        }
    }
}


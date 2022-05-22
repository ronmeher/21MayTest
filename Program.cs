using System;

namespace _21MayTest
{
    internal class Program
    {
        static void Show<T>(T[] inputArrray)
        {
            foreach (var elements in inputArrray)
            {
                Console.WriteLine(" " + elements);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("21 May Test!");

            PerfectNumbers f1 = new PerfectNumbers();
            f1.Display();

            //ReverseNumbers f2 = new ReverseNumbers();
            //f2.Display();

            //GenericsExample p3 = new GenericsExample();


            //int[] intArray = { 1, 2, 3, 4, 5 };
            //double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5 };
            //char[] charArray = { 'a', 'b', 'c', 'd' };

            //Program.Show(intArray);
            //Program.Show(doubleArray);
            //Program.Show(charArray);
        }
    }
    
}

using System;

namespace Generyk
{
    public static class Program
    {
        //1
        public static T Max<T>(T a, T b, T c)
        {          
            T max = a;
            if (((IComparable<T>)b).CompareTo(max) > 0)
            {
                max = b;
            }
            if (((IComparable<T>)c).CompareTo(max) > 0)
            {
                max = c;
            }
            return max;
        }
        //2
        public static T Min<T>(T a, T b, T c)
        {
            T min = a;
            if (((IComparable<T>)b).CompareTo(min) < 0)
            {
                min = b;
            }
            if (((IComparable<T>)c).CompareTo(min) < 0)
            {
                min = c;
            }
            return min;
        }
        //3
        public static T Sum<T>(T[] array)
        {
            dynamic sum = 0; 
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }


        static void Main(string[] args)
        {
            //1
            int maxInt = Program.Max<int>(3, 5, 1); 
            double maxDouble = Program.Max<double>(2.5, 1.1, 3.0);

            Console.WriteLine($"max: 3, 5, 1: {maxInt}");
            Console.WriteLine($"max: 2.5, 1.1, 3.0: {maxDouble}");
            //2
            int minInt = Program.Min<int>(3, 5, 1); 
            double minDouble = Program.Min<double>(2.5, 1.1, 3.0); 

            Console.WriteLine($"min: 3, 5, 1: {minInt}");
            Console.WriteLine($"min: 2.5, 1.1, 3.0: {minDouble}");
            //3
            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.5, 2.7, 3.9 };
            
            int intSum = Sum<int>(intArray); 
            double doubleSum = Sum<double>(doubleArray);
            Console.WriteLine($"int sum intArray =  1, 2, 3, 4, 5 = {intSum}");
            Console.WriteLine($"double sumdoubleArray =  1.5, 2.7, 3.9 = {doubleSum}");
            //4
            Stack<int> stack = new Stack<int>();

            stack.Push(1);
            stack.Push(4);
            stack.Push(7);
            Console.WriteLine("Stack = 1  4  7");
            Console.WriteLine($" Pop{stack.Pop()}"); 
            Console.WriteLine($" Peek {stack.Peek()}"); 
            Console.WriteLine($" Count {stack.Count}"); 
            //5
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Console.WriteLine($"Count: {queue.Count}");
            Console.WriteLine($"Peek: {queue.Peek()}");

            int item1 = queue.Dequeue();
            int item2 = queue.Dequeue();

            Console.WriteLine($"Count: {queue.Count}");
            Console.WriteLine($"Dequeue item1: {item1}");
            Console.WriteLine($"Dequeue item2: {item2}");

            queue.Enqueue(4);

            Console.WriteLine($"Count: {queue.Count}");

            int item3 = queue.Dequeue();

            Console.WriteLine($"Count: {queue.Count}");
            Console.WriteLine($"Dequeue item3: {item3}");
        }
    }
}
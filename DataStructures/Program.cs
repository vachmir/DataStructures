using System;
using System.Collections.Generic;


namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> intList = new LinkedList<int>();
            Stack<int> intStack = new Stack<int>();
            Queue<int> intQueue = new Queue<int>();
            Dictionary<int, bool> keyValuePairs = new Dictionary<int, bool>();

            intStack.Push(5);
            intStack.Push(6);
            intStack.Push(7);
            intStack.Push(8);
            intStack.Push(9);
            intStack.Push(10);
                        
            Console.WriteLine(intStack.Peek());
            Console.WriteLine(intStack.Peek());
            intStack.Pop();
            Console.WriteLine(intStack.Peek());
            intStack.Push(2);
            Console.WriteLine(intStack.Peek());
            Console.WriteLine();
            Console.WriteLine();

            intQueue.Enqueue(15);
            intQueue.Enqueue(16);
            intQueue.Enqueue(17);
            intQueue.Enqueue(18); 
            intQueue.Enqueue(19);
            intQueue.Enqueue(20);
            Console.WriteLine(intQueue.Peek());
            Console.WriteLine(intQueue.Peek());
            intQueue.Dequeue();
            Console.WriteLine(intQueue.Peek());
            intQueue.Enqueue(13);
            Console.WriteLine(intQueue.Peek());
              
            Console.WriteLine();
            Console.WriteLine();
            intList.AddLast(25);
            intList.AddLast(26);
            intList.AddLast(27);
            intList.AddLast(28);
            intList.AddLast(29);
            intList.AddLast(30);
            Console.WriteLine(intList.Count);
            //intList.RemoveFirst();
            if (intList.Contains(25))
            {
                Console.WriteLine("25 exists");
            }
            Console.WriteLine();
            intList.AddFirst(99);
            Console.WriteLine();
            foreach (var num in intList)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();
            intList.Remove(28);

            foreach (var num in intList)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine( );
            Console.WriteLine();
            keyValuePairs.Add(1, true);
            keyValuePairs.Add(5, true);
            keyValuePairs.Add(0, false);

            foreach (var item in keyValuePairs)
            {
                Console.WriteLine(item.Key);
            }

        }
    }
}

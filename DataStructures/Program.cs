using System;
using System.Collections.Generic;


namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> intLinkedList = new LinkedList<int>();
            List<int> intList = new List<int>();
            Stack<int> intStack = new Stack<int>();
            Queue<int> intQueue = new Queue<int>();
            Dictionary<int, bool> keyValuePairs = new Dictionary<int, bool>();

            Console.WriteLine("LinkedList");
            intLinkedList.AddLast(25);
            intLinkedList.AddLast(26);
            intLinkedList.AddLast(27);
            intLinkedList.AddLast(28);
            intLinkedList.AddLast(29);
            intLinkedList.AddLast(30);
            Console.WriteLine(intLinkedList.Count);
            intLinkedList.RemoveFirst();
            foreach (var item in intLinkedList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            intLinkedList.AddFirst(99);
            Console.WriteLine("Linked List with new 1st element");
            foreach (var number in intLinkedList)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Number 28 removed ");

            foreach (var number in intLinkedList)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();
            Console.WriteLine("List");
            intList.Add(1);
            intList.Add(5);
            intList.Add(0);
            intList.Add(4);
            foreach (var item in intList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            intStack.Push(5);
            intStack.Push(6);
            intStack.Push(7);
            intStack.Push(8);
            intStack.Push(9);
            intStack.Push(10);
            Console.WriteLine("Initial Stack");
            foreach (var item in intStack)
            {
                Console.WriteLine(item);
            }
            intStack.Peek();
            intStack.Peek();
            intStack.Pop();
            intStack.Peek();
            intStack.Push(2);
            intStack.Peek();
            Console.WriteLine("Changed Stack");            
            foreach (var item in intStack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Queue");

            intQueue.Enqueue(15);
            intQueue.Enqueue(16);
            intQueue.Enqueue(17);
            intQueue.Enqueue(18); 
            intQueue.Enqueue(19);
            intQueue.Enqueue(20);
            Console.WriteLine($"1st number now is: {intQueue.Peek()}");

            foreach (var item in intQueue)
            {
                Console.WriteLine(item);
            }

            intQueue.Dequeue();
            intQueue.Enqueue(13);
            Console.WriteLine("1st number Dequeued, number 13 Enqueued");
            Console.WriteLine($"1st number now is: {intQueue.Peek()}");
            foreach (var item in intQueue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Dictionaries");
            keyValuePairs.Add(1, false);
            keyValuePairs.Add(2, true);
            keyValuePairs.Add(3, true);
            keyValuePairs.Add(4, true);
            keyValuePairs.Add(5, true);
            keyValuePairs.Add(0, false);
            foreach (var item in keyValuePairs)
            {
                Console.WriteLine(item.Key);
            }
            keyValuePairs.Remove(2);
            Console.WriteLine("Key 2 Removed");
            foreach (var item in keyValuePairs)
            {
                Console.WriteLine($"Key is {item.Key}, Value is {item.Value}");
            }           
        }
    }
}

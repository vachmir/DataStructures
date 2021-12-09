using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            #region Array vs Data Structure
            ////Զանգված
            //Person[] arrayOfPerson = new Person[10];
            //int[] arrayOfInt= new int[10];

            ////Ցուցակ
            //LinkedList<Person> listOfPerson = new LinkedList<Person>();
            //LinkedList<int> listOfInt = new LinkedList<int>();

            ////Ցուցակների զանգված
            //LinkedList<Person>[] arrayOfLinkedListOfPerson = new LinkedList<Person>[10];
            //LinkedList<int>[] arrayOfLinkedListOfInt= new LinkedList<int>[10];  

            ////Զանգվածների ցուցակ
            //LinkedList<Person[]> linkedListOfArrayOfPerson = new LinkedList<Person[]>();
            //LinkedList<int[]> linkedListOfArrayOfInt = new LinkedList<int[]>(); 

            //arrayOfPerson[0] = new Person() { };
            //arrayOfPerson[1] = new Person { FirstName = "Վաչագան", LastName = "Միրզոյան" };
            //arrayOfPerson[2] = new Person { FirstName = "Միհրան", LastName = "Բաբայան", Email = "mihran@gmail.com" };
            //arrayOfInt[0] = 0;
            //arrayOfInt[1] = 10;

            //listOfPerson.AddFirst( new Person { FirstName = "Անի", LastName = "Ասատրյան", Email = "ani@gmail.com" });
            //listOfPerson.AddFirst(new Person { });
            //listOfPerson.AddFirst(new Person { FirstName = "Վահան", LastName = "Դարբինյան" });
            //listOfPerson.AddFirst(new Person { FirstName = "Վահան", LastName = "Դարբինյան" });
            /////և այլն  
            //listOfInt.AddFirst(1);
            //listOfInt.AddFirst(9);
            /////և այլն


            //arrayOfLinkedListOfPerson[0] = new LinkedList<Person>();
            //arrayOfLinkedListOfPerson[0].AddFirst(new Person() { });
            //arrayOfLinkedListOfPerson[0].AddFirst(new Person() { FirstName = "Աննա", LastName = "Ասատրյան" });
            //arrayOfLinkedListOfPerson[0].AddFirst(new Person() { FirstName = "Սոնա", LastName = "Ասատրյան", Email = "sona@gmail.com" });
            //arrayOfLinkedListOfPerson[1] = new LinkedList<Person>();
            /////և այլն       
            //arrayOfLinkedListOfInt[0] = new LinkedList<int>();
            //arrayOfLinkedListOfInt[0].AddLast(1);
            //arrayOfLinkedListOfInt[0].AddFirst(9);
            /////և այլն  


            //linkedListOfArrayOfPerson.AddLast(new Person[]
            //{
            //    new Person { }, 
            //    new Person { }
            //});
            //linkedListOfArrayOfPerson.AddLast(new Person[] 
            //{ 
            //    new Person{ FirstName = "Վաչագան", LastName = "Միրզոյան" },
            //    new Person { FirstName = "Սոնա", LastName = "Ասատրյան", Email = "sona@gmail.com" },
            //    new Person{ },
            //    new Person { FirstName = "Միհրան", LastName = "Բաբայան", Email = "mihran@gmail.com" }
            //});

            //linkedListOfArrayOfPerson.AddLast(new Person[]
            //{
            //    new Person { FirstName = "Վահան", LastName = "Դարբինյան" },
            //    new Person {FirstName = "Արա", LastName = "Ավետիքյան", Email = "ara@gmail.com" },
            //});
            /////և այլն  

            //linkedListOfArrayOfInt.AddLast(new int[] { 1, 1 });
            //linkedListOfArrayOfInt.AddFirst(new int[12]);           
            /////և այլն  

            #endregion

            //LinkedList();
            //List();
            ArrayList();
            //Stack();
            //Queue();
            //Dictionary();
            //SortedDictionary();
            //SortedList();
            //SortedSet();

            //CompareSortedDictionaryAndSortedList();

        }

        public static void LinkedList()
        {
            Console.Title = "LinkedList";

            LinkedList<int> intLinkedList = new LinkedList<int>();
            Console.WriteLine("LinkedList");
            for (int i = 40; i < 50; i++)
            {
                intLinkedList.AddFirst(i);
            }
            for (int i = 30; i < 40; i++)
            {
                intLinkedList.AddLast(i);
            }
            Console.WriteLine($"Linked List-ի տարրերի քանակը {intLinkedList.Count} է");
            foreach (var number in intLinkedList)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
            intLinkedList.RemoveFirst();
            Console.WriteLine("Linked List-ից ջնջվեց 1-ին տարրը");
            foreach (var number in intLinkedList)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
            intLinkedList.AddFirst(99);
            intLinkedList.AddBefore(intLinkedList.Last, 66);
            Console.WriteLine("Ձևափոխված Linked List-ը");
            foreach (var number in intLinkedList)
            {
                Console.Write($"{number} ");
            }
        }
        public static void List()
        {
            Console.Title = "List";
            List<double> doubleList = new List<double>();

            Random rnd = new Random();
            int rndLength = rnd.Next(10, 15);
            double max = 100d, min = 1d;
            Console.WriteLine("List");
            for (int number = 1; number < rndLength; number++)
            {
                double doubleNumber = ((rnd.NextDouble() * (max - min)) + min);
                doubleList.Add(Math.Round(doubleNumber, 3));
            }
            Console.WriteLine($"List-ի տարրերի քանակը {doubleList.Count} է, տարրերն են՝ ");
            foreach (var number in doubleList)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
            doubleList.Insert(2, 9999d);
            doubleList.RemoveAt(5);
            doubleList.Reverse();
            Console.WriteLine($"List-ի տարրերի քանակը հիմա {doubleList.Count} է, տարրերն են՝ ");
            foreach (var number in doubleList)
            {
                Console.Write($"{number} ");
            }

        }  
        public static void ArrayList()
        {
            ArrayList al= new ArrayList();
            SortedSet[] set = new SortedSet[] {};

            al.Add(1);
            al.Add(1);
            al.Add("Բառ");
            al.Add(true);
            al.Add('Ճ');
            al.AddRange(set);
            al[1] = 9.1;
            foreach (var item in al)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(al[3]);
         

        }
        public static void Stack()
        {
            Console.Title = "Stack";

            Stack<object> objStack = new Stack<object>();

            for (int i = 0; i < 15; i++)
            {
                objStack.Push(i);
            }
            Console.Write("Նախնական Stack-ը՝ ");
            foreach (var number in objStack)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();

            Console.WriteLine($"Ցուցադրել վերջինն ավելացրած տարրը՝ {objStack.Peek()}");
            Console.WriteLine($"Ցուցադրել վերջինն ավելացրած տարրը՝ {objStack.Peek()}");
            Console.WriteLine($"Ջնջել վերջինն ավելացրած տարրը՝ {objStack.Pop()}");
            Console.WriteLine($"Եվս մեկա անգամ ջնջել վերջինն ավելացրած տարրը՝ {objStack.Pop()}");
            Console.WriteLine($"Ցուցադրել վերջինն ավելացրած տարրը՝ {objStack.Peek()}");
            objStack.Push("Թիվ");
            Console.WriteLine($"Ավելացել է նոր տարր՝ «{objStack.Peek()}»");

            Console.Write("Ձևափոխված Stack-ը՝ ");
            foreach (var number in objStack)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Գուշակե՛ք, թե որն է վերջին տարրը՝ «{objStack.Peek()}»");
            Console.WriteLine();
            Console.WriteLine();

        }
        public static void Queue()
        {
            Console.Title = "Queue";

            Queue<object> objQueue = new Queue<object>();

            for (int i = 0; i < 15; i++)
            {
                switch (i)
                {
                    case 1:
                        objQueue.Enqueue($"{i}-ին");
                        break;
                    default:
                        objQueue.Enqueue($"{i}-րդ");
                        break;
                }
            }

            Console.Write($"Նախնական Queue-ն՝ ");
            foreach (var number in objQueue)
            {
                Console.Write($"{number} ");
            }

            Console.WriteLine();

            objQueue.Dequeue();
            Console.WriteLine("Ջնջվեց 1-ին ինդեքս ունեցող տարրը");

            objQueue.Enqueue("Ես այստեղ եմ");
            string word = (string)objQueue.Peek();
            Console.WriteLine($"1-ին ինդեքսով տարրը հիմա հենց {word.Remove(2)}ն է");
            Console.WriteLine("Վերջնական Queue-ն՝ ");
            foreach (var item in objQueue)
            {
                Console.Write($"{item} ");
            }

        }
        public static void Dictionary()
        {            
            Dictionary<int, Person> dictionaryKeyValuePairs = new Dictionary<int, Person>();

            Console.WriteLine("Սկզբնական Dictionary-ն");
            dictionaryKeyValuePairs.Add(1, new Person { FirstName = "Վաչագան", LastName = "Միրզոյան" });
            dictionaryKeyValuePairs.Add(2, new Person { FirstName = "Միհրան", LastName = "Բաբայան", Email = "mihran@gmail.com" });
            dictionaryKeyValuePairs.Add(4, new Person { FirstName = "Արա", LastName = "Ավետիքյան", Email = "ara@gmail.com" });
            dictionaryKeyValuePairs.Add(5, new Person { FirstName = "Անի", LastName = "Ասատրյան", Email = "ani@gmail.com" });
            dictionaryKeyValuePairs.Add(6, new Person { FirstName = "Աննա", LastName = "Ասատրյան" });
            dictionaryKeyValuePairs.Add(7, new Person { FirstName = "Սոնա", LastName = "Ասատրյան", Email = "sona@gmail.com" });
            dictionaryKeyValuePairs.Add(8, new Person { FirstName = "Վահան", LastName = "Դարբինյան" });
            dictionaryKeyValuePairs.Add(3, new Person { FirstName = "Հրանտ", LastName = "Ասայան", Email = "hrant@gmail.com" });
            
            foreach (var item in dictionaryKeyValuePairs)
            {
                Console.WriteLine($"Համար {item.Key}, {item.Value.FirstName}, {item.Value.LastName}, {item.Value.Email}");
            }
            dictionaryKeyValuePairs.Remove(2);
            Console.WriteLine("2-րդ համարը ջնջվել է");
            Console.WriteLine("Dictionary-ն հիմա՝");

            foreach (var item in dictionaryKeyValuePairs)
            {
                Console.WriteLine($"Համար {item.Key}, {item.Value.FirstName}, {item.Value.LastName}, {item.Value.Email}");
            }
        }
        public static void SortedDictionary()
        {
            SortedDictionary<int, Person> sortedDictionaryKeyValuePairs = new SortedDictionary<int, Person>();
            Console.WriteLine("SortedDictionary-ի բոլոր տարրերը դասավորված են բանալու աճման կարգով");
            sortedDictionaryKeyValuePairs.Add(1, new Person { FirstName = "Վաչագան", LastName = "Միրզոյան" });
            sortedDictionaryKeyValuePairs.Add(8, new Person { FirstName = "Վահան", LastName = "Դարբինյան" });
            sortedDictionaryKeyValuePairs.Add(4, new Person { FirstName = "Արա", LastName = "Ավետիքյան", Email = "ara@gmail.com" });
            sortedDictionaryKeyValuePairs.Add(3, new Person { FirstName = "Հրանտ", LastName = "Ասայան", Email = "hrant@gmail.com" });
            sortedDictionaryKeyValuePairs.Add(6, new Person { FirstName = "Աննա", LastName = "Ասատրյան" });
            sortedDictionaryKeyValuePairs.Add(7, new Person { FirstName = "Սոնա", LastName = "Ասատրյան", Email = "sona@gmail.com" });
            sortedDictionaryKeyValuePairs.Add(2, new Person { FirstName = "Միհրան", LastName = "Բաբայան", Email = "mihran@gmail.com" });
            sortedDictionaryKeyValuePairs.Add(5, new Person { FirstName = "Անի", LastName = "Ասատրյան", Email = "ani@gmail.com" });

            foreach (var item in sortedDictionaryKeyValuePairs)
            {
                Console.WriteLine($"Համար {item.Key}, {item.Value.FirstName}, {item.Value.LastName}, {item.Value.Email}");
            }
            
        }

        public static void SortedList()
        {                      
            SortedList<int, Person> sortedListKeyValuePairs = new SortedList<int, Person>();

            Console.WriteLine("SortedDictionary-ի բոլոր տարրերը դասավորված են բանալու աճման կարգով");
            sortedListKeyValuePairs.Add(1, new Person { FirstName = "Վաչագան", LastName = "Միրզոյան" });
            sortedListKeyValuePairs.Add(8, new Person { FirstName = "Վահան", LastName = "Դարբինյան" });
            sortedListKeyValuePairs.Add(4, new Person { FirstName = "Արա", LastName = "Ավետիքյան", Email = "ara@gmail.com" });
            sortedListKeyValuePairs.Add(3, new Person { FirstName = "Հրանտ", LastName = "Ասայան", Email = "hrant@gmail.com" });
            sortedListKeyValuePairs.Add(6, new Person { FirstName = "Աննա", LastName = "Ասատրյան" });
            sortedListKeyValuePairs.Add(7, new Person { FirstName = "Սոնա", LastName = "Ասատրյան", Email = "sona@gmail.com" });
            sortedListKeyValuePairs.Add(2, new Person { FirstName = "Միհրան", LastName = "Բաբայան", Email = "mihran@gmail.com" });
            sortedListKeyValuePairs.Add(5, new Person { FirstName = "Անի", LastName = "Ասատրյան", Email = "ani@gmail.com" });

            foreach (var item in sortedListKeyValuePairs)
            {
                Console.WriteLine($"Համար {item.Key}, {item.Value.FirstName}, {item.Value.LastName}, {item.Value.Email}");
            }

        }
        public static void SortedSet()
        {
            Console.Title = "SortedSet";

            SortedSet<int> intSortedSet1 = new SortedSet<int>();
            SortedSet<int> intSortedSet2 = new SortedSet<int>();
            SortedSet<int> intSortedSet3 = new SortedSet<int>();

            Console.WriteLine("Sorted Set");
            var stopWatch1 = Stopwatch.StartNew();
            for (int i = 0; i < 100; i++)
            {
                intSortedSet1.Add(i);
            }
            Console.WriteLine($"1Անցավ {stopWatch1.Elapsed} վայրկյան");

            var stopWatch2 = Stopwatch.StartNew();
            for (int k = 0; k < 100; k++)
            {
                intSortedSet2.Add(k);
            }
            Console.WriteLine($"2Անցավ {stopWatch2.Elapsed} վայրկյան");


            var stopWatch3 = Stopwatch.StartNew();
            for (int j = 0; j < 100; j++)
            {
                intSortedSet3.Add(j);
            }
            Console.WriteLine($"3Անցավ {stopWatch3.Elapsed} վայրկյան");
        }

     

        public static void CompareSortedDictionaryAndSortedList()
        {
            SortedDictionary<int, Person> sortedDictionary = new SortedDictionary<int, Person>();
            SortedDictionary<int, Person> sortedDictionary1 = new SortedDictionary<int, Person>();
            SortedList<int, Person> sortedList = new SortedList<int, Person>();
            SortedList<int, Person> sortedList1 = new SortedList<int, Person>();
          

            var dictionaryStopwatch = Stopwatch.StartNew();
            for (int i = 9; i < 1000000; i++)
            {
                sortedDictionary.Add(i, new Person { });               
            }
            var elapsedDI = dictionaryStopwatch.Elapsed;
            Console.WriteLine($"{elapsedDI}");

            var dictionaryStopwatch1 = Stopwatch.StartNew();
            for (int i = 9; i < 1000000; i++)
            {
                sortedDictionary1.Add(i, new Person { });
            }
            var elapsedDI1 = dictionaryStopwatch1.Elapsed;
            Console.WriteLine($"{elapsedDI1}");



            var listStopwatch = Stopwatch.StartNew();
            for (int i = 9; i < 1000000; i++)
            {
                sortedList.Add(i, new Person { });                
            }
            var elapsedLI = listStopwatch.Elapsed;
            Console.WriteLine($"{elapsedLI}");

            var listStopwatch1 = Stopwatch.StartNew();
            for (int i = 9; i < 1000000; i++)
            {
                sortedList1.Add(i, new Person { });
            }
            var elapsedLI1 = listStopwatch1.Elapsed;
            Console.WriteLine($"{elapsedLI1}");



            Console.WriteLine("List");

            var swList0 = Stopwatch.StartNew();
            sortedList.Add(0, new Person { });
            var elapsedL0 = swList0.Elapsed;
            Console.WriteLine(elapsedL0);

            var swList1 = Stopwatch.StartNew();
            sortedList.Add(1, new Person { });
            var elapsedL1 = swList1.Elapsed;
            Console.WriteLine(elapsedL1);

            var swList2 = Stopwatch.StartNew();
            sortedList.Add(2, new Person { });
            var elapsedL2 = swList2.Elapsed;
            Console.WriteLine(elapsedL2);

           

            Console.WriteLine("Dictionary");
            var swDictionary0 = Stopwatch.StartNew();
            sortedDictionary.Add(0, new Person { });
            var elapsedD0 = swDictionary0.Elapsed;
            Console.WriteLine(elapsedD0);
            


            Console.WriteLine("List");
            var swList3 = Stopwatch.StartNew();
            sortedList.Add(3, new Person { });
            var elapsedL3 = swList3.Elapsed;
            Console.WriteLine(elapsedL3);


            Console.WriteLine("Dictionary");
            var swDictionary1 = Stopwatch.StartNew();
            sortedDictionary.Add(1, new Person { });
            var elapsedD1 = swDictionary1.Elapsed;
            Console.WriteLine(elapsedD1);



            Console.WriteLine("List");
            var swList4 = Stopwatch.StartNew();
            sortedList.Add(4, new Person { });
            var elapsedL4 = swList4.Elapsed;
            Console.WriteLine(elapsedL4);

            

            Console.WriteLine("Dictionary");           
           
            var swDictionary2 = Stopwatch.StartNew();
            sortedDictionary.Add(2, new Person { });
            var elapsedD2 = swDictionary2.Elapsed;
            Console.WriteLine(elapsedD2);

            var swDictionary3 = Stopwatch.StartNew();
            sortedDictionary.Add(3, new Person { });
            var elapsedD3 = swDictionary3.Elapsed;
            Console.WriteLine(elapsedD3);



            Console.WriteLine("List");
            var swList5 = Stopwatch.StartNew();
            sortedList.Add(5, new Person { });
            var elapsedL5 = swList5.Elapsed;
            Console.WriteLine(elapsedL5);

            var swList6 = Stopwatch.StartNew();
            sortedList.Add(6, new Person { });
            var elapsedL6 = swList6.Elapsed;
            Console.WriteLine(elapsedL6);



            Console.WriteLine("Dictionary");   
            
            var swDictionary4 = Stopwatch.StartNew();
            sortedDictionary.Add(4, new Person { });
            var elapsedD4 = swDictionary4.Elapsed;
            Console.WriteLine(elapsedD4);

            var swDictionary5 = Stopwatch.StartNew();
            sortedDictionary.Add(5, new Person { });
            var elapsedD5 = swDictionary5.Elapsed;
            Console.WriteLine(elapsedD5);

            var swDictionary6 = Stopwatch.StartNew();
            sortedDictionary.Add(6, new Person { });
            var elapsedD6 = swDictionary6.Elapsed;
            Console.WriteLine(elapsedD6);

            var swDictionary7 = Stopwatch.StartNew();
            sortedDictionary.Add(7, new Person { });
            var elapsedD7 = swDictionary7.Elapsed;
            Console.WriteLine(elapsedD7);



            Console.WriteLine("List");
            var swList7 = Stopwatch.StartNew();
            sortedList.Add(7, new Person { });
            var elapsedL7 = swList7.Elapsed;
            Console.WriteLine(elapsedL7);



            Console.WriteLine("Dictionary");
            var swDictionary8 = Stopwatch.StartNew();
            sortedDictionary.Add(8, new Person { });
            var elapsedD8 = swDictionary8.Elapsed;
            Console.WriteLine(elapsedD8);
            Console.WriteLine();

            
            Console.WriteLine("List value removal");
            var swListRemove0 = Stopwatch.StartNew();
            sortedList.Remove(sortedList.Count);            
            var elapsedListRemove0 = swListRemove0.Elapsed;
            Console.WriteLine(elapsedListRemove0);



            Console.WriteLine("Dictionary value removal");
            var swDictionaryRemove0=Stopwatch.StartNew();
            sortedDictionary.Remove(sortedDictionary.Count);
            var elapsedDictionaryRemove0=swDictionaryRemove0.Elapsed;
            Console.WriteLine(elapsedDictionaryRemove0);



            Console.WriteLine("List value removal");
            var swListRemove1 = Stopwatch.StartNew();
            sortedList.Remove(sortedList.Count);
            var elapsedListRemove1 = swListRemove1.Elapsed;
            Console.WriteLine(elapsedListRemove1);



            Console.WriteLine("Dictionary value removal");
            var swDictionaryRemove1 = Stopwatch.StartNew();
            sortedDictionary.Remove(sortedDictionary.Count);
            var elapsedDictionaryRemove1 = swDictionaryRemove1.Elapsed;
            Console.WriteLine(elapsedDictionaryRemove1);


            Console.WriteLine("List value removal");
            var swListRemove2 = Stopwatch.StartNew();
            sortedList.Remove(sortedList.Count);
            var elapsedListRemove2 = swListRemove2.Elapsed;
            Console.WriteLine(elapsedListRemove2);

            Console.WriteLine("Dictionary value removal");
            var swDictionaryRemove2 = Stopwatch.StartNew();
            sortedDictionary.Remove(sortedDictionary.Count);
            var elapsedDictionaryRemove2 = swDictionaryRemove2.Elapsed;
            Console.WriteLine(elapsedDictionaryRemove2);


            Console.WriteLine("List value removal");
            var swListRemove3 = Stopwatch.StartNew();
            sortedList.Remove(sortedList.Count);
            var elapsedListRemove3 = swListRemove3.Elapsed;
            Console.WriteLine(elapsedListRemove3);

            Console.WriteLine("Dictionary value removal");
            var swDictionaryRemove3 = Stopwatch.StartNew();
            sortedDictionary.Remove(sortedDictionary.Count);
            var elapsedDictionaryRemove3 = swDictionaryRemove3.Elapsed;
            Console.WriteLine(elapsedDictionaryRemove3);


        }
    }
}


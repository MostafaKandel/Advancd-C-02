using System.Collections;
using System.Collections.Generic;

namespace Advancd_C_02
{
    internal class Program
    {
        #region Q1
        /*
         *  Given an array  consists of  numbers with size N and number of queries, 
         *  in each query you will be given an integer X, and you should print how many
         *  numbers in array that is greater than  X.
         */
        public static int CountGreaterThanX(int[] arr, int x)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > x) count++;

            }
            return count;
        }
        #endregion

        #region Q5
        //Given an array, implement a function to remove duplicate elements from an array.
        //public static List<T> RemoveDuplicate<T>(List<T> inputList)
        //{
        //    List<T> output = new List<T>();

        //    foreach (var item in inputList)
        //    {
        //        if (!output.Contains(item))
        //        {
        //            output.Add(item);
        //        }
        //    }
        //    return output;
        //}
        #endregion

        #region Q6
        //Given an array list, implement a function to remove all odd numbers from it.
        //public static void RemoveOdd(ArrayList inputList)
        //{
        //    for (int i = inputList.Count - 1; i >= 0; i--)
        //    {
        //        if (inputList[i] is int number && number % 2 != 0)
        //        {
        //            inputList.RemoveAt(i);
        //        }
        //    }
        //}
        #endregion

        #region Q11
        // Given a queue reverse first K elements of a queue, keeping the remaining elements in the same order 
        //public static void ReverseFirstKElements<T>(Queue<T> queue, int k)
        //{
        //    if (k <= 0 || k > queue.Count) return;
        //    Stack<T> tempStack = new Stack<T>();
        //    for(int i = 0; i < k; i++)
        //    {
        //        tempStack.Push(queue.Dequeue());
        //    }
        //    while (tempStack.Count > 0)
        //    {
        //        queue.Enqueue(tempStack.Pop());
        //    }
        //    for (int i = 0; i < queue.Count-k; i++)
        //    {
        //        queue.Enqueue(queue.Dequeue());
        //    }
        //}
        #endregion
        static void Main(string[] args)
        {
            #region Q1
            /*
             *  Given an array  consists of  numbers with size N and number of queries, 
             *  in each query you will be given an integer X, and you should print how many
             *  numbers in array that is greater than  X.
             */

            Console.WriteLine("enter the size and the number of queries");
            string[] inputs = Console.ReadLine().Split();
            int size = int.Parse(inputs[0]);
            int noOfQuieries = int.Parse(inputs[1]);
            Console.WriteLine("please enter the array");
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
           

            for (int i=1; i<=noOfQuieries;i++)
            {
                    Console.WriteLine("please enter target");
                    int target = int.Parse(Console.ReadLine());

                    int result = CountGreaterThanX(arr, target);
                    Console.WriteLine(result);
                }





            #endregion

            #region Q5
            //List<int> inputList = new List<int>() { 1, 2, 3, 4, 4, 5, 5, 6, 7, 8, 8, 9 };
            //List<int> outputList = RemoveDuplicate(inputList);
            //Console.WriteLine("Input List: " + string.Join(", ", inputList));
            //Console.WriteLine("Output List after removing duplicates: " + string.Join(", ", outputList));
            #endregion

            #region Q6
            //ArrayList inputList = new ArrayList() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //foreach (var item in inputList)
            //{
            //    Console.Write(item + " ");
            //}
            //RemoveOdd(inputList);
            //Console.WriteLine("--------------------------------------------------");
            //foreach (var item in inputList)
            //{
            //    Console.Write(item + " ");
            //}
            #endregion

            #region Q7
            //Implement a queue that can hold different data types. 

            ////1- non-generic approach
            //Queue queue = new Queue();
            //queue.Enqueue(1);
            //queue.Enqueue("Apple");
            //queue.Enqueue(5.28);

            //foreach (var item in queue) Console.WriteLine(item);


            ////2- generic approach
            //Queue<object> genericQueue = new Queue<object>();
            //genericQueue.Enqueue(1);
            //genericQueue.Enqueue("Apple");
            //genericQueue.Enqueue(5.28);
            //foreach (var item in genericQueue) Console.WriteLine(item);
            #endregion

            #region Q11
            // Given a queue reverse first K elements of a queue, keeping the remaining elements in the same order 

            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Enqueue(5);
            //queue.Enqueue(6);
            //ReverseFirstKElements(queue, 3);
            //foreach (var item in queue) Console.WriteLine(item);

            #endregion
        }
    }
}

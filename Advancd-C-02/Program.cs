using System.Collections;

namespace Advancd_C_02
{
    internal class Program
    {
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
        static void Main(string[] args)
        {


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

            #region 7
            //Implement a queue that can hold different data types. 

            //1- non-generic approach
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue("Apple");
            queue.Enqueue(5.28);

            foreach (var item in queue) Console.WriteLine(item);


            //2- generic approach
            Queue<object> genericQueue = new Queue<object>();
            genericQueue.Enqueue(1);
            genericQueue.Enqueue("Apple");
            genericQueue.Enqueue(5.28);
            foreach (var item in genericQueue) Console.WriteLine(item);
            #endregion
        }
    }
}

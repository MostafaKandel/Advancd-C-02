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
        //public static int CountGreaterThanX(int[] arr, int x)
        //{
        //    int count = 0;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i] > x) count++;

        //    }
        //    return count;
        //}
        #endregion

        #region Q2
        //Given a number N and an array of N numbers. Determine if it's palindrome or not.
        //public static bool CheckPalindrome(int[] arr, int n)
        //{
        //    bool isPalindrome = true;
        //    for (int i = 0; i < n / 2; i++) {
        //        if (arr[i] != arr[n-1-i]) { isPalindrome = false; break; }
        //    }
        //    return isPalindrome;

        //}
        #endregion

        #region Q3
        // Given a Queue, implement a function to reverse the elements of a queue using a stack.
        //public static void ReverseQueue<T>(Queue<T> queue)
        //{
        //    // Queue= 1, 2, 3, 4, 5
        //    Stack<T> stack = new Stack<T>();

        //    while (queue.Count > 0)
        //    {
        //        // stack= 1, 2,3, 4, 5
        //        stack.Push(queue.Dequeue());
        //    }
        //    while (stack.Count > 0)
        //    {
        //        // Queue= 5, 4, 3, 2, 1
        //        queue.Enqueue(stack.Pop());
        //    }
        //}
        #endregion

        #region Q4
        //Given a Stack, implement a function to check if a string of parentheses is balanced using a stack.
        //public static bool IsBalanced(string input)
        //{
        //    Stack<char> stack= new Stack<char>();
        //    foreach (char ch in input)
        //    {
        //        if (ch == '(' || ch == '{' || ch == '[')
        //        {
        //            stack.Push(ch);
        //        }
        //        else if (ch == ')' || ch == '}' || ch == ']')
        //        {
        //            if (stack.Count == 0) return false;
        //            else
        //            {
        //                // to check what is the top element in the stack and remove it or pop it from stack
        //                char top = stack.Pop();
        //                if ((ch == ')' && top != '(') ||
        //                    (ch == '}' && top != '{') ||
        //                    (ch == ']' && top != '['))

        //                    return false;
        //            }

        //        }
        //    }
        //    return stack.Count == 0; // if stack is empty, parentheses are balanced and it will returned true

        //}

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

        #region Q8
        public static void SearchTargetInStack( int target)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(34);
            stack.Push(42);
            stack.Push(51);
            stack.Push(60);
            stack.Push(74);
            stack.Push(82);

            int count = 0;
            bool found = false;
            while (stack.Count > 0)
            {
                 
                    count++;
                    int current= stack.Pop();
                    if(current == target)
                    {
                        Console.WriteLine($"the target is found after {count} countes ");
                        found = true;
                        break;
                    }  
                
            }
            if (!found) Console.WriteLine("the target is not found");

        }
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

            //Console.WriteLine("enter the size and the number of queries");
            //string[] inputs = Console.ReadLine().Split();
            //int size = int.Parse(inputs[0]);
            //int noOfQuieries = int.Parse(inputs[1]);
            //Console.WriteLine("please enter the array");
            //int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();


            //for (int i=1; i<=noOfQuieries;i++)
            //{
            //        Console.WriteLine("please enter target");
            //        int target = int.Parse(Console.ReadLine());

            //        int result = CountGreaterThanX(arr, target);
            //        Console.WriteLine(result);
            //    }
            #endregion

            #region Q2

            //Console.WriteLine("please enter the size of the array");
            //int sizeOfArray = int.Parse(Console.ReadLine());
            //Console.WriteLine("please enter the array");
            //int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //bool isPalindrome = CheckPalindrome(arr, sizeOfArray);
            //if (isPalindrome)
            //    Console.WriteLine("The array is a palindrome");
            //else 
            //    Console.WriteLine("The array is not a palindrome");
            #endregion

            #region Q3
            //Queue<int> queue = new Queue<int>(new int[] { 1, 2, 3, 4, 5 });
            //Console.WriteLine("before reverse");
            //foreach (var item in queue) Console.WriteLine(item);
            //ReverseQueue<int>(queue);
            //Console.WriteLine("after reverse");
            //foreach (var item in queue) Console.WriteLine(item);
            #endregion

            #region Q4

            //string input1 = "[()]{}}";
            //Console.WriteLine(IsBalanced(input1)); //false
            //string input2 = "({[]})";
            //Console.WriteLine(IsBalanced(input2)); //true
            //string input3 = "(((])";
            //Console.WriteLine(IsBalanced(input3)); //false
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

            #region Q8

            SearchTargetInStack(42);
            SearchTargetInStack(100);

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

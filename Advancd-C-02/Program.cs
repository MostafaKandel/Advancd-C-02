namespace Advancd_C_02
{
    internal class Program
    {
        #region Q5
        //Given an array, implement a function to remove duplicate elements from an array.
        public static List<T> RemoveDuplicate<T>(List<T> inputList)
        {
            List<T> output = new List<T>();

            foreach (var item in inputList)
            {
                if (!output.Contains(item))
                {
                    output.Add(item);
                }
            }
            return output;
        }
        #endregion

        static void Main(string[] args)
        {


            #region Q5
            List<int> inputList = new List<int>() { 1, 2, 3, 4, 4, 5, 5, 6, 7, 8, 8, 9 };
            List<int> outputList = RemoveDuplicate(inputList);
            Console.WriteLine("Input List: " + string.Join(", ", inputList));
            Console.WriteLine("Output List after removing duplicates: " + string.Join(", ", outputList));
            #endregion

        }
    }
}

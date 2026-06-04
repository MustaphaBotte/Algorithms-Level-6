using Algorithms.Basic_Search;

namespace Algorithms
{
    public class Program
    {
        public static void LinearSearch()
        {
            int[] numbers = { 10,25,1,4,54,5,6545,45,15,0,-545 };
            int target = 5;
            int index = BasicSearch.LinearSearch(numbers, target); // O(N)
            Console.WriteLine($"Looking For Number {target} in : {string.Join(" ", numbers)}");

            if (index == -1)
                Console.WriteLine("Not Found");
            else
                Console.WriteLine($"Founded at index {index}");
        }
      
        public static void BinarySearch()
        {
            List<int> numbers = new List<int>(){ 10, 45, 87, 4, 2, 0, 45, -5, 4, 200 };
            numbers.Sort();
            int target = 200;
            int index = BasicSearch.BinarySearch(numbers, target); // O(log N)
            Console.WriteLine($"Looking For Number {target} in : {string.Join(" ", numbers)}");

            if (index == -1)
                Console.WriteLine("Not Found");
            else
                Console.WriteLine($"Founded at index {index}");
        }
        public static void Main(string[] args)
        {
            BinarySearch();
        }
    }
}

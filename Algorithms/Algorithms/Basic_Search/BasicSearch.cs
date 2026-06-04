using System.Collections;
using System.Globalization;

namespace Algorithms.Basic_Search
{

	public class BasicSearch
	{
		public static int LinearSearch(int[] numbers ,int target)
		{
		
			for (int i = 0; i < numbers.Length; i++)
			{
				if (numbers[i] == target)
				{				
					return i;
				}
			}
			return -1;
			
		}
        public static int BinarySearch<T>(List<T>sortedList, T target)
        {
			int start =0 , mid = 0;
			int end = sortedList.Count-1;

			var comparer = Comparer<T>.Default;
			while(start<=end)
			{
                mid = start + (end - start) / 2;

                int comparaison = comparer.Compare(target,sortedList[mid]);

                if (comparaison ==0)
                    return mid;

				if (comparaison < 0)
					end = mid - 1;

				if (comparaison > 0)
					start = mid + 1;


            }
			return -1;
        }
    }
  
}
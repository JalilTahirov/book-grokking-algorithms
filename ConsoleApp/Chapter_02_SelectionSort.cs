using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    public class Sorting
    {

        public int[] SelectionSort(List<int> arr)
        {
            int[] newArr = new int[arr.Count()];
            for(int i = 0; i<newArr.Count(); i++)
            {
                var indexSmallest = FindSmallest(arr);
                newArr[i] = arr[indexSmallest];
                arr.RemoveAt(indexSmallest);
            }
            return newArr;
        }

        


        private int FindSmallest(List<int> arr)
        {
            var smallest = arr[0];
            var smallestIndex = 0;

            for(int i = 0; i<arr.Count(); i++)
            {
                if(smallest > arr[i])
                {
                    smallest = arr[i];
                    smallestIndex = i;
                }  
            }
            return smallestIndex;
        }
    }
}
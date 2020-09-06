using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo2020
{
    public class SortingAlg
    {
       
        //Quick Sort
       public void QuickSort(int[] arr, int start, int end)
        {
            if (start >= end || start < 0 || end >= arr.Length)
                return;
            int pivot = start + (new Random().Next(end - start + 1));

            //int[] arr = new int[] { 3, 5, 92, 32, 10, 7, 8 };
            //int start = 0;
            //int end = arr.Length;
            //int pivot = arr[0];
            Tuple<int,int> lst = PartitionArray(arr, start, end, pivot);
            QuickSort(arr, start, lst.Item1);
            QuickSort(arr, lst.Item2, end);
        }

        public int[] quickSort(int[] a) 
        { if (a == null) 
                return a;
            QuickSort(a, 0, a.Length - 1); 
            return a; 
        }


        private Tuple<int,int> PartitionArray(int[] inputArray, int start,int end, int pivot)
        {
            int low = start - 1;
            int high = end + 1;
            int mid = start - 1;

            while (mid+1 < high)
            {
                if (inputArray[mid+1] > inputArray[pivot])
                {
                    Swap(inputArray, high - 1, mid + 1);
                    high--;
                }
                else if (inputArray[mid + 1] == inputArray[pivot])
                {
                    mid++;
                }
                else
                {
                    Swap(inputArray, mid + 1, low + 1);
                    mid++;
                    low++;
                }

            }

            return new Tuple<int, int>(low, high);
            
        }

        private void Swap(int[] inputArray, int v1, int v2)
        {
            throw new NotImplementedException();
        }
    }
}

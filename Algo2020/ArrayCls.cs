using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Algo2020
{
   public class ArrayCls
    {
        //Merge two sorted array 
        // arr1 = {1,3,5,7,9}
        // ar2 = {2,4,8,10,11,12,16}
        // This solution is O(n) time

        // We can also two merge first and then sort array. That will take o(logn) time

        public int[] MergeTwoSortedArray(int[] arr1, int[] arr2)
        {

            if (arr1 == null || arr1.Length == 0)
                return new int[0];

            int i=0, j=0, k = 0;
            //declare result array
            int[] resultArray = new int[arr1.Length + arr2.Length];

            while( i < arr1.Length && j < arr2.Length)
            {
                if (arr1[i] < arr2[j])
                {
                    resultArray[k] = arr1[i];
                    i++;
                    k++;
                }
                else
                {
                    resultArray[k] = arr2[j];
                    j++;
                    k++;
                }
            }

            // if arr2 goes out of bound
            // copy all the remaining element from arr1 to result array
            while (i < arr1.Length)
            {
                resultArray[k] = arr1[i];
                k++;
                i++;

                // resultArray[k++] = arr1[i++];
            }

            // if arr1 goes out of bound
            // copy all the remaining element from arr1 to result array
            while (j < arr2.Length)
            {
                resultArray[k] = arr2[j];
                k++;
                j++;
            }

            return resultArray;
        }

        // Remove duplicates from a sorted array
        //arr [1,1,2,3,4,5,5,6]
        //Extra speace
        public int[] RemoveDuplicateSortedArray(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                return null;

            int[] resultArray = new int[arr.Length];
            int j = 0;
            for (int i = 0; i < arr.Length-1; i++)
            {
                // compare the current element with next element
                if (arr[i] != arr[i + 1])
                {
                    resultArray[j++] = arr[i];
                }
            }
            resultArray[j] = arr[arr.Length - 1];
            return resultArray;
        }

        public int[] RemoveDuplicatesSortedArrayWES(int[] arr)
        {
            int index = 0;
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] != arr[i+1])
                {
                    arr[index++] = arr[i];                   
                }
              
            }
             //move last element
             arr[index] = arr[arr.Length - 1];
            return arr;
        }
           
        }

    }


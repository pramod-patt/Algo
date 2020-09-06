using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo2020
{
    class Program
    {
        static void Main(string[] args)
        {

            //----------------------Binary Search Tree --------------------------------------

            TreeNode bt = new TreeNode(75);
           // bt.Insert(75);
            bt.Insert(57);
            bt.Insert(98);
            bt.Insert(32);
            bt.Insert(7);

            bt.Search(32);

            int minResult = bt.FindMin();
            int maxResult = bt.FindMax();



            //----------------------Binary Search Tree --------------------------------------

            StringAlgo stralgo = new StringAlgo();
            string[] prefixes = new string[] { "cat", "catch", "Alabama" };
            string sentence = "The cats were catching yarn";

            string resString = stralgo.ReplaceSentenceWithPrefix(prefixes, sentence);

            string engWord = stralgo.IntergerToEnglishWords(0);

            List<Car> cr = new List<Car> {
                    new Car("Toyota"),
                   new Car("Honda"), 
                    new Car("Ford"), new Car("Subru")
            };

            cr.Sort();
            cr.ForEach(c => Console.WriteLine(c.Company + c.Rating));

            //string testStr = "RGB";
            //foreach (char c in testStr)
            //{
            //    Console.WriteLine((int)c);
            //}

            //for (int i = 0; i < testStr.Length; i++)
            //{
            //    Console.WriteLine(testStr[i]);
            //}

            fbq fb = new fbq();
            int[] ar = new int[] { 1, 2, 3, 4 };
            int[] prd = fb.ProductOfArrayExceptItself(ar);


            //uppercase lower case
            List<string> res3 = Recurssion.UpperCaseLowerCaseCombination("a1b2");


            // Merge two sorted Array
            ArrayCls ac = new ArrayCls();
            int[] arr1 = new int[] { 1, 3, 5, 7, 9 };
            int[] arr2 = new int[] { 2,4,8,10,11,12,16 };
            int[] resAry = ac.MergeTwoSortedArray(arr1, arr2);

            //Remove duplicates
            int[] arr3 = new int[] { 1, 3, 3, 9};
           // int[] remDup = ac.RemoveDuplicateSortedArray(arr3);
            int[] remDup1 = ac.RemoveDuplicatesSortedArrayWES(arr3);


            BinarySearch bs = new BinarySearch();
            string[] str1 = new string[] { "k", "v", "a", "b", "c", "d", "e", "g", "i" };
            int ceingingIndex = bs.FindRotationPoint(str1);

            int[] a1 = new int[] { 1, 2, 3, 4, 5 };
            string str = Recurssion.findNumber(a1, 1);
            //Linked kist
            LinkedList ls = new LinkedList();
            ls.CreateList();
            ls.DisplayList();
            ls.InsertatBegining(99);
            ls.DisplayList();

            //Print all permutations
            //int[] a = new int[] { 1, 2, 3, 4, 5 };
            //int[] buffer = new int[3];
            //Boolean[] isInBuffer = new Boolean[a.Length];
            //Recurssion.PrintPermutationsofSize(a, buffer, 0, isInBuffer);

            // ----------------------------------------------------
            int[] inputAry = new int[] { 1, 2, 3,4 };
            int[] bufAry = new int[2];
            Recurssion.CreateCombination(inputAry, bufAry, 0, 0);
           // ----------------------------------------
            int[] arrayEven = { 1, 2, 3, 4, 5, 6 };
            int resultCnt = CountEvinBuiltUp(arrayEven, 0);

            string result1 = LongestSubstringWithoutDuplication("whatwhywhere");

            int[] array = { 2, 3, 5, 8, 9, 1 };

            int result = SearchArray(array, 7);
        }

        public static int CountEvinBuiltUp(int[] arr, int i)
        {
            if (i >= arr.Length)
                return 0;
            int result = CountEvinBuiltUp(arr, i + 1);

            if (arr[i] % 2 == 0)
                result++;

            return result;

        }

        public static int SearchArray(int[] a , int target)
        {
            int start = 0, end = a.Length - 1, result = -1;

            while(start <= end)
            {
                int mid = start + (end - start) / 2;

                //if (result == -1)
                //    result = mid;
                //if (Math.Abs(a[mid] - target) < Math.Abs(a[result] - target))
                //{
                //    result = mid;
                //}

                result = GetCloseResult(a, mid, target, result);
                               
                if (a[mid] > target)
                {
                    end = mid - 1;
                }
                else if (a[mid] < target)
                {
                    start = mid + 1;
                }
                else
                {
                    return mid;
                }

            }

            return result;
        }

        private static int GetCloseResult(int[] a, int mid, int target, int result)
        {
            if (result == -1 || Math.Abs(a[mid]-target) < Math.Abs(a[result]-target))
                    return mid;

            return result;
        }


        public static string LongestSubstringWithoutDuplication(string str)
        {
            // Write your code here

            if (str.Length == 0)
                return "";

            int start = 0, end = 0;
            string result = string.Empty;
            Dictionary<char, int> lastseen = new Dictionary<char, int>();
            int[] longest = { 0, 1 };
            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];

                if (lastseen.ContainsKey(c))
                {
                    start = Math.Max(start, lastseen[c] + 1);
                }

                if (longest[1] - longest[0] < i + 1 - start)
                {
                    longest = new int[] { start, i + 1 };
                }
                lastseen[c] = i;

            }

            result = str.Substring(longest[0], longest[1] - longest[0]);
            return result;


        }


    }
}

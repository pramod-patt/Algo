using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo2020
{
    public static class Recurssion
    {
        /// <summary>
        /// intputAry = {1,2,3,4} find all combinations of an array of size x
        /// </summary>
        /// <param name="intputAry"></param>
        /// <param name="bufferAry"></param>
        public static void CreateCombination(int[] intputAry,int[] bufferAry, int startIndex, int bufferAryIndex)
        {
            // {1,2,3,4}
            // {1,2}{1,3}{1,4}{2,3}{2,4}{3,4}
            //define base condition
            if (bufferAryIndex == bufferAry.Length )
            {
                for (int i = 0; i < bufferAry.Length; i++)
                {
                    Console.WriteLine(bufferAry[i]);
                }

                Console.WriteLine("----------------------------");
                return;
            }                

            if (startIndex == intputAry.Length)
                return;

            // Recussion logic
            for (int i = startIndex; i < intputAry.Length; i++)
            {
                bufferAry[bufferAryIndex] = intputAry[i];

                CreateCombination(intputAry, bufferAry, i + 1, bufferAryIndex + 1);
            }            
        }

        public static void PrintPermutationsofSize(int[] a, int[] b, int bufferIndex, bool[] isInBuffer)
        {
            //base condition
            if (bufferIndex == b.Length)
            {
                for (int i = 0; i < b.Length; i++)
                {
                    Console.WriteLine(b[i]);
                }
                return;
            }


            for (int i = 0; i < a.Length; i++)
            {
                if (!isInBuffer[i])
                {
                    b[bufferIndex] = a[i];
                    isInBuffer[i] = true;
                    PrintPermutationsofSize(a, b, bufferIndex + 1, isInBuffer);
                    isInBuffer[i] = false;
                }
            }

        }

        public static string findNumber(int[] arr, int k)
        {
            string result = "NO";
            if (arr != null || arr.Length == 0)
                return result;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (k == arr[i])
                    result = "YES";
                break;
            }
            return result;
        }

        public static List<string> UpperCaseLowerCaseCombination(string input)
        {
            List<string> result = new List<string>();
          
            helperUpperCaseLowerCase(input, string.Empty,0, result);

            return result;

        }

        public static void helperUpperCaseLowerCase(string input, string slate, int index, List<string> result)
        {
            //base case
            if (index == input.Length)
            {
                result.Add(slate);
                return;
            }

            //recursive case

            if (char.IsNumber(input[index]))
            {
                helperUpperCaseLowerCase(input, slate + input[index], index +1, result);
            }
            else
            {
                helperUpperCaseLowerCase(input, slate + char.ToUpper(input[index]), index + 1, result);
                helperUpperCaseLowerCase(input, slate + char.ToLower(input[index]), index + 1, result);
            }

        }

        //public static List<string> SubsetOfArray(int[] inputArr)
        //{
        //    List<string> result = new List<string>();
        //    StringBuilder sb = new StringBuilder();
        //    HelperSubset(inputArr, sb, 0, result);


        //}

        private static void HelperSubset(int[] arr, StringBuilder sb, int index, List<string> result)
        {

            if (index == result.Count)
            {
                result.Add(sb.ToString());
                return;
            }


        }

        /// <summary>
        /// Given a collection of distict integers, return all permutations
        /// input : {1,2,3} 
        /// output : {1,2,3} {1,3,2}{2,1,3}{2,3,1}{3,1,2}{3,2,1}
        /// </summary>
        /// <param name="arr"></param>
        public static void PrintAllPermutations(int[] arr)
        {

        }

    }

}

   

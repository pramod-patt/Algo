using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo2020
{
   public class fbq
    {
        /// <summary>
        /// Product of array except self | Leetcode #238
        /// {1,2,3,4}
        /// {24, 12, 8,6}
        /// </summary>
        /// <returns></returns>
        public int[] ProductOfArrayExceptItself(int[] arr)
        {
            int[] resultAry = new int[arr.Length];
            if (arr.Length == 0 || arr == null)
                return null;

            for (int i = 0; i < arr.Length ; i++)
            {
                if (i > 0)
                {
                    resultAry[i] = arr[i] * arr[i - 1];
                }
                else
                {
                    resultAry[i] = arr[i];
                }
            }

            int rightPrdResult = 1;

            for (int i = arr.Length-1; i > 0 ; i--)
            {
                resultAry[i] = resultAry[i - 1] * rightPrdResult;
                rightPrdResult = rightPrdResult * arr[i];
            }

            resultAry[0] = rightPrdResult;

            return resultAry;

        }
        /// <summary>
        /// leftmost column with at least a one leetcode  #1428
        /// https://leetcode.com/problems/leftmost-column-with-at-least-a-one/
        /// </summary>
        /// <returns></returns>
        
   //* // This is BinaryMatrix's API interface.
   //* // You should not implement it, or speculate about its implementation
   //* class BinaryMatrix {
   //*     public int Get(int row, int col) {}
   //*     public IList<int> Dimensions() {}
   //* }
   

        
   //         public int LeftMostColumnWithOne(BinaryMatrix binaryMatrix)
   //         {

   //             //Get the dimension of the matrix
   //             IList<int> dim = binaryMatrix.Dimensions();

   //             int currentRow = 0;
   //             int row = dim[0];
   //             int col = dim[1];
   //             Console.WriteLine(row);
   //             int currentCol = col - 1;

   //             while (currentRow < row && currentCol >= 0)
   //             {

   //                 if (binaryMatrix.Get(currentRow, currentCol) == 0)
   //                 {
   //                     currentRow = currentRow + 1;
   //                 }
   //                 else
   //                 {
   //                     currentCol = currentCol - 1;
   //                 }
   //             }

   //             if (currentCol != col - 1)
   //             {
   //                 return currentCol + 1;
   //             }
   //             else
   //             {
   //                 return -1;
   //             }

   //         }
        

    }
}

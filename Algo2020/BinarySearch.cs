using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo2020
{
    public class BinarySearch
    {
        public int FindRotationPoint(string[] words)
        {
            string firstword = words[0];

            int floorIndex = 0;
            int ceilingIndex = words.Length - 1;

            while(floorIndex < ceilingIndex)
            {
                int guessIndex = floorIndex + (ceilingIndex - floorIndex) / 2;

                if (string.Compare(words[guessIndex], firstword, StringComparison.Ordinal) >= 0){
                    //go right
                    floorIndex = guessIndex;
                }
                else
                {
                    ceilingIndex = guessIndex;
                }

                if (floorIndex + 1 == ceilingIndex)
                {
                    // Between floor and ceiling is where we flipped to the beginning,
                    // so ceiling is alphabetically first
                    break;
                }
            }
            return ceilingIndex;
        }
    }
}

using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo2020
{
    public class StringAlgo
    {
        /// <summary>
        /// 08-25-2020
        /// Replace Words With Prefix
        /// </summary>
        /// Inputs:
        ///  prefixes = ["cat", "catch", "Alabama"]
       /// sentence = "The cats were catching yarn"
       ///  Output: "The cat were cat yarn"
       ///Explanation: "cats" and "catching" were both replaced by their shortest prefix match "cat"
        /// <param name="prefix"></param>
        /// <param name="sentence"></param>
        /// <returns></returns>
        public string ReplaceSentenceWithPrefix(string[] prefix, string sentence)
        {
            string result = string.Empty;
            string[] words = sentence.Split(' ');
            var dict = new Dictionary<string, bool>();

            for (int i = 0; i < prefix.Length; i++)
            {
                dict[prefix[i]] = true;
            }

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];

                for (int j = 0; j < word.Length; j++)
                {
                    if (dict.ContainsKey(word.Substring(0, j)))
                    {
                        words[i] = word.Substring(0, j);
                        break;
                    }
                }

            }
            result = string.Join(" ", words);
            return result;
        }

        /// <summary>
        /// Convert string to Int
        /// </summary>
        /// <returns></returns>
       //public int ConvertStingToInt()
       // {

       // }


        public string IntergerToEnglishWords(int num)
        {
            StringBuilder sb = new StringBuilder();

            if (num == 0)
                sb.Append("Zero");

            if (num > 0)
            {

                //Create string array to store word for the numbers
                //1. Unit 
                string[] unit = new string[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };

                //2. TENS
                string[] ten = new string[] { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

                if (num < 20)
                {
                    sb.Append(unit[num]);
                }
                else if (num >= 20 && num < 100)
                {
                    sb.Append(ten[num / 10] + " " + unit[num % 10]);
                }
                else if (num > 100 && num < 1000)
                {
                    sb.Append(unit[num / 100] + " " + "Hundred " + IntergerToEnglishWords(num % 100));
                }
            }

            return sb.ToString();
        }

    }
}

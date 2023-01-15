using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingTechniques
{
    public class PermutationOfStringUsingRecursiveApproach
    {
        public static void RecursiveApproach(String str, String answer)
        {
            if (str.Length == 0)
            {
                Console.Write(answer + "  ");
                return;
            }

            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                String left_substr = str.Substring(0, i);
                String right_substr = str.Substring(i + 1);
                String rest = left_substr + right_substr;
                RecursiveApproach(rest, answer + ch);
            }
        }
    }
}
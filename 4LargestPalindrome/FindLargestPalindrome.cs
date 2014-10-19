using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4LargestPalindrome
{
    class FindLargestPalindrome
    {
        static string str;
        static string results;
        IsPalindrome pal;

        public FindLargestPalindrome(string p)
        {
            // TODO: Complete member initialization
            str = p;
            results = "";
            pal = new IsPalindrome();
        }

        public string getResults()
        {
            string temp = str;
            for (int i = 0; i < str.Length - 1; i++)
            {
                for (int j = 2; j <= str.Length- i; j++)
                {
                    temp = str.Substring(i,j);
                    if (pal.isPalindrome(temp))
                    {
                        if (temp.Length > results.Length)
                        {
                            results = temp;
                        }
                    }
                }
            }

            return results;
        }
    }
}

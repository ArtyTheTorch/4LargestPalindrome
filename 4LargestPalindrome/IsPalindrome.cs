using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4LargestPalindrome
{
    class IsPalindrome
    {
        // Recursive method use to get the reverse of a string
        public string getReverse(string str)
        {
            if (str.Length < 2)
            {
                return str;
            }
            else
            {
                return getReverse(str.Substring(1)) + str[0];
            }
        }
        //recursively checks to see if a string is a plaindrome or not
        public bool isPalindrome(string str)
        {
            return str == this.getReverse(str);
        }
    }
}

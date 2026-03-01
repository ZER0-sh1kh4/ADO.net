using System;
using System.Collections.Generic;
using System.Text;

namespace Age.Feature
{
    public class age
    {
        public bool CheckAge(int a)
        {
            if (a % 2 == 0) return true; return false;
        }

        public int SumOf(int n)
        {
            return n * (n + 1) / 2;
        }
        public string ReverseString(string input)
        {
            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }

}

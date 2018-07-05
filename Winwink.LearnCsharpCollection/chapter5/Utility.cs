using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winwink.LearnCsharpCollection.chapter5
{
    public class Utility
    {
        public static bool IsPalindrome(string str)
        {
            CStack stack = new CStack();
            foreach(var c in str)
            {
                stack.Push(c);
            }

            for(int i=0;i<str.Length;i++)
            {
                var c = (char)stack.Pop();
                if(str[i]!=c)
                {
                    return false;
                }
            }

            return true;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winwink.LearnCsharpCollection.chapter5
{
    public class chapter5
    {
        public static void Main1()
        {
            while (true)
            {
                Console.WriteLine("Please enter a string");
               var s =  Console.ReadLine();
                var result = Utility.IsPalindrome(s);
                Console.WriteLine("Is Palindrome ? "+result.ToString());
            }

        }

        public static void Main2()
        {
            ArithMeticExpression expression = new ArithMeticExpression("10 + 5 - 6 * 7");
            var result = expression.Result();
            Console.WriteLine("Expression :" + "10 + 5 - 6 + 7" + ", Result:" + result);
        }
    }
}

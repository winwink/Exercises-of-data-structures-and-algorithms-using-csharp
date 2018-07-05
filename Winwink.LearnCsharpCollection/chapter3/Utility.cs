using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winwink.LearnCsharpCollection.chapter3
{
    public class Utility
    {
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            if (length < 0)
                throw new ArgumentOutOfRangeException("length", length, "length should not be less than 0");

            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public static int RandomInt(int max)
        {
            var result = (int)(random.NextDouble() * max);
            return result;
        }

        
    }
}

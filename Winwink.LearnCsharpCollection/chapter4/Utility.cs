using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winwink.LearnCsharpCollection.Common;

namespace Winwink.LearnCsharpCollection.chapter4
{
    public class Utility
    {
        private static Random random = new Random();

        public static string FilePath = Path.Combine(Environment.CurrentDirectory + "chapter4.txt");

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

        public static int[] BuildSortedArray(int max)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < max; i++)
            {
                list.Add(RandomInt(max));
            }
            list.Sort();
            return list.ToArray();
        }

        public static int SeqSearch(int[] arr, int sValue)
        {
            for (int index = 0; index < arr.Length - 1; index++)
            {
                if (arr[index] == sValue)
                {
                    return index;
                }
            }

            return -1;
        }

        public static void CreateRandomIntFile(int lineLength)
        {
            using (FileStream fs = new FileStream(FilePath, FileMode.Create))
            {
                StreamWriter sw = new StreamWriter(fs);
                for (int i = 0; i < lineLength; i++)
                {
                    sw.WriteLine(RandomInt(lineLength));
                }
            }
        }

        public static int FindMin(int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }

        public static int FindMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        public static int BinSearch(int[] sortedArr, int value)
        {
            int upperBound, lowerBound, mid;
            upperBound = sortedArr.Length - 1;
            lowerBound = 0;
            while (lowerBound <= upperBound)
            {
                mid = (upperBound + lowerBound) / 2;
                if (sortedArr[mid] == value)
                {
                    return mid;

                }
                else if (value < sortedArr[mid])
                {
                    upperBound = mid - 1;
                }
                else
                {
                    lowerBound = mid + 1;
                }
            }
            return -1;
        }

        public static int RBinSearch(int[] sortedArr, int sValue, int lower, int upper)
        {
            if (lower > upper)
            {
                return -1;
            }

            var mid = (upper + lower) / 2;
            if (sValue == sortedArr[mid])
            {
                return mid;
            }
            else if (sValue < sortedArr[mid])
            {
                return RBinSearch(sortedArr, sValue, lower, mid - 1);
            }
            else
            {
                return RBinSearch(sortedArr, sValue, mid + 1, upper);
            }
        }
    }
}

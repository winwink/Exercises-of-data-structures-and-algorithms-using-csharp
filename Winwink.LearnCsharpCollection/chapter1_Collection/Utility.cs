using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winwink.LearnCsharpCollection.chapter1_Collection
{
    public class Utility
    {
        public static void Swap<T>(ref T val1, ref T val2)
        {
            T temp;
            temp = val1;
            val1 = val2;
            val2 = temp;
        }

        public static void BuildArray(int[] arr)
        {
            for (int i = 0; i <= 99999; i++)
            {
                arr[i] = i;
            }
        }

        public static void DisplayNums(int[] arr)
        {
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }

    public class Student
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string ClassName { get; set; }
    }
}

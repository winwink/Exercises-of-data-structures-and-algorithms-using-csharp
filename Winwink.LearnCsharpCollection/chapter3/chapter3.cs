using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winwink.LearnCsharpCollection.chapter3
{
    public class chapter3
    {
        public static void Main1()
        {
            CArray nums = new CArray(20);
            for (int i = 0; i < 20; i++)
            {
                nums.Insert(Utility.RandomInt(50));
            }
            nums.DisplayElements();
        }

        public static void Main2_BubbleSort()
        {
            var arr = CArray.GetRandomArray(15, 50);
            arr.BubbleSort();
        }

        public static void Main3_SelectionSort()
        {
            var arr = CArray.GetRandomArray(15, 50);
            arr.SelectionSort();
        }

        public static void Main4_InsertionSort()
        {
            var arr = CArray.GetRandomArray(15, 50);
            arr.InsertionSort_2();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winwink.LearnCsharpCollection.chapter3
{
    public class CArray
    {
        private int[] arr;
        private int upper;
        private int numElements;
        public CArray()
        {

        }

        public CArray(int size)
        {
            arr = new int[size];
            upper = size - 1;
            numElements = 0;
        }

        //public int Count()
        //{
        //    return upper + 1;
        //}

        //public int this[int index]
        //{
        //    get
        //    {
        //        return arr[index];
        //    }
        //    set
        //    {
        //        arr[index] = value;
        //    }
        //}

        public void Insert(int item)
        {
            arr[numElements] = item;
            numElements++;
        }

        public void DisplayElements()
        {
            for (int i = 0; i <= upper; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        public void Clear()
        {
            for (int i = 0; i <= upper; i++)
            {
                arr[i] = 0;
            }
            numElements = 0;
        }

        public static CArray GetRandomArray(int count, int max)
        {
            CArray nums = new CArray(count);
            for (int i = 0; i < count; i++)
            {
                nums.Insert(Utility.RandomInt(max));
            }
            return nums;
        }

        /// <summary>
        /// 冒泡排序。每次循环，新增一个最大数字到末尾。尾部有序，且位置不会变化。
        /// </summary>
        public void BubbleSort()
        {
            for (int last = upper; last > 0; last--)
            {
                for (int j = 0; j + 1 <= last; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        var temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
                DisplayElements();
            }
        }

        /// <summary>
        /// 选择排序。每次循环，放一个最小的数字到首部。首部有序，则位置不会变化。
        /// </summary>
        public void SelectionSort()
        {
            int min, temp;
            for (int i = 0; i <= upper; i++)
            {
                min = i;
                for (int j = i + 1; j <= upper; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }

                if (min > i)
                {
                    temp = arr[min];
                    arr[min] = arr[i];
                    arr[i] = temp;
                }
                DisplayElements();
            }
        }

        /// <summary>
        /// 插入排序。插入前，保证前i位有序，根据新插入的值，位置会变化。
        /// </summary>
        public void InsertionSort_1()
        {
            for (int i = 1; i <= upper; i++)
            {
                int j = i;
                int temp = arr[i];
                while (j > 0 && arr[j - 1] > arr[j])
                {
                    arr[j] = arr[j - 1];
                    arr[j - 1] = temp;
                    j--;
                }
                arr[j] = temp;
                DisplayElements();
            }
        }

        public void InsertionSort_2()
        {
            for (int i = 1; i <= upper; i++)
            {
                int j = i;
                int temp = arr[i];
                while (j > 0 && arr[j - 1] > temp)
                {
                    arr[j] = arr[j - 1];
                    //相对于InsertionSort_1减少了交换次数
                    j--;
                }
                arr[j] = temp;
                DisplayElements();
            }
        }


    }
}

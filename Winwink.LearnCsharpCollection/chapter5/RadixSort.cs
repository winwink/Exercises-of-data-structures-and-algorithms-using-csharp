using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winwink.LearnCsharpCollection.chapter5
{
    public class RadixSort
    {
        private enum DigitType { ones = 1, tens = 10 }

        private static void DisplayArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
        }

        private static void RSort(Queue[] que, int[] arr, DigitType digit)
        {
            int snum;
            for (int i = 0; i < arr.Length; i++)
            {
                if (digit == DigitType.ones)
                {
                    snum = arr[i] % 10;
                }
                else
                {
                    snum = arr[i] / 10;
                }
                que[snum].Enqueue(arr[i]);
            }
        }

        private static void BuildArray(Queue[] que, int[] arr)
        {
            int index = 0;
            for (int i = 0; i <= 9; i++)
            {
                while (que[i].Count > 0)
                {
                    arr[index] = int.Parse(que[i].Dequeue().ToString());
                    index++;
                }
            }
        }

        public static void Main1()
        {
            Queue[] numQueue = new Queue[10];
            int[] nums = new int[] { 91, 46, 85, 15, 92, 35, 31, 22 };
            int[] random = new int[99];
            for(int i=0;i<10;i++)
            {
                numQueue[i] = new Queue();
            }

            RSort(numQueue, nums, DigitType.ones);
            BuildArray(numQueue, nums);
            Console.WriteLine("First pass results: ");
            DisplayArray(nums);

            RSort(numQueue, nums, DigitType.tens);
            BuildArray(numQueue, nums);
            Console.WriteLine("Secode pass results: ");
            DisplayArray(nums);
            

        }

    }
}

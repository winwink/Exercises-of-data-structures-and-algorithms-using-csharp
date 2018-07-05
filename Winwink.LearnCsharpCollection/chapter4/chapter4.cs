using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winwink.LearnCsharpCollection.Common;

namespace Winwink.LearnCsharpCollection.chapter4
{
    public class chapter4
    {
        public static void Main1()
        {
            var path = Utility.FilePath;
            var length = 5000000;
            Utility.CreateRandomIntFile(length);

            StreamReader sr = File.OpenText(path);
            int[] arr = new int[length];
            for(int i=0;i<length-1;i++)
            {
                arr[i] = Convert.ToInt32(sr.ReadLine(),10);
            }

            int searchNumber;
            
            while(true)
            {
                Console.WriteLine("Enter a number");
                searchNumber = Convert.ToInt32(Console.ReadLine());
                //ITiming timing = new StopWatchTiming();
                //timing.StartTime();
                //var index = Utility.SeqSearch(arr, searchNumber);
                //timing.StopTime();
                //Console.WriteLine("SeqSearch use time:" + timing.Result().TotalSeconds.ToString());

                ITiming timing = new StopWatchTiming();
                int index = -1;
                timing.ShowResult(() => index = Utility.SeqSearch(arr, searchNumber));
                if (index >= 0)
                {
                    Console.WriteLine("Found index:" + index);
                }
                else
                {
                    Console.WriteLine("Can not found");
                }
            }
        }

        public static void Main2()
        {
            var arr = Utility.BuildSortedArray(5000000);
            while(true)
            {
                Console.WriteLine("Enter a number");
                var searchNumber = Convert.ToInt32(Console.ReadLine());

                ITiming timing = new StopWatchTiming();
                int index = -1;
                timing.ShowResult(() => index = Utility.BinSearch(arr, searchNumber));
                if (index >= 0)
                {
                    Console.WriteLine("Found index:" + index);
                }
                else
                {
                    Console.WriteLine("Can not found");
                }
            }
        }
    }
}

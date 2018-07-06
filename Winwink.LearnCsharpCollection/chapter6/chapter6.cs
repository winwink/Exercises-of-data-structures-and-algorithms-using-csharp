using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winwink.LearnCsharpCollection.Common;

namespace Winwink.LearnCsharpCollection.chapter6
{
    public class chapter6
    {
        public static void Main1()
        {
            ITiming timing = new StopWatchTiming();
            timing.ShowResult(Main1Impl);//100000, 32s, no showPrimes
        }

        private static void Main1Impl()
        {
            int size = 100000;
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = 1;
            }

            Utility utility = new Utility();
            utility.GenPrimes(arr);
            //utility.ShowPrimes(arr);
        }
    }
}

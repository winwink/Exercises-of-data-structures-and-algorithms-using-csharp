using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winwink.LearnCsharpCollection.chapter6
{
    public class Utility
    {
        public void GenPrimes(int[] arr)
        {
            for (int outer = 2; outer < arr.Length; outer++)
            {
                for (int inner = outer + 1; inner < arr.Length; inner++)
                {
                    if (arr[inner] == 1)
                    {
                        if (inner % outer == 0)
                        {
                            arr[inner] = 0;
                        }
                    }
                }
            }
        }

        public void ShowPrimes(int[] arr)
        {
            for(int i=2;i<arr.Length;i++)
            {
                if(arr[i]==1)
                {
                    Console.WriteLine(i + " ");
                }
            }
        }
    }
}

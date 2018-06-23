using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winwink.LearnCsharpCollection.Common;

namespace Winwink.LearnCsharpCollection.chapter1_Collection
{
    public class chapter1
    {
        public static void Main1()
        {
            MyCollection names = new MyCollection();
            names.Add("David");
            names.Add("Bernica");
            names.Add("Raymond");
            names.Add("Clayton");
            foreach (Object name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Number of names: " + names.Count());

            names.Remove("Raymond");
            Console.WriteLine("Number of names: " + names.Count());

            names.Clear();
            Console.WriteLine("Number of names: " + names.Count());
        }

        public static void Main2()
        {
            int num1 = 100;
            int num2 = 200;
            Console.WriteLine("num1: " + num1);
            Console.WriteLine("num2: " + num2);
            Utility.Swap(ref num1, ref num2);
            Console.WriteLine("num1: " + num1);
            Console.WriteLine("num2: " + num2);

            string str1 = "Sam";
            string str2 = "Tom";
            Console.WriteLine("str1: " + str1);
            Console.WriteLine("str2: " + str2);
            Utility.Swap(ref str1, ref str2);
            Console.WriteLine("str1: " + str1);
            Console.WriteLine("str2: " + str2);

            Student s1 = new Student() { Name = "Xiao Wang", Age = 10 };
            Student s2 = new Student() { Name = "Xiao Ming", Age = 15 };
            Console.WriteLine("Student 1: " + s1.Name + ",Age: " + s1.Age);
            Console.WriteLine("Student 2: " + s2.Name + ",Age:" + s2.Age);
            Utility.Swap(ref s1, ref s2);
            Console.WriteLine("Student 1: " + s1.Name + ",Age: " + s1.Age);
            Console.WriteLine("Student 2: " + s2.Name + ",Age:" + s2.Age);
        }

        public static void Main3()
        {
            int[] nums = new int[100000];
            Utility.BuildArray(nums);
            TimeSpan startTime;
            TimeSpan duration;
            startTime = Process.GetCurrentProcess().Threads[0].UserProcessorTime;
            Utility.DisplayNums(nums);
            duration = Process.GetCurrentProcess().Threads[0].UserProcessorTime.Subtract(startTime);
            Console.WriteLine("Time: " + duration.TotalSeconds);
        }

        public static void Main4()
        {
            int[] nums = new int[100000];
            Utility.BuildArray(nums);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Utility.DisplayNums(nums);
            stopwatch.Stop();
            var duration = stopwatch.Elapsed;
            Console.WriteLine("Time: " + duration.TotalSeconds);
        }

        public static void Main5()
        {
            int[] nums = new int[100000];
            Utility.BuildArray(nums);
            Timing tObj = new Timing();
            tObj.StartTime();
            Utility.DisplayNums(nums);
            tObj.StopTime();
            Console.WriteLine("Time: " + tObj.Result().TotalSeconds);
        }
    }
}

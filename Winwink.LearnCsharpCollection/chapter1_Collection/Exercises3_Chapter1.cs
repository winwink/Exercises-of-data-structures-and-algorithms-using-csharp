using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Winwink.LearnCsharpCollection.Common;

namespace Winwink.LearnCsharpCollection.chapter1_Collection
{
    public class Exercises3_Chapter1
    {
        public static void ArrayListTest()
        {
            ArrayList list = new ArrayList();
            ITiming tObj = new StopWatchTiming();
            tObj.StartTime();
            Utility.BuildList(list);
            tObj.StopTime();
            Console.WriteLine(tObj.Result().TotalSeconds);
        }
        
        public static void MyCollectionTest()
        {
            MyCollection list = new MyCollection();
            ITiming tObj = new StopWatchTiming();
            tObj.StartTime();
            Utility.BuildList(list);
            tObj.StopTime();
            Console.WriteLine(tObj.Result().TotalSeconds);
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winwink.LearnCsharpCollection.chapter2
{
    public class Utility
    {
        public static void ShowArrayListAdd(ArrayList list, Object obj)
        {
            Console.WriteLine("before add, Capacity:" + list.Capacity+", Length:"+list.Count);
            list.Add(obj);
            Console.WriteLine("after add, Capacity:" + list.Capacity + ", Length:" + list.Count);
        }

        public static void ShowArrayListRemove(ArrayList list, Object obj)
        {
            Console.WriteLine("before remove, Capacity:" + list.Capacity + ", Length:" + list.Count);
            list.Remove(obj);
            Console.WriteLine("after remove, Capacity:" + list.Capacity + ", Length:" + list.Count);
        }
    }
}

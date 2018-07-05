using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winwink.LearnCsharpCollection.chapter2
{
    public class chapter2
    {
        public static void Main1()
        {
            string[] students = new string[5];
            students.SetValue("", 2);
            students.GetValue(2);

            var teachers = new string[4, 5];
            teachers[0, 0] = "";
            teachers.GetValue(4, 5);
            teachers.SetValue("", 4, 5);
        }

        public static void Main2()
        {
            ArrayList list = new ArrayList();
            for(int i=0;i<18;i++)
            {
                Utility.ShowArrayListAdd(list, i);
            }
            Console.WriteLine("----------------------------------");
            while(list.Count>0)
            {
                Utility.ShowArrayListRemove(list,list[0]);
            }
            list.TrimToSize();
            Console.WriteLine("After TrimToSize. Capacity:" + list.Capacity + ", Length:" + list.Count);

        }

        
    }
}

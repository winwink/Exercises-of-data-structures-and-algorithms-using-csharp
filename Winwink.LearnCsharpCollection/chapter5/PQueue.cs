using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winwink.LearnCsharpCollection.chapter5
{
    public class PQueue : Queue
    {
        public PQueue() : base()
        {
        }
        public override object Dequeue()
        {
            object[] items;
            int min, minindex = 0;
            items = this.ToArray();
            min = ((PqItem)items[0]).Priority;
            for (int i = 1; i <= items.GetUpperBound(0); i++)
            {
                if (((PqItem)items[0]).Priority < min)
                {
                    min = ((PqItem)items[i]).Priority;
                    minindex = i;
                }
            }
            this.Clear();
            for (int i = 0; i <= items.GetUpperBound(0); i++)
            {
                if (i != minindex && ((PqItem)items[i]).Name != "")
                {
                    this.Enqueue(items[i]);
                }
            }

            return items[minindex];
        }

    }

    public struct PqItem
    {
        public int Priority;
        public string Name;
    }
}

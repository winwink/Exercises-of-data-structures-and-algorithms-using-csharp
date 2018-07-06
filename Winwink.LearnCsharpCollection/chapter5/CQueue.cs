using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winwink.LearnCsharpCollection.chapter5
{
  public  class CQueue
    {
        private ArrayList _queue;

        public CQueue()
        {
            _queue = new ArrayList();
        }

        public void EnQueue(object obj)
        {
            _queue.Add(obj);
        }

        public object DeQueue()
        {
            var obj = _queue[0];
            _queue.RemoveAt(0);
            return obj;
        }

        public object Peek()
        {
            return _queue[0];
        }

        public void Clear()
        {
            _queue.Clear();
        }

        public int Count()
        {
            return _queue.Count;
        }
    }
}

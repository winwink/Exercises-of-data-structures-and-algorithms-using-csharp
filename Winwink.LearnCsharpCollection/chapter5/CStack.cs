using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winwink.LearnCsharpCollection.chapter5
{
   public class CStack
    {
        private int _index;
        private ArrayList _list;

        public CStack()
        {
            _index = -1;
            _list = new ArrayList();
        }

        public void Push(Object obj)
        {
            _list.Add(obj);
            _index++; 
        }

        public Object Pop()
        {
            var obj = _list[_index];
            _list.RemoveAt(_index);
            _index--;
            return obj;
        }

        public Object Peek()
        {
            return _list[_index];
        }

        public int Count
        {
            get
            {
                return _index + 1;
            }
        }

        public void Clear()
        {
            _list.Clear();
            _index = -1;
        }

        public Object[] ToArray()
        {
            Object[] newList=new Object[_index+1];
            _list.CopyTo(newList);
            return newList;
        }
    }
}

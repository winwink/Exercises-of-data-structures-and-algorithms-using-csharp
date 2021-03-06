﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winwink.LearnCsharpCollection.chapter1_Collection
{
    public class MyCollection : CollectionBase
    {
        public MyCollection()
        {

        }

        public MyCollection(int capacity):base(capacity)
        {
            
        }

        public void Add(Object item)
        {
            InnerList.Add(item);
        }

        public void Remove(Object item)
        {
            InnerList.Remove(item);
        }

        public new int Count()
        {
            return InnerList.Count;
        }

        public new void Clear()
        {
            InnerList.Clear();
        }

        public Object this[int index]
        {
            get
            {
                return InnerList[index];
            }
            set
            {
                InnerList[index] = value;
            }
        }

        public void Insert(int index, Object item)
        {
            InnerList.Insert(index, item);
        }

        public bool Contains(Object item)
        {
            return InnerList.Contains(item);
        }

        public int IndexOf(Object item)
        {
            return InnerList.IndexOf(item);
        }

        public new void RemoveAt(int index)
        {
            InnerList.RemoveAt(index);
        }
    }

}

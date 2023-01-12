using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Queues;
using Structures;

namespace MVCFrame
{
    class QueueArray<TItem> : IQueueable<TItem>
        where TItem : IComparable<TItem>
    {
        public QueueArray()
        {
            list = new List<PriorityQueue<TItem, BinarySearchTree<TItem>>>();
            for (int i = 0; i < process.maxPriority; i++)
                list.Add(new PriorityQueue<TItem, BinarySearchTree<TItem>>(new BinarySearchTree<TItem>()));
        }
        public TItem Item()
        {
            if (list[lowest_priority].Count != 0)
                return list[lowest_priority].Item();
            else
            {
                for (int i = 0; i < process.maxPriority; i++)
                {
                    if (list[i].Count != 0)
                    {
                        lowest_priority = i;
                        return list[lowest_priority].Item();
                    }
                }
            }
            return default(TItem);
        }
        public IQueueable<TItem> Put(TItem t)
        {
            if (list.Count == 0)
                lowest_priority = int.MaxValue;

            Process proc = t as Process;
            if (lowest_priority > proc.Priority)
                lowest_priority = proc.Priority;
            list[proc.Priority].Put(t);
            return this;
        }
        public IQueueable<TItem> Remove()
        {
            list[lowest_priority].Remove();
            return this;
        }
        public int Count 
        {
            get
            {
                int a = 0;
                foreach (var i in list)
                    a += i.Count;
                return a;
            }
            set { }
        }
        public IQueueable<TItem> Clear()
        {
            foreach (var i in list)
                i.Clear();
            lowest_priority = int.MaxValue;
            return this;
        }
        public TItem[] ToArray()
        {
            List<TItem> arr = new List<TItem>();
            foreach(var i in list)
            {
                foreach (var j in i.ToArray())
                    arr.Add(j);
            }
            return arr.ToArray();
        }
        private List<PriorityQueue<TItem, BinarySearchTree<TItem>>> list;
        private Process process = new Process();
        private int lowest_priority = int.MaxValue;
    }
}
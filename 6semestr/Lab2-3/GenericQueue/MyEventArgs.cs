using System;

namespace GenericQueue
{
    public class MyEventArgs<T> : EventArgs
    {
        public object[] Items { get; }
        
        public MyEventArgs(object[]items)
        {
            Items = items;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace KT29
{
    class Box<T> : IContainer<T>
    {
        private T item;

        public Box(T item)
        {
            this.item = item;
        }

        public T GetItem()
        {
            return item;
        }
    }
}

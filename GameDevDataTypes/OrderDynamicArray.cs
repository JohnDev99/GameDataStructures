using Dependencies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDevDataTypes
{
    internal class OrderDynamicArray : DynamicArray
    {
        public OrderDynamicArray() : base()
        {
        }

        public override void Add(int item)
        {
            if(items.Length == count)
            {
                Expand();
            }


        }

        public override int IndexOf(int item)
        {
            for(int i = 0; i < count; i++)
            {
                if (items[i] == item) return i;
            }
            return -1;
        }
        public override bool Remove(int item)
        {
            throw new NotImplementedException();
        }

        private void ShiftUp(int index)
        {
            //CCONTINUAR
        }

        private void ShiftDown(int index)
        {

        }
    }
}

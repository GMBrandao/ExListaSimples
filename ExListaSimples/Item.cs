using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExListaSimples
{
    internal class Item
    {
        public int Value { get; set; }
        public Item? Next { get; set; }
        
        public Item(int value)
        {
            Value = value;
            Next = null;
        }

        public override string ToString()
        {
            return "Item: " + Value + "\n";
        }
    }
}

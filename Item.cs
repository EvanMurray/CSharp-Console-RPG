using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myRpg
{
    class Item
    {
        public string Name { get; protected set; }
        private bool _isUsable;
        public int Quantity { get; set; } 


        public Item(string n, int q)
        {
            Name = n;
            Quantity = q;
        }

        public bool IsUsable()
        {
            return _isUsable;
        }
    }
}

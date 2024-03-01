using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_8
{
    internal class Item
    {
        private string name;
        public Item() { name = "Unknown"; }
        public Item(string name) { this.name = name; }
        public void SetName(string name) { this.name = name; }
        public string GetName() { return name; }
    }
}

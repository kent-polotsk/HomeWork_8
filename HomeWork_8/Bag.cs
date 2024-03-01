using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_8
{
    internal class Bag
    {
        private Item[] _item;
        private bool _isOpen = false;
        private int itemsCount = 0;

        protected internal Bag()
        { _item = new Item[8]; }
        protected internal Bag(string name)
        { _item = new Item[8]; }

        public void ShowFullness()
        {
            Console.WriteLine(_item.Length);
            Console.WriteLine(_item.LongLength);
            //Console.WriteLine(_item.GetLength());
        }

        public void OpenBag()
        {
            if (_isOpen == true) Console.WriteLine("Bag is already open");
            else
            {
                _isOpen = true;
                Console.WriteLine("Bag is opened");
            }
        }
        public void CloseBag()
        {
            if (_isOpen == false) Console.WriteLine("Bag is already closed");
            else
            {
                _isOpen = false;
                Console.WriteLine("Bag is closed");
            }
        }

        public void Print()
        {
            if (itemsCount == 0) Console.WriteLine("Bag is empty");
            else
            {
                for (int i = 0; i < _item.Length; i++)
                {
                    if (_item[i] != null) Console.Write("[" + (i+1) + "]"+_item[i].GetName() + "\t");
                }
                Console.WriteLine();
            }
        }

        public void AddItem(Item itemAdded)
        {
            if (_isOpen == false) Console.WriteLine("Bag is closed");
            else if (!_item.Contains(null)) Console.WriteLine("Bag is full");
            else if (itemAdded == null) Console.WriteLine("It's impossible to add null"); 
            else
            {
                for (int i = 0; i < 8; i++)
                    if (_item[i] == null)
                    {
                        _item[i] = itemAdded;
                        Console.WriteLine($"Item {itemAdded.GetName()} is added");
                        itemsCount++;
                        return;
                    }
            }

        }
        public void AddItem()
        {
            if (_isOpen == false) Console.WriteLine("Bag is closed");
            else if (!_item.Contains(null)) Console.WriteLine("Bag is full");
            else
            {
                Console.Write("Write item's name : ");
                //_bag.AddItem(new Item(Console.ReadLine()));
                for (int i = 0; i < 8; i++)
                    if (_item[i] == null)
                    {
                        _item[i] = new Item(Console.ReadLine());
                        Console.WriteLine($"Item {_item[i].GetName()} is added");
                        itemsCount++;
                        return;
                    }
            }

        }

        public Item ExtractItem()
        {
            int index = 0;
            if (_isOpen == false)
            {
                Console.WriteLine("Bag is closed");
                return null;
            }
            else if (itemsCount == 0) { Console.WriteLine("Bag is empty"); return null; }
            else
            {
                bool correct = false;
                string input;
                while (!correct)
                {
                    Console.Write("Enter extractable item index (1-8) : ");
                    input = Console.ReadLine();
                    if (int.TryParse(input, out int result))
                    {
                        if (result < 1 || result > 8) Console.WriteLine("Incorrect index, try again (from 1 to 8)");
                        else
                        {
                            index = result;
                            correct = true;
                        }
                    }
                    else Console.WriteLine("Incorrect input, try again");
                }
                if (_item[index - 1] == null)
                {
                    Console.WriteLine("This position [" + index + "] is empty");
                    return null;
                }
                else
                {
                    Item returnedItem = _item[index - 1];
                    _item[index - 1] = null;
                    itemsCount--;
                    return returnedItem;
                }
            }
        }
    }
}

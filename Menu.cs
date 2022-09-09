using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;
using System.Xml;


namespace Configurator
{
	internal class Menu
	{
        public delegate void PCDelegat();
        public SortedList<int, PCDelegat> _sortedEvents =
    new SortedList<int, PCDelegat>();

        public event PCDelegat eventPC
        {
            add
            {
                for (int key = 0; ;)
                {
                    if (!_sortedEvents.ContainsKey(key))
                    {
                        _sortedEvents.Add(key, value);
                        break;
                    }
                    key++;
                }
            }
            remove
            {
                _sortedEvents.RemoveAt(_sortedEvents.IndexOfValue(value));
            }
        }

        public void FillMenu(PC pc)
		{
            eventPC += pc.CreatePC;
            eventPC += pc.PCs;
            eventPC += pc.Components;
            eventPC += pc.Order;
           
		}

        public void PrintMenu()
        {
            WriteLine("1 - Create PC");
            WriteLine("2 - Ready PCs");
            WriteLine("3 - Components");
            WriteLine("4 - Orders");
            WriteLine("0 - Exit");
        }
	}
}


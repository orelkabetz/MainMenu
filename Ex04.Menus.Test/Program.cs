using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            DelegatesMenuGenerator delegatesMenu = new DelegatesMenuGenerator();
            delegatesMenu.Menu.Show();

            InterfaceMenuGenerator interfaceMenu = new InterfaceMenuGenerator();
            interfaceMenu.Menu.Show();
        }
    }
}

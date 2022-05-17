using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public static class Messages
    {
        public static void UserChoice()
        {
            Console.WriteLine("Please choose an option from the menu: ");
        }

        public static void PrintMenuItem(string i_Title, int i_ItemNumber)
        {
            Console.WriteLine("{0} -> {1}", i_ItemNumber, i_Title);
        }

        public static void PrintExitOrBack(bool i_IsSubMenu)
        {
            if (i_IsSubMenu)
            {
                Console.WriteLine("0 -> BACK");
            }
            else
            {
                Console.WriteLine("0 -> EXIT");
            }
        }

        public static void ByeBye()
        {
            Console.WriteLine("Thank you and Bye Bye!");
            PressAnyKey();
        }

        public static void PressAnyKey()
        {
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
    }
}

using System;

namespace Ex04.Menus.Interfaces
{
    public static class Messages
    {
        private const string k_OptionChoise = "Please choose an option from the menu: ";
        private const string k_ZeroArrowOne = "{0} -> {1}";
        private const string k_ZeroArrowBack = "0 -> BACK";
        private const string k_ZeroArrowExit = "0 -> EXIT";
        private const string k_ByeByeMessage = "Thank you and Bye Bye!";
        private const string k_PressAnyKey = "Press any key to continue";


        public static void UserChoice()
        {
            Console.WriteLine(k_OptionChoise);
        }

        public static void PrintMenuItem(string i_Title, int i_ItemNumber)
        {
            Console.WriteLine(k_ZeroArrowOne, i_ItemNumber, i_Title);
        }

        public static void PrintExitOrBack(bool i_IsSubMenu)
        {
            if (i_IsSubMenu)
            {
                Console.WriteLine(k_ZeroArrowBack);
            }
            else
            {
                Console.WriteLine(k_ZeroArrowExit);
            }
        }

        public static void ByeBye()
        {
            Console.WriteLine(k_ByeByeMessage);
            PressAnyKey();
        }

        public static void PressAnyKey()
        {
            Console.WriteLine(k_PressAnyKey);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class Menu : Item, IOptionObserver
    {
        private const int k_Exit = 0;
        private readonly List<Item> r_MenuItems;
        private const string k_FormatExceptionMassage = "Invalid input, Please enter an integer";
        private const string k_ArgumentOutOfRangeExceptionMassage = "Invalid Option";

        public Menu(string i_Title, MainMenu i_ParentObserver) : this(i_Title, i_ParentObserver.Menu)
        {
        }

        public Menu(string i_Title, IOptionObserver i_ParentObserver) : base(i_Title,i_ParentObserver)
        {
            r_MenuItems = new List<Item>(); 
        }
      

        void IOptionObserver.OnOptionChosen()
        {
            int userChoice = 0;
            bool quit = true;
            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine(Title);
                    DisplayItemsInMenu();
                    quit = getUserChoice(ref userChoice);

                    if (userChoice != k_Exit)
                    {
                        (r_MenuItems[userChoice - 1] as IOptionObserver).OnOptionChosen();
                    }
                }
                catch (Exception ex)
                { 
                    Console.WriteLine(ex.Message);
                    Messages.PressAnyKey();
                }

            } while (!quit);
        }

        public void AddItem(Item i_ItemToAdd)
        {
            r_MenuItems.Add(i_ItemToAdd);
        }

        private bool getUserChoice(ref int userChoice)
        {
            Messages.UserChoice();
            
            if (!Int32.TryParse(Console.ReadLine(), out userChoice))
            {
                throw new FormatException(k_FormatExceptionMassage);
            }
            if (userChoice < 0 || userChoice > r_MenuItems.Count)
            {
                throw new ArgumentOutOfRangeException(k_ArgumentOutOfRangeExceptionMassage);
            }
            return (userChoice == k_Exit);
        }

        private void DisplayItemsInMenu()
        {
            bool IsSubMenu;
            int ItemNumber = 1;

            foreach (Item item in r_MenuItems)
            {
                Messages.PrintMenuItem(item.Title, ItemNumber);
                ItemNumber++;
            }

            IsSubMenu = (r_OptionObserver != null);
            Messages.PrintExitOrBack(IsSubMenu);
        }
    }
}

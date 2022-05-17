using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class Menu : MenuItem, IOpstionObserver
    {
        private const int k_Exit = 0;
        private readonly List<MenuItem> r_MenuItems;

        public Menu(string i_Title, IOpstionObserver i_ParentObserver) : base(i_Title,i_ParentObserver)
        {
            r_MenuItems = new List<MenuItem>(); 
        }

        void IOpstionObserver.OnOptionChosen()
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
                        (r_MenuItems[userChoice - 1] as IOpstionObserver).OnOptionChosen();
                    }
                }
                catch (Exception ex)
                { 
                    Console.WriteLine(ex.Message);
                    Messages.PressAnyKey();
                }

            } while (!quit);
        }

        public void AddItem(MenuItem i_ItemToAdd)
        {
            r_MenuItems.Add(i_ItemToAdd);
        }

        private bool getUserChoice(ref int userChoice)
        {
            Messages.UserChoice();
            
            if (!Int32.TryParse(Console.ReadLine(), out userChoice))
            {
                throw new FormatException("Invalid input, Please enter an integer");
            }
            if (userChoice < 0 || userChoice > r_MenuItems.Count)
            {
                throw new ArgumentOutOfRangeException("Invalid Option");
            }
            return (userChoice == k_Exit);
        }

        private void DisplayItemsInMenu()
        {
            bool IsSubMenu;
            int ItemNumber = 1;

            foreach (MenuItem item in r_MenuItems)
            {
                Messages.PrintMenuItem(item.Title, ItemNumber);
            }

            IsSubMenu = (r_OptionObserver != null);
            Messages.PrintExitOrBack(IsSubMenu);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class Menu : Item
    {
        private const int k_Exit = 0;
        private readonly List<Item> r_MenuItems;

        public Menu(string i_Title) : base(i_Title)
        {
            r_MenuItems = new List<Item>();
        }

        public override void OnOptionChosen()
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
                        //(r_MenuItems[userChoice - 1] as IOptionObserver).OnOptionChosen();
                        r_MenuItems[userChoice - 1].OnOptionChosen();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Messages.PressAnyKey();
                }

            } while (!quit);
        }

        public void AddItem(Item i_ItemToAdd, bool i_IsSubm)
        {
            r_MenuItems.Add(i_ItemToAdd);

            if (i_ItemToAdd is Menu)
            {
                IsSubMenu = true;
            }
            else
            {
                IsSubMenu = false;
            }
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
            int ItemNumber = 1;

            foreach (Item item in r_MenuItems)
            {
                Messages.PrintMenuItem(item.Title, ItemNumber);
                ItemNumber++;
            }
            Messages.PrintExitOrBack(IsSubMenu);
        }
    }
}

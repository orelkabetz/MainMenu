using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class MainMenu
    {
        private readonly Menu r_MainMenu;

        public MainMenu(string i_Title)
        {
            r_MainMenu = new Menu(i_Title);
        }

        public Menu Menu
        { get { return r_MainMenu; } }

        public void AddItem(Item i_ItemToAdd, bool i_IsSubMenu)
        {
            r_MainMenu.AddItem(i_ItemToAdd, i_IsSubMenu);
            if (i_ItemToAdd is Menu)
            {
                r_MainMenu.IsSubMenu = true;
            }
            else
            {
                r_MainMenu.IsSubMenu = false;
            }
        }

        public void Show()
        {
            Console.WriteLine(this);
            r_MainMenu.OnOptionChosen();
            Messages.ByeBye();
        }
    }
}

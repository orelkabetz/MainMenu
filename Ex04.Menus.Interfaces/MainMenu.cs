using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        private readonly Menu r_MainMenu;
        public MainMenu(Menu i_Menu)
        {
            r_MainMenu = i_Menu;   
        }
        public string Title
        { 
            get { return r_Title; } 
        }

        public void AddItem(MenuItem i_ItemToAdd)
        {
            r_MainMenu.AddItem(i_ItemToAdd);
        }
    }
}

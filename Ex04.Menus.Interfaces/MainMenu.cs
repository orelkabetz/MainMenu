using System;
namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        private readonly Menu r_MainMenu;
        public MainMenu(string i_Title)
        {
            r_MainMenu = new Menu(i_Title, this);
        }

        public Menu Menu
        { get { return r_MainMenu; } }

        public void AddItem(Item i_ItemToAdd)
        {
            r_MainMenu.AddItem(i_ItemToAdd);
        }

        public void Show()
        {
            Console.WriteLine(this);
            (r_MainMenu as IOptionObserver).OnOptionChosen();
            Messages.ByeBye();
        }
    }
}

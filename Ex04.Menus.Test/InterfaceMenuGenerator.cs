using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class InterfaceMenuGenerator
    {
        private MainMenu m_Menu;
        public InterfaceMenuGenerator()
        {
            m_Menu = new MainMenu("Interface Menu");
            Menu dateTimeMenu = new Menu("Show Date/Time", m_Menu);
            Menu versionMenu = new Menu("Version and Spaces", m_Menu);

            m_Menu.AddItem(dateTimeMenu);
            m_Menu.AddItem(versionMenu);


            ActionItem showTime = new ActionItem("Show Time", new ShowTime());
            ActionItem showDate = new ActionItem("Show Date", new ShowDate());
            dateTimeMenu.AddItem(showTime);
            dateTimeMenu.AddItem(showDate);

            ActionItem countSpaces = new ActionItem("Count Spaces", new CountSpaces());
            ActionItem showVersion = new ActionItem("Show Version", new ShowVersion());

            versionMenu.AddItem(countSpaces);
            versionMenu.AddItem(showVersion);
            
        }
        public MainMenu Menu
        {
            get { return m_Menu; }
        }
    }
}

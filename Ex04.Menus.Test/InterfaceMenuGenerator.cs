using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class InterfaceMenuGenerator
    {
        private const string k_InterfaceMenu = "**Interface Main Menu**";
        private const string k_DateTime = "Show Date/Time";
        private const string k_VersionAndSpaces = "Version and Spaces";
        private const string k_ShowTime = "Show Time";
        private const string k_ShowDate = "Show Date";
        private const string k_ShowVersion = "Show Version";
        private const string k_CountSpaces = "Count Spaces";
        private MainMenu m_Menu;

        public InterfaceMenuGenerator()
        {
            m_Menu = new MainMenu(k_InterfaceMenu);
            Menu dateTimeMenu = new Menu(k_DateTime, m_Menu);
            Menu versionMenu = new Menu(k_VersionAndSpaces, m_Menu);
            ActionItem showTime = new ActionItem(k_ShowTime, new ShowTime());
            ActionItem showDate = new ActionItem(k_ShowDate, new ShowDate());
            ActionItem countSpaces = new ActionItem(k_CountSpaces, new CountSpaces());
            ActionItem showVersion = new ActionItem(k_ShowVersion, new ShowVersion());
            dateTimeMenu.AddItem(showTime);
            dateTimeMenu.AddItem(showDate);
            versionMenu.AddItem(countSpaces);
            versionMenu.AddItem(showVersion);
            m_Menu.AddItem(dateTimeMenu);
            m_Menu.AddItem(versionMenu);

        }
        public MainMenu Menu
        {
            get { return m_Menu; }
        }
    }
}

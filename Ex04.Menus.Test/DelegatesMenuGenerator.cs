using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    public class DelegatesMenuGenerator
    {
        private MainMenu m_Menu;
        private const string k_DelegatesMenu = "**Delegates Main Menu**";
        private const string k_DateTime = "Show Date/Time";
        private const string k_VersionAndSpaces = "Version and Spaces";
        private const string k_ShowTime = "Show Time";
        private const string k_ShowDate = "Show Date";
        private const string k_ShowVersion = "Show Version";
        private const string k_CountSpaces = "Count Spaces";
        public DelegatesMenuGenerator()
        {
            ShowTime showTime1 = new ShowTime();
            ShowDate showDate1 = new ShowDate();
            ShowVersion showVersion1 = new ShowVersion();
            CountSpaces countSpaces1 = new CountSpaces();
            bool subMenu = true;

            m_Menu = new MainMenu(k_DelegatesMenu);
            Menu dateTimeMenu = new Menu(k_DateTime);
            Menu versionMenu = new Menu(k_VersionAndSpaces);

            m_Menu.AddItem(dateTimeMenu, subMenu);
            m_Menu.AddItem(versionMenu, subMenu);

            ActionItem showTime = new ActionItem(k_ShowTime);
            ActionItem showDate = new ActionItem(k_ShowDate);
            showTime.AttachObserver(new OptionObserverDelegate(showTime1.OnOptionChosen));
            showDate.AttachObserver(new OptionObserverDelegate(showDate1.OnOptionChosen));

            dateTimeMenu.AddItem(showTime, !subMenu);
            dateTimeMenu.AddItem(showDate, !subMenu);

            ActionItem countSpaces = new ActionItem(k_CountSpaces);
            ActionItem showVersion = new ActionItem(k_ShowVersion);
            countSpaces.AttachObserver(new OptionObserverDelegate(countSpaces1.OnOptionChosen));
            showVersion.AttachObserver(new OptionObserverDelegate(showVersion1.OnOptionChosen));

            versionMenu.AddItem(countSpaces, !subMenu);
            versionMenu.AddItem(showVersion, !subMenu);

        }
        public MainMenu Menu
        {
            get { return m_Menu; }
        }
    }
    
}

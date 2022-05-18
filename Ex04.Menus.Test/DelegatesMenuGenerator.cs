using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    public class DelegatesMenuGenerator
    {
        private MainMenu m_Menu;

        public DelegatesMenuGenerator()
        {
            ShowTime showTime1 = new ShowTime();
            ShowDate showDate1 = new ShowDate();
            ShowVersion showVersion1 = new ShowVersion();
            CountSpaces countSpaces1 = new CountSpaces();
            bool subMenu = true;

            m_Menu = new MainMenu("**Delegates Main Menu**");
            Menu dateTimeMenu = new Menu("Show Date/Time");
            Menu versionMenu = new Menu("Version and Spaces");

            m_Menu.AddItem(dateTimeMenu, subMenu);
            m_Menu.AddItem(versionMenu, subMenu);

            ActionItem showTime = new ActionItem("Show Time");
            ActionItem showDate = new ActionItem("Show Date");
            showTime.AttachObserver(new OptionObserverDelegate(showTime1.OnOptionChosen));
            showDate.AttachObserver(new OptionObserverDelegate(showDate1.OnOptionChosen));

            dateTimeMenu.AddItem(showTime, !subMenu);
            dateTimeMenu.AddItem(showDate, !subMenu);

            ActionItem countSpaces = new ActionItem("Count Spaces");
            ActionItem showVersion = new ActionItem("Show Version");
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

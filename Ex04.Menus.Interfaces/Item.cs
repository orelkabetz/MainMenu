namespace Ex04.Menus.Interfaces
{
    public interface IOptionObserver
    {
        void OnOptionChosen();
    }
    public abstract class Item
    {
        private readonly string r_title;
        protected readonly IOptionObserver r_OptionObserver;
        public Item(string i_Title, IOptionObserver i_OptionObserver)
        {
            r_title = i_Title;
            r_OptionObserver = i_OptionObserver;
        }
        public string Title
        {
            get { return r_title; }
        }
    }
}

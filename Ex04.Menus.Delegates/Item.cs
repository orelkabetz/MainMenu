using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public delegate void OptionObserverDelegate();
    public abstract class Item
    {
        private readonly string r_title;
        public OptionObserverDelegate m_OptionObserverDelegate;
        private bool m_IsSubMenu;
        
        public Item(string i_Title)
        {
            r_title = i_Title;
        }
        public string Title
        {
            get { return r_title; }
        }

        public bool IsSubMenu
        {
            get { return m_IsSubMenu; }
            set { m_IsSubMenu = value; }
        }

        public void AttachObserver(OptionObserverDelegate i_OptionObserverDelegate)
        {
            m_OptionObserverDelegate = i_OptionObserverDelegate;
        }
        public virtual void OnOptionChosen() { }
    }
}

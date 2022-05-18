using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class ActionItem : Item
    {
        public ActionItem(string i_Title) : base(i_Title) { }

        public override void OnOptionChosen()
        {
            if (m_OptionObserverDelegate != null)
            {
                Console.Clear();
                m_OptionObserverDelegate.Invoke();
                Messages.PressAnyKey();
            }
        }
    }
}

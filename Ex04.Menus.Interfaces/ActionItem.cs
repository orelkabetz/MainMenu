using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class ActionItem : Item, IOptionObserver
    {
        public ActionItem(string i_Title, IOptionObserver i_observer) : base(i_Title, i_observer) { }

        void IOptionObserver.OnOptionChosen()
        {
            Console.Clear();
            r_OptionObserver.OnOptionChosen();
            Messages.PressAnyKey();
        }
    }
}

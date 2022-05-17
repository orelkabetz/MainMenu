using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public interface IOpstionObserver
    {
        void OnOptionChosen();
    }
    public abstract class MenuItem
    {
        private readonly string r_title;
        protected readonly IOpstionObserver r_OptionObserver;
        public MenuItem(string i_Title, IOpstionObserver i_OptionObserver)
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

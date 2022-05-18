using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowDate : IOptionObserver
    {
        private const string k_Today = "Today is:";
        private const string k_CurrentDate = " and the current date is:";
        void IOptionObserver.OnOptionChosen()
        {
            Console.WriteLine("{0} {1} ,{2} {3}/{4}/{5}", k_Today, k_CurrentDate, DateTime.Now.DayOfWeek, DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
        }
        public void OnOptionChosen()
        {
            Console.WriteLine("{0} {1} ,{2} {3}/{4}/{5}", k_Today, k_CurrentDate, DateTime.Now.DayOfWeek, DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
        }
    }
}

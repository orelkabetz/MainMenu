using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowDate : IOptionObserver
    {
        void IOptionObserver.OnOptionChosen()
        {
            Console.WriteLine("Today is: {0} , and the current date is: {1}/{2}/{3}"
                , DateTime.Now.DayOfWeek ,DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
        }
    }
}

using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowTime : IOptionObserver
    {
        void IOptionObserver.OnOptionChosen()
        {
            Console.WriteLine("The current time is: {0}:{1}:{2}", DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
        }
    }
}

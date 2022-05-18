using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowTime : IOptionObserver
    {
        private const string k_CurrentTime = "The current time is: ";

        void IOptionObserver.OnOptionChosen()
        {
            Console.WriteLine("{0} {1}:{2}:{3}", k_CurrentTime, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
        }
        public void OnOptionChosen()
        {
            Console.WriteLine("{0} {1}:{2}:{3}", k_CurrentTime, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
        }
    }
}

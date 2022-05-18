using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowVersion : IOptionObserver
    {
        private const string k_Version = "22.2.4.8950";
        void IOptionObserver.OnOptionChosen()
        {
            Console.WriteLine(k_Version);
        }
        public void OnOptionChosen()
        {
            Console.WriteLine(k_Version);
        }
    }
}

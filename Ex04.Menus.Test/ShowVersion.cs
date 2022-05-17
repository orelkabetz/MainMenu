using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowVersion : IOptionObserver
    {
        void IOptionObserver.OnOptionChosen()
        {
            Version version = new Version();
            Console.WriteLine(version.ToString());
        }
    }
}

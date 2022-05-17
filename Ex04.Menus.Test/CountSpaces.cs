using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class CountSpaces : IOptionObserver
    {
        void IOptionObserver.OnOptionChosen()
        {
            Console.WriteLine("Please enter a sentence you would like to count spaces in: ");
            string sentence = Console.ReadLine();
            int count = sentence.Split(' ').Length - 1;
            Console.WriteLine("The number of spaces in the sentence is: {0}", count);
        }
    }
}

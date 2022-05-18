using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class CountSpaces : IOptionObserver
    {
        private const string k_CountSpacesIntroMessage = "Please enter a sentence you would like to count spaces in: ";
        private const string k_NumOfSpaces = "The number of spaces in the sentence is: ";
        void IOptionObserver.OnOptionChosen()
        {
            Console.WriteLine(k_CountSpacesIntroMessage);
            string sentence = Console.ReadLine();
            int count = sentence.Split(' ').Length - 1;
            Console.WriteLine(k_NumOfSpaces + count);
        }
        public void OnOptionChosen()
        {
            Console.WriteLine(k_CountSpacesIntroMessage);
            string sentence = Console.ReadLine();
            int count = sentence.Split(' ').Length - 1;
            Console.WriteLine(k_NumOfSpaces + count);
        }
    }
}

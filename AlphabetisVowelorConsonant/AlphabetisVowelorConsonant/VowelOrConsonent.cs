﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphabetisVowelorConsonant
{
    internal class VowelOrConsonant
    {
        public static void DisplayVowelOrConsonant() 
        {
            char ch;

            Console.WriteLine("Enter an alphabet: ");
            ch = Convert.ToChar(Console.ReadLine());

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' ||
                ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine("The entered alphabet is a vowel.");
            }
            else
            {
                Console.WriteLine("The entered alphabet is a consonant.");
            }
        }
    }
}

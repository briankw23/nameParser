﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NameParser.Names
{
    class MiddleName
    {
        public string Name { get; private set; } = "";

        public void GetName( string firstName)
        {

            var middleName = "";
            if (ConfirmMiddleName())
            {
                Console.WriteLine("What is it");
                Name = Console.ReadLine();

            }
            else
            {
                Console.WriteLine($"{firstName}, die.");
            }
  
        }

        bool ConfirmMiddleName()
        {
            Console.WriteLine("Do you have a middle name? (y/n)");

            var hasMiddleName = Console.ReadLine();

            return hasMiddleName == "y";
        }
        public void PrintName()
        {
            var i = 0;

            foreach (var letter in Name)
            {
                Console.WriteLine(letter.ToString().PadLeft(++i));
            }
        }
    }
}

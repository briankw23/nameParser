﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NameParser.Names
{
    class FirstName
    {
        public string Name { get; private set; }

        public void GetFirstName()
        {
            Console.WriteLine("Enter your first name");
            Name = Console.ReadLine();
        }

        public void PrintName()
        {
            foreach (var letter in Name)
            {
                Console.WriteLine(letter);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace NameParser.Names
{
    class MiddleName : NameBase
    {
        private readonly FirstName _firstName;


        public MiddleName(FirstName firstName) : base("middle")
        {
            Name = "";
            _firstName = firstName;
        }

        

        public override void GetName()
        {
            if (ConfirmMiddleName())
            {
                base.GetName();
           
            }
            else
            {
                Console.WriteLine($"{_firstName.Name}, die.");
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

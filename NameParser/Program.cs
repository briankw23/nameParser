using System;
using NameParser.Names;

namespace NameParser
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = new FirstName();
            firstName.GetName();
            firstName.PrintName();

            var lastName = new LastName();
            lastName.GetName();
            lastName.PrintName();

            var middleName = new MiddleName(firstName);
            middleName.GetName();
            middleName.PrintName();

            Console.WriteLine($"Goodbye, {firstName.Name} {middleName.Name} {lastName.Name}. Press enter to exit");
            Console.ReadLine();
        }
    }
}

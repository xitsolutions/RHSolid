using System;

namespace OOPAddressBook
{
    internal class Person:Thing
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public string Phone { get; set; }

        public override bool Display()
        {
            Console.WriteLine($"First Name: {FirstName}\n" +
                              $"Last Name: {LastName}\n" +
                              $"Email: {Email}\n");
            return true;
        }
    }
}

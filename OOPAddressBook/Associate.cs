using System;

namespace OOPAddressBook
{
    internal class Associate:Person
    {
        public AssociateType Type { get; set; }
        public override bool Display()
        {
            
            Console.WriteLine($"Type: {Type.ToString()}");
            base.Display();

            return true;
        }
    }
}

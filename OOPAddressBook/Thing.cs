using System;

namespace OOPAddressBook
{
    abstract class Thing:IDisplayable
    {
        public virtual bool Display()
        {
            Console.WriteLine("I am a thing");
            return true;
        }
    }
}

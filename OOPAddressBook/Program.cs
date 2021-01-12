using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<IDisplayable>
            {
                new Person() {FirstName = "Barb", LastName = "Bher", Email = "bard@asdf.com"},
                new Person() {FirstName = "Rachel", LastName = "Hicken", Email = "rachel@owiuei.com"},
                new Associate() {FirstName = "Joe", LastName = "Biden", Email = "Jb@whitehouse.gov", Type= AssociateType.Colleague},
                new Associate() {FirstName = "Josh", LastName = "Smart", Email = "blah@whitehouse.gov", Type = AssociateType.Friend},
            };

            DisplayPeople(people);
        }

        private static void DisplayPeople(IEnumerable<IDisplayable> things)
        {
            things.All(o=>o.Display());
        }
    }
}
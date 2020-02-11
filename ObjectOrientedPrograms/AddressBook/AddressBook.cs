using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms
{
    class AddressBook
    {
      
        public class Person
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public List<Address> address { get; set; }
        }

        public class RootObject
        {
            public List<Person> Person { get; set; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms
{
    class AddressBook
    {
        public static void PersonDetails()
        {

            try
            {

                string json = @"C:\Users\BridgeLabz\source\repos\ObjectOrientedPrograms\AddressBooks\AddressBook.json";
                String jsonfiletext = SerializationAndDeserializationOfAdressBook.ReadFile(json);
                Model1 modeldata = SerializationAndDeserializationOfAdressBook.Deserializing(jsonfiletext);
                SerializationAndDeserializationOfAdressBook.Display(modeldata);
                AddressBookOptions ab = new AddressBookOptions();
                ab.addressBookOptions(modeldata);
                SerializationAndDeserializationOfAdressBook.Serializing(modeldata,json);
                SerializationAndDeserializationOfAdressBook.Display(modeldata);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }
        }
    }
}

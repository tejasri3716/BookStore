// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AddressBook.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace ObjectOrientedPrograms
{
    using System;

    class AddressBook
    {
        public static void PersonDetails()
        {

            try
            {

                string json = @"C:\Users\BridgeLabz\source\repos\ObjectOrientedPrograms\AddressBooks\AddressBook.json";
                String jsonfiletext = SerializationAndDeserializationOfAdressBook.ReadFile(json);
                ModelClass modeldata = SerializationAndDeserializationOfAdressBook.Deserializing(jsonfiletext);
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

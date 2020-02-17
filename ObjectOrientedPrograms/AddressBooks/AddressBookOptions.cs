// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AddressBookOptions.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace ObjectOrientedPrograms
{
    using System;

    class AddressBookOptions
    {
        public  void addressBookOptions(Model1 modeldata)
        {
            Console.WriteLine("1.Adding a Person Details ");
            Console.WriteLine("2.Removing a Person Details");
            Console.WriteLine("3.Update a Person Details");
            Console.WriteLine("enter any option to get executed");
            int option = Utility.readInt();
            switch (option)
            {
                case 1:
                    SerializationAndDeserializationOfAdressBook.AddPerson(modeldata);
                    break;
                case 2:
                    SerializationAndDeserializationOfAdressBook.RemovePerson(modeldata);
                    break;
                case 3:
                    SerializationAndDeserializationOfAdressBook.UpdatePerson(modeldata);
                    break;
                default:
                    Console.WriteLine("enter correct option");
                    break;
            }
        }
    }
}

// --------------------------------------------------------------------------------------------------------------------
// <copyright file=SerializationAndDeserializationOfAdressBook.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace ObjectOrientedPrograms
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;

    class SerializationAndDeserializationOfAdressBook
    {
        /// <summary>
        /// Reads the file.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns></returns>
        public static string ReadFile(string path)
        {
            string jsonfile = "";
            try
            {
                jsonfile = File.ReadAllText(path);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return jsonfile;
        }
        /// <summary>
        /// Deserializings the specified jsonfile.
        /// </summary>
        /// <param name="Jsonfile">The jsonfile.</param>
        /// <returns></returns>
        public static Model1 Deserializing(string Jsonfile)
        {
            Model1 file = null;
            try
            {
                file = JsonConvert.DeserializeObject<Model1>(Jsonfile);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return file;
        }
        /// <summary>
        /// Displays the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        public static void Display(Model1 model)
        {
            try
            {
                List<Person> list = model.Person;
                Console.WriteLine("FirstName\tLastName\tAddress\t\t\tCity\t\t\tState\t\t\tZip\t\tPhoneNumber");
                if (model != null)
                {
                    foreach (var info in list)
                    {
                        Console.WriteLine(info.FirstName + "\t\t" + info.LastName + "\t\t" + info.Address + "\t\t" + info.City + "\t\t" + info.State + "\t\t" + info.Zip + "\t\t" + info.PhoneNumber);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        /// <summary>
        /// Adds the person.
        /// </summary>
        /// <param name="modelinfo">The modelinfo.</param>
        public static void AddPerson(Model1 modelinfo)
        {
            List<Person> people = modelinfo.Person;
            Person person = new Person();
            Console.WriteLine("enter Person Details To Get Added to the file");
            Console.WriteLine("enter First Name");
            person.FirstName = Utility.readString();
            Console.WriteLine("enter Last Name");
            person.LastName = Utility.readString();
            Console.WriteLine("enter house number");
            person.Address = Utility.readString();
            Console.WriteLine("enter City");
            person.City = Utility.readString();
            Console.WriteLine("enter state");
            person.State = Utility.readString();
            Console.WriteLine("enter Zip Code");
            person.Zip = Utility.readInt();
            Console.WriteLine("enter Phone Number");
            person.PhoneNumber = Utility.readLong();
            people.Add(person);
            //modelinfo.Person = people;
        }
        /// <summary>
        /// Removes the person.
        /// </summary>
        /// <param name="modelinfo">The modelinfo.</param>
        public static void RemovePerson(Model1 modelinfo)
        {
            List<Person> people = modelinfo.Person;
            Console.WriteLine("enter persons last+ name to get removed from the list");
            String removePerson = Utility.readString();
            foreach (var person in people)
            {
                if (person.LastName.Equals(removePerson))
                {
                    people.Remove(person);
                    break;
                }
            }
        }
        /// <summary>
        /// Updates the person.
        /// </summary>
        /// <param name="modelinfo">The modelinfo.</param>
        public static void UpdatePerson(Model1 modelinfo)
        {
            List<Person> people = modelinfo.Person;
            Console.WriteLine("enter Last Name of a person get updated");
            String UpdateField = Utility.readString();
            foreach (var field in people)
            {
                if (field.LastName == UpdateField)
                {
                    Console.WriteLine("enter any property to get updated");
                    String property = Utility.readString();
                    if (property == "firstname")
                    {
                        Console.WriteLine("enter a new name to get updated");
                        String newName = Utility.readString();
                        field.FirstName = newName;
                    }
                    if (property == "lastname")
                    {
                        Console.WriteLine("enter a new name to get updated");
                        String newName = Utility.readString();
                        field.LastName = newName;
                    }
                    if (property == "address")
                    {
                        Console.WriteLine("enter a new address to get updated");
                        String newAddress = Utility.readString();
                        field.Address = newAddress;
                    }
                    if (property == "city")
                    {
                        Console.WriteLine("enter a new city to get updated");
                        String newCity = Utility.readString();
                        field.City = newCity;
                    }
                    if (property == "state")
                    {
                        Console.WriteLine("enter a new state to get updated");
                        String newState = Utility.readString();
                        field.State = newState;
                    }
                    if (property == "zip")
                    {
                        Console.WriteLine("enter a new zip to get updated");
                        int newZip = Utility.readInt();
                        field.Zip = newZip;
                    }
                    if (property == "phonenumber")
                    {
                        Console.WriteLine("enter new phone number");
                        field.PhoneNumber = Utility.readInt();
                    }
                }
            }
        }
        /// <summary>
        /// Serializings the specified modelinfo.
        /// </summary>
        /// <param name="modelinfo">The modelinfo.</param>
        /// <param name="jsonfile">The jsonfile.</param>
        public static void Serializing(Model1 modelinfo, string jsonfile)
        {
            try
            {
                string jsonResultString = JsonConvert.SerializeObject(modelinfo);
                File.WriteAllText(jsonfile, jsonResultString);
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
        }
    }
}


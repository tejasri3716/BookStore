//--------------------------------------------------------------------------------------------------------------------
// <copyright file="PrototypeTest.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.PrototypeDesignPattern
{
    public class Employee : EmployeeAbstractClass
    {
        private string name;
        private int eid;
        private int age;

        public string GetName()
        {
            return this.name;
        }
        public void SetName(string value)
        {
            this.name = value;
        }
        public int GetEid()
        {
            return this.eid;
        }
        public void SetEid(int id)
        {
            this.eid = id;
        }

        public int GetAge()
        {
            return this.age;
        }
        public void SetAge(int age)
        {
            this.age = age;
        }
        public override string ToString()
        {
            return string.Format("Name = {0}, Eid = {1}, Age = {2}", name, eid, age);
        }

        public override Employee Clone()
        {
            return (Employee)MemberwiseClone();
        }
        public override string GetDetails()
        {
            return this.ToString();
        }
    }
}

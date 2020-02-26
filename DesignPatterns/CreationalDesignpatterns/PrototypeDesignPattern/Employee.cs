//--------------------------------------------------------------------------------------------------------------------
// <copyright file="Employee.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.PrototypeDesignPattern
{
    /// <summary>
    /// Employee Class implements EmployeeAbstractClass
    /// </summary>
    /// <seealso cref="DesignPatterns.PrototypeDesignPattern.EmployeeAbstractClass" />
    public class Employee : EmployeeAbstractClass
    {
        private string name;
        private int eid;
        private int age;
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return this.name;
        }
        /// <summary>
        /// Sets the name.
        /// </summary>
        /// <param name="value">The value.</param>
        public void SetName(string value)
        {
            this.name = value;
        }
        /// <summary>
        /// Gets the eid.
        /// </summary>
        /// <returns></returns>
        public int GetEid()
        {
            return this.eid;
        }
        /// <summary>
        /// Sets the eid.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public void SetEid(int id)
        {
            this.eid = id;
        }
        /// <summary>
        /// Gets the age.
        /// </summary>
        /// <returns></returns>
        public int GetAge()
        {
            return this.age;
        }
        /// <summary>
        /// Sets the age.
        /// </summary>
        /// <param name="age">The age.</param>
        public void SetAge(int age)
        {
            this.age = age;
        }
        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return string.Format("Name = {0}, Eid = {1}, Age = {2}", name, eid, age);
        }

        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns></returns>
        public override Employee Clone()
        {
            return (Employee)MemberwiseClone();
        }
        /// <summary>
        /// Gets the details.
        /// </summary>
        /// <returns></returns>
        public override string GetDetails()
        {
            return this.ToString();
        }
    }
}

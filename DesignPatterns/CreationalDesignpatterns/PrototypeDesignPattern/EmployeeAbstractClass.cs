//--------------------------------------------------------------------------------------------------------------------
// <copyright file="EmployeeAbstractClass.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.PrototypeDesignPattern
{
    /// <summary>
    /// EmployeeAbstractClass consists of abstract methods
    /// </summary>
    public abstract class EmployeeAbstractClass
    {
        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns></returns>
        public abstract Employee Clone();
        /// <summary>
        /// Gets the details.
        /// </summary>
        /// <returns></returns>
        public abstract string GetDetails();
    }
}

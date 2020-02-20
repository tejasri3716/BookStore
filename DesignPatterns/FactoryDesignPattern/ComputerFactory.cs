//--------------------------------------------------------------------------------------------------------------------
// <copyright file="ComputerFactory.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.FactoryDesignPattern
{
    /// <summary>
    /// Computer Factory Class is used as to hide implementation details from the client
    /// </summary>
   public class ComputerFactory
    {
        /// <summary>
        /// Gets the computer object.
        /// </summary>
        /// <param name="typeOfObj">The type of object.</param>
        /// <returns>
        /// gets Computer Object
        /// </returns>
        public static IComputer GetComputerObject(string typeOfObj)
        {
            IComputer obj = null;
            if (typeOfObj.ToLower() == "pc")
            {
                obj = new PC("2GB", "500GB", "2.4GHz");
            }
            else
            {
                obj = new Server("16GB", "1TB", "2.9GHz");
            }

            return obj;
        }
    }
}

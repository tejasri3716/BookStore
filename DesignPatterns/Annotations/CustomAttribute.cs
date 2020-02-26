//--------------------------------------------------------------------------------------------------------------------
// <copyright file="CustomAttribute.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.Annotations
{
    using System;
    using System.Reflection;

    /// <summary>
    /// CustomAttribute class extends Attribute class to create custom attributes
    /// </summary>
    /// <seealso cref="System.Attribute" />
    [AttributeUsage(AttributeTargets.All)]
    public class CustomAttribute : Attribute
    {
        /// <summary>
        /// The name
        /// </summary>
        private string name;

        /// <summary>
        /// The action
        /// </summary>
        private string action;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomAttribute"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="action">The action.</param>
        public CustomAttribute(string name, string action)
        {
            this.name = name;
            this.action = action;
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name
        {
            get { return this.name; }
        }

        /// <summary>
        /// Gets the action.
        /// </summary>
        /// <value>
        /// The action.
        /// </value>
        public string Action
        {
            get { return this.action; }
        }

        /// <summary>
        /// Displays the Attributes.
        /// </summary>
        /// <param name="classType">Type of the class.</param>
        public static void AttributeDisplay(Type classType)
        {
            Console.WriteLine("Methods of class {0}", classType.Name);

            // Array to store all methods of a class 
            // to which the attribute may be applied 
            MethodInfo[] methods = classType.GetMethods();

            // for loop to read through all methods 
            for (int i = 0; i < methods.GetLength(0); i++)
            {
                // Creating object array to receive 
                // method attributes returned 
                // by the GetCustomAttributes method 
                object[] attributesArray = methods[i].GetCustomAttributes(true);

                // foreach loop to read through 
                // all attributes of the method 
                foreach (Attribute item in attributesArray)
                {
                    if (item is CustomAttribute)
                    {
                        // Display the fields of the CustomAttribute 
                        CustomAttribute attributeObject = (CustomAttribute)item;
                        Console.WriteLine("{0} - {1}, {2} ", methods[i].Name, attributeObject.name, attributeObject.action);
                    }
                }
            }
        }
    }
}
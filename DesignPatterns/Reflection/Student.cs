//--------------------------------------------------------------------------------------------------------------------
// <copyright file="Student.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.Reflection
{
    using System;

    /// <summary>
    /// Student class to get meta data of this class using reflection
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Gets or sets the roll no.
        /// </summary>
        /// <value>
        /// The roll no.
        /// </value>
        public int RollNo
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class.
        /// </summary>
        public Student()
        {
            RollNo = 0;
            Name = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class.
        /// </summary>
        /// <param name="rno">The rno.</param>
        /// <param name="name">The name.</param>
        public Student(int rno, string name)
        {
            this.RollNo = rno;
            this.Name = name;
        }

        /// <summary>
        /// Displays this instance.
        /// </summary>
        public void Display()
        {
            Console.WriteLine("Roll Number : {0}", RollNo);
            Console.WriteLine("Name : {0}", Name);
        }
    }
}
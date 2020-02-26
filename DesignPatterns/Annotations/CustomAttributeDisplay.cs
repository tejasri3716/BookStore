//--------------------------------------------------------------------------------------------------------------------
// <copyright file="CustomAttributeDisplay.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.Annotations
{
    using System;

    /// <summary>
    /// CustomAttributeDisplay class displays the attributes
    /// </summary>
    public class CustomAttributeDisplay
    {
        /// <summary>
        /// Displays the attributes.
        /// </summary>
        public static void DisplayAttributes()
        {
            Student s = new Student();
            s.SetDetails(89, "Tejasri", 92.5);
            CustomAttribute.AttributeDisplay(typeof(Student));
            Console.Write("\n");
            Console.WriteLine("Student Details");
            Console.WriteLine("Roll Number : " + s.GetRollNo());
            Console.WriteLine("Name : " + s.GetStudentName());
            Console.WriteLine("Marks : " + s.GetMarks());
        }
    }
}
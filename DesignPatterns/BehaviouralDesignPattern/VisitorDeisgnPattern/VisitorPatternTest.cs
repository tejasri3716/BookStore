//--------------------------------------------------------------------------------------------------------------------
// <copyright file="VisitorPatternTest.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.BehaviouralDesignPattern.VisitorDeisgnPattern
{
    /// <summary>
    /// VisitorPatternTest class demonstrate the use of Visitor Pattern
    /// </summary>
    public class VisitorPatternTest
    {
        /// <summary>
        /// Test method creates object for IComputerPart interface and initializes that object with 
        /// Computer class object to override Accept method 
        /// </summary>
        public static void Test()
        {
           IComputerPart computer = new Computer();
            computer.Accept(new ComputerPartDisplayVisitor());
        }
    }
}
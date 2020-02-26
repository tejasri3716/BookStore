//--------------------------------------------------------------------------------------------------------------------
// <copyright file="Rectangle.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace ObjectOrientedPrograms.Delegates
{
    using System;

    /// <summary>
    /// Rectangle class is used to declare a delegate
    /// </summary>
    public class Rectangle
    {
        /// <summary>
        /// Rectangle Delegate is a delegate that is used to point the methods
        /// </summary>
        /// <param name="height">The height.</param>
        /// <param name="width">The width.</param>
        public delegate void RectDelegate(double height, double width);

        /// <summary>
        /// Areas the specified height.
        /// </summary>
        /// <param name="height">The height.</param>
        /// <param name="width">The width.</param>
        public void Area(double height, double width)
        {
            Console.WriteLine("Area is: {0}", width * height);
        }

        /// <summary>
        /// Gives Perimeter of the specified height.
        /// </summary>
        /// <param name="height">The height.</param>
        /// <param name="width">The width.</param>
        public void Perimeter(double height, double width)
        {
            Console.WriteLine("Perimeter is: {0} ", 2 * (width + height));
        }
    }
}
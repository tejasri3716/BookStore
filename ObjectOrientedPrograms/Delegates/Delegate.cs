//--------------------------------------------------------------------------------------------------------------------
// <copyright file="Delegate.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace ObjectOrientedPrograms.Delegates
{
    using System;
    using static ObjectOrientedPrograms.Delegates.Rectangle;

    /// <summary>
    /// Delegate class used to refer methods in Rectangle class
    /// </summary>
    public class Delegate
    {
        /// <summary>
        /// Multicasting delegates.
        /// </summary>
        public static void MultiCasting()
        {
            Rectangle rect = new Rectangle();

            // these two lines are normal calling 
            // of that two methods 
            // rect.area(6.3, 4.2); 
            // rect.perimeter(6.3, 4.2); 

            // creating delegate object, name as "rectdele" 
            // and pass the method as parameter by  
            // class object "rect" 
            RectDelegate rectdele = new RectDelegate(rect.Area);

            // also can be written as  
            // rectDelegate rectdele = rect.area; 

            // call 2nd method "perimeter" 
            // Multicasting 
            rectdele += rect.Perimeter;

            // pass the values in two method  
            // by using "Invoke" method 
            rectdele.Invoke(6.3, 4.2);
            Console.WriteLine();

            // call the methods with  
            // different values 
            rectdele.Invoke(16.3, 10.3);
        }
    }
}
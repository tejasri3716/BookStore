//--------------------------------------------------------------------------------------------------------------------
// <copyright file="ComputerFactory.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FacadeDesignPattern
{
    class FacadeDesignPatternTest
    {
        public static void Test()
        {
            FacadeDesignPattern facade = new FacadeDesignPattern();
            {
                Console.WriteLine("enter your choice");
                Console.WriteLine(" 1.Buy HeadPhones");
                Console.WriteLine(" 2.Buy Laptop");
                Console.WriteLine(" 3.Buy Mobile");
                //// input the choice
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        facade.BuyHeadPhones();
                        break;
                    case 2:
                        facade.BuyLaptop();
                        break;
                    case 3:
                        facade.BuyMobile();
                        break;

                    default:
                        Console.WriteLine("invalid selection");
                        break;
                }

            }
        }
    }
}

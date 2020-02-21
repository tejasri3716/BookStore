//--------------------------------------------------------------------------------------------------------------------
// <copyright file="WeightVisitor.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralDesignPattern.VisitorDesignPattern
{
    public class WeightVisitor : IVisitor
    {
        public void Accept(Book book)
        {
            switch (book.BookName)
            {
                case "HalfGirlFirend":
                    Console.WriteLine("Book {0} weight: {1} GM", book.BookName, 100);
                    break;
                case "Ordinary":
                    Console.WriteLine("Book {0} weight: {1} GM", book.BookName, 750);
                    break;
            }
        }

        public void Accept(Fruit fruit)
        {
            switch (fruit.FruitName)
            {
                case "Apple":
                    Console.WriteLine("Fruit {0} weight: {1} KG", fruit.FruitName, 3);
                    break;
                case "Grapes":
                    Console.WriteLine("Fruit {0} weight: {1} KG", fruit.FruitName, 1);
                    break;
            }
        }
    }
}

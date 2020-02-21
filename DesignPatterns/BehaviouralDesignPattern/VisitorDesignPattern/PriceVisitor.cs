//--------------------------------------------------------------------------------------------------------------------
// <copyright file="PriceVisitor.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.BehaviouralDesignPattern.VisitorDesignPattern
{
    using System;

    public class PriceVisitor : IVisitor
    {
        private const int BOOK_DISCOUNT = 5;
        private const int FRUIT_DISCOUNT = 2;

        public void Accept(Book book)
        {
            int bookPriceAfterDicount = book.Price - ((book.Price / 100) * BOOK_DISCOUNT);
            Console.WriteLine("Book {0} price: {1}", book.BookName, bookPriceAfterDicount);
        }

        public void Accept(Fruit fruit)
        {
            int fruitPriceAfterDicount = fruit.Price - ((fruit.Price / 100) * FRUIT_DISCOUNT);
            Console.WriteLine("Bike {0} price: {1}", fruit.FruitName, fruitPriceAfterDicount);
        }
    }
}

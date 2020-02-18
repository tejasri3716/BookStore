//--------------------------------------------------------------------------------------------------------------------
// <copyright file="StockAccountInterface.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace ObjectOrientedPrograms.CommercialDataProcessing
{
    using System;

    /// <summary>
    /// Stock Account Interface having abstract methods
    /// </summary>
    interface StockAccountInterface
    {
        /// <summary>
        /// Creates new stockaccount.
        /// </summary>
        /// <param name="filename">The filename.</param>
        /// <returns></returns>
        Stocks NewStockAccount(String filename);

        /// <summary>
        /// prints the value of total stock price
        /// </summary>
        /// <returns></returns>
        double ValueOf();

        /// <summary>
        /// Buys the specified stocks.
        /// </summary>
        /// <param name="stocks">The stocks.</param>
        void Buy(Stocks stocks, Stack stack, Queue queue);

        /// <summary>
        /// Sells the specified stocks.
        /// </summary>
        /// <param name="stocks">The stocks.</param>
        void Sell(Stocks stocks, Stack stack, Queue queue);


        /// <summary>
        /// Saves the specified filename.
        /// </summary>
        /// <param name="filename">The filename.</param>
        void Save(String filename);

        /// <summary>
        /// Prints the report.
        /// </summary>
        /// <param name="stocks">The stocks.</param>
        void PrintReport(Stocks stocks);


    }
}

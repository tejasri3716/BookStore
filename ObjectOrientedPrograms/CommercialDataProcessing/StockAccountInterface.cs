﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms.CommercialDataProcessing
{

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
        void Buy(Stocks stocks, Stack1 stack, Queue1 queue);

        /// <summary>
        /// Sells the specified stocks.
        /// </summary>
        /// <param name="stocks">The stocks.</param>
        void Sell(Stocks stocks, Stack1 stack, Queue1 queue);


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

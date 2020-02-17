//--------------------------------------------------------------------------------------------------------------------
// <copyright file=CompanyShares.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------

namespace ObjectOrientedPrograms.CommercialDataProcessing
{
   using System;

    /// <summary>
    /// Company Shares Class is used for Encapsulation
    /// </summary>
    public class CompanyShares
    {
        private string symbol;
        private int totalShares;
        private DateTime dateTime;

        /// <summary>
        /// Gets or sets the symbol.
        /// </summary>
        /// <value>
        /// The symbol.
        /// </value>
        public string Symbol { get => symbol; set => symbol = value; }
        /// <summary>
        /// Gets or sets the total shares.
        /// </summary>
        /// <value>
        /// The total shares.
        /// </value>
        public int TotalShares { get => totalShares; set => totalShares = value; }
        /// <summary>
        /// Gets or sets the date time.
        /// </summary>
        /// <value>
        /// The date time.
        /// </value>
        public DateTime DateTime { get => dateTime; set => dateTime = value; }
    }
}

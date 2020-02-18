//--------------------------------------------------------------------------------------------------------------------
// <copyright file="StockInfo.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------

namespace ObjectOrientedPrograms.CommercialDataProcessing
{
    /// <summary>
    /// Stock Info Class is used for Encapsulation
    /// </summary>
    public class StockInfo
    {
        private string stockName;
        private int totalShares;
        private double sharePrice;
        /// <summary>
        /// Gets or sets the name of the stock.
        /// </summary>
        /// <value>
        /// The name of the stock.
        /// </value>
        public string StockName
        {
            get
            {
                return this.stockName;
            }
            set
            {
                this.stockName = value;
            }
        }
        /// <summary>
        /// Gets or sets the total shares.
        /// </summary>
        /// <value>
        /// The total shares.
        /// </value>
        public int TotalShares
        {
            get
            {
                return this.totalShares;
            }
            set
            {
                this.totalShares = value;
            }
        }
        /// <summary>
        /// Gets or sets the share price.
        /// </summary>
        /// <value>
        /// The share price.
        /// </value>
        public double SharePrice
        {
            get
            {
                return this.sharePrice;
            }
            set
            {
                this.sharePrice = value;
            }
        }
    }
}

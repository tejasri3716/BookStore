using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms.CommercialDataProcessing
{
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

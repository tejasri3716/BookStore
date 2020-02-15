using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms.CommercialDataProcessing
{
    class CompanyShares
    {
        private string symbol;
        private int numberOfShare;
        private DateTime dateTime;
        /// <summary>
        /// Gets or sets the symbol.
        /// </summary>
        /// <value>
        /// The symbol.
        /// </value>
        public string Symbol { get => symbol; set => symbol = value; }
        /// <summary>
        /// Gets or sets the number of share.
        /// </summary>
        /// <value>
        /// The number of share.
        /// </value>
        public int NumberOfShare { get => numberOfShare; set => numberOfShare = value; }
        /// <summary>
        /// Gets or sets the date time.
        /// </summary>
        /// <value>
        /// The date time.
        /// </value>
        public DateTime DateTime { get => dateTime; set => dateTime = value; }
    }
}

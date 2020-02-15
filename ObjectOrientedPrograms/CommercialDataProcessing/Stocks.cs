using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms.CommercialDataProcessing
{
    public class Stocks
    {
        public List<StockInfo> Stock
        {
            get
            {
                return this.Stock;
            }
            set
            {
                this.Stock = value;
            }
        }
    }
}

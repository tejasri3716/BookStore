using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms
{
    public class StockInfo
    {
        public string stockname;
        public double share;
        public double price;

        public string StockName
        {
            set
            {
                this.stockname = value;
            }
            get
            {
                return this.stockname;
            }
        }
        public double Share
        {
            set
            {
                this.share = value;
            }
            get
            {
                return this.share;
            }
        }
        public double Price
        {
            set
            {
                this.price = value;
            }
            get
            {
                return this.price;
            }
        }

    }
}

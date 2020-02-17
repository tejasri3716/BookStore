//--------------------------------------------------------------------------------------------------------------------
// <copyright file=StockInfo.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace ObjectOrientedPrograms
{
    /// <summary>
    /// Stock Info class is used to get and set stock name , share and price
    /// </summary>
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

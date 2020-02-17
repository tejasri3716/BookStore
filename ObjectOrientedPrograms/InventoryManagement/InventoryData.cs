//--------------------------------------------------------------------------------------------------------------------
// <copyright file=InventoryData.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------

namespace ObjectOrientedPrograms.InventoryManagement
{
    /// <summary>
    /// Inventory Data Class for getting and setting name , weight and price values
    /// </summary>
    public class InventoryData
    {

        private string name;
        private double weight;
        private double price;
        public string Name
        {
            set
            {
                this.name = value;
            }
            get
            {
                return this.name;
            }
        }
        public double Weight
        {
            set
            {
                this.weight = value;
            }
            get
            {
                return this.weight;
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

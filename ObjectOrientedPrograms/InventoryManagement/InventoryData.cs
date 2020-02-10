using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms.InventoryManagement
{
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

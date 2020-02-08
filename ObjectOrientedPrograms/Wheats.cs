using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms
{
    public class Wheats
    {
        private string name;
        private double price;
        private double weight;

        public string Name { get => this.name; set => this.name = value; }
        public double Price { get => this.price; set => this.price = value; }
        public double Weight { get => this.weight; set => this.weight = value; }
    }
}

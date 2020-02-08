using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms.InventoryManagement
{
    class Model
    {
        public List<Rices> Rices { get; set; }
        public List<Pulses> Pulses { get; set; }
        public List<Wheats> Wheats { get; set; }
    }
    public class Rices
    {
        public string name { get; set; }
        public double price { get; set; }
        public double weight { get; set; }
    }
    public class Pulses
    {
        public string name { get; set; }
        public double price { get; set; }
        public double weight { get; set; }
    }
    public class Wheats
    {
        public string name { get; set; }
        public double price { get; set; }
        public double weight { get; set; }
    }

}

using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms.InventoryManagement
{
    public class Model
    {
        private List<Rices> rices;
        private List<Pulses> pulses;
        private List<Wheats> wheats;

        public List<Rices> Rices { get => this.rices; set => this.rices = value; }
        public List<Pulses> Pulses { get => this.pulses; set => this.pulses = value; }
        public List<Wheats> Wheats { get => this.wheats; set => this.wheats = value; }
    }
    
    
}

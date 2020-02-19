//--------------------------------------------------------------------------------------------------------------------
// <copyright file="PrototypeTest.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryDesignPattern
{
    class Server : Computer
    {
        private string ram;
        private string hdd;
        private string cpu;
        public Server(String ram, String hdd, String cpu)
        {
            this.ram = ram;
            this.hdd = hdd;
            this.cpu = cpu;
        }
        public string getRAM()
        {
            return this.ram;
        }
        public string getHDD()
        {
            return this.hdd;
        }
        public string getCPU()
        {
            return this.cpu;
        }
    }
}

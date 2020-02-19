using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryDesignPattern
{
    interface Computer
    {
         string getRAM();
         string getHDD();
         string getCPU();
    }
}

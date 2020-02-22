using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralDesignPattern.VisitorDeisgnPattern
{
    public class VisitorPatternTest
    {
        public static void Test()
        {
            IComputerPart computer = new Computer();
            computer.Accept(new ComputerPartDisplayVisitor());
        }
    }
}
namespace DesignPatterns.BehaviouralDesignPattern.VisitorDeisgnPattern
{
    using System.Collections.Generic;
    public class Computer : IComputerPart
    {

        List<IComputerPart> parts;

        public Computer()
        {
            this.parts = new List<IComputerPart>{ new Mouse(), new Keyboard(), new Monitor() };
        }
        public void Accept(IComputerPartVisitor computerPartVisitor)
        {
            foreach(var part in parts)
            {
                part.Accept(computerPartVisitor);
            }
            computerPartVisitor.Visit(this);
        }
    }
}
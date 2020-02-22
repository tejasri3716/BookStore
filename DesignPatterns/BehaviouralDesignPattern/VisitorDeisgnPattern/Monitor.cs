﻿namespace DesignPatterns.BehaviouralDesignPattern.VisitorDeisgnPattern
{
    public class Monitor : IComputerPart
    {
        public void Accept(IComputerPartVisitor computerPartVisitor)
        {
            computerPartVisitor.Visit(this);
        }
    }
}
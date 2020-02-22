﻿namespace DesignPatterns.BehaviouralDesignPattern.VisitorDeisgnPattern
{
    public class Keyboard : IComputerPart
    {
        public void Accept(IComputerPartVisitor computerPartVisitor)
        {
            computerPartVisitor.Visit(this);
        }
    }
}
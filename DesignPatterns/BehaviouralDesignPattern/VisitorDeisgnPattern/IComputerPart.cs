namespace DesignPatterns.BehaviouralDesignPattern.VisitorDeisgnPattern
{
    public interface IComputerPart
    {
        public void Accept(IComputerPartVisitor computerPartVisitor);
    }
}
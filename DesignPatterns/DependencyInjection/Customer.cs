using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DependencyInjection
{
    public class Customer : IService
    {
        public void Serve()
        {
            Console.WriteLine("Customer class is called");
        }
    }
}
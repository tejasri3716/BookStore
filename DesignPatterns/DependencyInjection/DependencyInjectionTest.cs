using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.DependencyInjection
{
    public class DependencyInjectionTest
    {
        public static void Test()
        {
            //creating object
            Service service = new Service();
            //passing dependency
            Client c1 = new Client(service);
            c1.ServeMethod();
           Customer customer = new Customer();
            //passing dependency
            c1 = new Client(customer);
            c1.ServeMethod();
        }
    }
}
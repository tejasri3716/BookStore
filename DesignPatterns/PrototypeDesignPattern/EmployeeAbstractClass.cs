using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.PrototypeDesignPattern
{
   public abstract class EmployeeAbstractClass
    {
        public abstract Employee Clone();

        public abstract string GetDetails();
    }
}

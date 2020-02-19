//--------------------------------------------------------------------------------------------------------------------
// <copyright file="PrototypeTest.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
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

//--------------------------------------------------------------------------------------------------------------------
// <copyright file="IStore.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralDesignPattern.VisitorDesignPattern
{
    public interface IStore
    {
        public void Visit(IVisitor visitor);
    }
}

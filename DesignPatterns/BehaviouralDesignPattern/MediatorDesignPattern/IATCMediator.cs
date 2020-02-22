//--------------------------------------------------------------------------------------------------------------------
// <copyright file="IATCMediator.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.BehaviouralDesignPattern.MediatorDesignPattern
{
    public interface IATCMediator
    {
        public void RegisterRunway(Runway runway);
        public void RegisterFlight(Flight flight);
        public bool IsLandingOk();
        public void SetLandingStatus(bool status);
    }
}

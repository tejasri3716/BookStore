//--------------------------------------------------------------------------------------------------------------------
// <copyright file="IService.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="tejasri"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPatterns.DependencyInjection
{
    /// <summary>
    /// IService interface consists of abstract method Serve
    /// </summary>
    public interface IService
    {
        /// <summary>
        /// Serves this instance.
        /// </summary>
        public void Serve();
    }
}
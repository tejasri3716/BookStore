namespace DesignPatterns.DependencyInjection
{
    using System;

    /// <summary>
    /// Service class implements IService interface and overrides Serve method
    /// </summary>
    /// <seealso cref="DesignPatterns.DependencyInjection.IService" />
    public class Service : IService
    {
        /// <summary>
        /// Serves this instance.
        /// </summary>
        public void Serve()
        {
            Console.WriteLine("Service class is called");
        }
    }
}
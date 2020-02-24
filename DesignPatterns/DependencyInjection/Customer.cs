namespace DesignPatterns.DependencyInjection
{
    using System;

    /// <summary>
    /// Customer class implements IService interface
    /// </summary>
    /// <seealso cref="DesignPatterns.DependencyInjection.IService" />
    public class Customer : IService
    {
        /// <summary>
        /// Serves this instance.
        /// </summary>
        public void Serve()
        {
            Console.WriteLine("Customer class is called");
        }
    }
}
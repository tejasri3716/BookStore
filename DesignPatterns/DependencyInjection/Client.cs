namespace DesignPatterns.DependencyInjection
{
    /// <summary>
    /// Client class consists of a parameterized constructor which invokes IService interface
    /// </summary>
    public class Client
    {
        /// <summary>
        /// The service
        /// </summary>
        private IService service;

        /// <summary>
        /// Initializes a new instance of the <see cref="Client"/> class.
        /// </summary>
        /// <param name="service">The service.</param>
        public Client(IService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Serves the method.
        /// </summary>
        public void ServeMethod()
        {
            this.service.Serve();
        }
    }
}
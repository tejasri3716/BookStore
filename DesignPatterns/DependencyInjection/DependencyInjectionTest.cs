namespace DesignPatterns.DependencyInjection
{
    /// <summary>
    /// DependencyInjectionTest class creates objects of Service class and Customer class
    /// </summary>
    public class DependencyInjectionTest
    {
        /// <summary>
        /// Tests this instance.
        /// </summary>
        public static void Test()
        {
            // creating object 
            Service service = new Service();

            // passing dependency
            Client c1 = new Client(service);
            c1.ServeMethod();
           Customer customer = new Customer();

            // passing dependency
            c1 = new Client(customer);
            c1.ServeMethod();
        }
    }
}
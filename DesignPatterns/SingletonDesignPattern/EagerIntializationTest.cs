using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SingletonDesignPattern
{
    class EagerIntializationTest
    {
        public static void Test()
        {
            Parallel.Invoke(
                () => FirstInstance(),
                () => SecondInstance()
                );
        }
        private static void SecondInstance()
        {
            // Another Object created for thread safes intialization class
            ThreadSafeSingleton threadSafeIntialization = ThreadSafeSingleton.GetInstance;
            threadSafeIntialization.PrintDetails("this is my second instance of object");
        }

        private static void FirstInstance()
        {
            // Object creation for thread safe intialization singleton class
            ThreadSafeSingleton intialization = ThreadSafeSingleton.GetInstance;
            intialization.PrintDetails("this is my first instance of object");
        }
    }
}

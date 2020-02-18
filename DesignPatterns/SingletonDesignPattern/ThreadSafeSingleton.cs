using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SingletonDesignPattern
{
    class ThreadSafeSingleton
    {
        private static ThreadSafeSingleton instance = null;
        private static int counter = 0;
        private static readonly object obj = new object();
        private ThreadSafeSingleton()
        {
            counter++;
            Console.WriteLine("counter value is :" + counter);
        }
        public static ThreadSafeSingleton GetInstance
        {
            get
            {
                if (instance == null)
                {                           // double checked locking
                    lock (obj)
                    {                           // using lock only one thread can enter into this block at a given point of time
                        if (instance == null)
                            instance = new ThreadSafeSingleton();
                    }
                }
                return instance;
            }
        }
        public void PrintDetails(String message)
        {
            Console.WriteLine(message);
        }
    }
}

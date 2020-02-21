namespace DesignPatterns.BehaviouralDesignPattern.ObserverDesignPattern
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// MyTopic class implements Isubject interface
    /// </summary>
    /// <seealso cref="DesignPatterns.BehaviouralDesignPattern.ObserverDesignPattern.ISubject" />
    public class MyTopic : ISubject
    {
        /// <summary>
        /// The observer
        /// </summary>
        private List<IObserver> observer;

        /// <summary>
        /// The message
        /// </summary>
        private string message;

        /// <summary>
        /// The changed
        /// </summary>
        private bool changed;

        /// <summary>
        /// Initializes a new instance of the <see cref="MyTopic"/> class.
        /// </summary>
        public MyTopic()
        {
            this.observer = new List<IObserver>();
        }

        /// <summary>
        /// Registers the specified object.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <exception cref="Exception">Null Observer</exception>
        public void Register(IObserver obj)
        {
            if (obj == null) throw new Exception("Null Observer");
            observer.Add(obj);

        }

        /// <summary>
        /// UnRegister the observers.
        /// </summary>
        /// <param name="obj">The object.</param>
        public void UnRegister(IObserver obj)
        {
            observer.Remove(obj);
        }

        /// <summary>
        /// Notifies the observers about changes.
        /// </summary>
        public void NotifyObservers()
        {
            List<IObserver> observersLocal = null;
            if (!changed)
                return;
            observersLocal = new List<IObserver>(this.observer);
            this.changed = false;
            foreach (IObserver obj in observersLocal)
            {
                obj.Update();
            }
        }

        /// <summary>
        /// Gets the update.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns></returns>
        public object GetUpdate(IObserver obj)
        {
            return this.message;
        }

        /// <summary>
        /// Posts the message.
        /// </summary>
        /// <param name="msg">The MSG.</param>
        public void PostMessage(String msg)
        {
            Console.WriteLine("Message Posted to Topic:" + msg);
            this.message = msg;
            this.changed = true;
            NotifyObservers();
        }
    }
}
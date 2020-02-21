namespace DesignPatterns.BehaviouralDesignPattern.ObserverDesignPattern
{
    public interface ISubject
    {
        /// <summary>
        /// Registers the specified object.
        /// </summary>
        /// <param name="obj">The object.</param>
        public void Register(IObserver obj);

        /// <summary>
        /// UnRegister the observers.
        /// </summary>
        /// <param name="obj">The object.</param>
        public void UnRegister(IObserver obj);

        /// <summary>
        /// Notifies the observers about changes.
        /// </summary>
        public void NotifyObservers();

        /// <summary>
        /// Gets the update.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns></returns>
        public object GetUpdate(IObserver obj);
    }
}

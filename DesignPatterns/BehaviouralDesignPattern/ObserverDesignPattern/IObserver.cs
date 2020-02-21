namespace DesignPatterns.BehaviouralDesignPattern.ObserverDesignPattern
{
    public interface IObserver
    {
        /// <summary>
        /// Updates the observer, used by subject 
        /// </summary>
        public void Update();

        /// <summary>
        /// Sets the subject.
        /// </summary>
        /// <param name="sub">The sub.</param>
        public void SetSubject(ISubject sub);
    }
}

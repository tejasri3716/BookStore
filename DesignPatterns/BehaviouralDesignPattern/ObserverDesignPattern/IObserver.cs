namespace DesignPatterns.BehaviouralDesignPattern.ObserverDesignPattern
{
    /// <summary>
    /// IObserver interface consists of Update method
    /// </summary>
    public interface IObserver
    {
        /// <summary>
        /// Updates the observer, used by subject 
        /// </summary>
        public void Update(string availability);
    }
}
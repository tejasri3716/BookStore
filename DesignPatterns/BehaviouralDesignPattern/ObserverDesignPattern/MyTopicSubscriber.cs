namespace DesignPatterns.BehaviouralDesignPattern.ObserverDesignPattern
{
    using System;

    /// <summary>
    /// MyTopicSubscriber class implements IObserver interface
    /// </summary>
    /// <seealso cref="DesignPatterns.BehaviouralDesignPattern.ObserverDesignPattern.IObserver" />
    public class MyTopicSubscriber : IObserver
    {
        /// <summary>
        /// The name
        /// </summary>
        private string name;

        /// <summary>
        /// The topic
        /// </summary>
        private ISubject topic;

        /// <summary>
        /// Initializes a new instance of the <see cref="MyTopicSubscriber"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public MyTopicSubscriber(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// Updates the observer, used by subject
        /// </summary>
        public void Update()
        {
            String msg = (string)topic.GetUpdate(this);
            if (msg == null)
            {
                Console.WriteLine(name + ":: No new message");
            }
            else
                Console.WriteLine(name + ":: Consuming message::" + msg);
        }

        /// <summary>
        /// Sets the subject.
        /// </summary>
        /// <param name="sub">The sub.</param>
        public void SetSubject(ISubject sub)
        {
            this.topic = sub;
        }
    }
}
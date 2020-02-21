namespace DesignPatterns.BehaviouralDesignPattern.ObserverDesignPattern
{
    using System;
    /// <summary>
    /// ObserverPatternTest class is used to test the Observer Design Pattern
    /// </summary>
    public class ObserverPatternTest
    {
        /// <summary>
        /// Test this instance.
        /// </summary>
        public static void Test()
        {
            MyTopic topic = new MyTopic();

            // create observers
            IObserver obj1 = new MyTopicSubscriber("Obj1");
            IObserver obj2 = new MyTopicSubscriber("Obj2");
            IObserver obj3 = new MyTopicSubscriber("Obj3");

            // register observers to the subject
            topic.Register(obj1);
            topic.Register(obj2);
            topic.Register(obj3);

            // attach observer to subject
            obj1.SetSubject(topic);
            obj2.SetSubject(topic);
            obj3.SetSubject(topic);

            // check if any update is available
            obj1.Update();
            obj2.Update();
            obj3.Update();

            // now send message to subject
            topic.PostMessage("C#");
            Console.Write("enter new topic "); 

            // enter new topic
            topic.PostMessage(Utility.ReadString());
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.New.Base
{
    public class Subject
    {
        private List<Observer> _observer = new List<Observer>();

        public void AttachObserver(Observer observer)
        {
            _observer.Add(observer);
        }

        public void DetachObserver(Observer observer)
        {
            _observer.Remove(observer);
        }

        public void NotifyObservers(object arg)
        {
            _observer.ForEach((observer) => observer.Notify(arg));
        }
    }
}
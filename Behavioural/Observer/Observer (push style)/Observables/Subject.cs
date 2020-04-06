using System;
using System.Collections.Generic;
using System.Text;

namespace Observer__simple_notify_.Observables
{
    public abstract class Subject
    {
        private List<IObserver> Observers { get; set; } = new List<IObserver>();
        public void AddObserver(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            Observers.Remove(observer);
        }

        protected void NotifyObservers(Object value)
        {
            Observers.ForEach(o => o.Update(value));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Observer__simple_notify_.Observables;

namespace Observer__simple_notify_
{
    public class DataSource : Subject
    {
        private int _value;
        public int Value
        {
            get { return _value; }
            set
            {
                _value = value;
                NotifyObservers(value);
            }
        }
    }
}

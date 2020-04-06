using System;
using System.Collections.Generic;
using System.Text;

namespace Observer__simple_notify_.Observers
{
    //график
    class Chart : IObserver
    {
        public void Update(Object value)
        {
            Console.WriteLine("Chart got updated: " + value);
        }
    }
}

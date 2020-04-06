using System;
using System.Collections.Generic;
using System.Text;

namespace Observer__simple_notify_.Observers
{
    //таблица
    class SpreadSheet : IObserver
    {
        public void Update(Object value)
        {
            Console.WriteLine("SpreadSheet got updated: " + value);
        }
    }
}

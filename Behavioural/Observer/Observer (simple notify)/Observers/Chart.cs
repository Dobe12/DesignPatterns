using System;
using System.Collections.Generic;
using System.Text;

namespace Observer__simple_notify_.Observers
{
    //график
    class Chart : IObserver
    {
        public void Update()
        {
            Console.WriteLine("Chart got updated");
        }
    }
}

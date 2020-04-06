﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Observer__simple_notify_.Observers
{
    //таблица
    class SpreadSheet : IObserver
    {
        private readonly DataSource _dataSource;

        public SpreadSheet(DataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public void Update()
        {
            Console.WriteLine("SpreadSheet got updated: " + _dataSource.Value);
        }
    }
}

using System;
using Observer__simple_notify_.Observers;

namespace Observer__simple_notify_
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataSource = new DataSource();
            var sheetA = new SpreadSheet(dataSource);
            var sheetB = new SpreadSheet(dataSource);
            var chart = new Chart(dataSource);

            dataSource.AddObserver(sheetA);
            dataSource.AddObserver(sheetB);
            dataSource.AddObserver(chart);

            dataSource.Value = 228;
        }
    }
}

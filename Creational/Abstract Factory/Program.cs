using System;
using Abstract_Factory.PizzaFactorys;

namespace Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var pepperoni = new PizzaMaker(new PepperoniPizzaFactory("Pepperoni"));

            var hawaiian = new PizzaMaker(new HawaiianPizzaFactory("Hawaiian"));

            var fourSeasons = new PizzaMaker(new FourSeasonsPizzaFactory("FourSeasons"));
        }
    }
}

using System;
using Factory_Method.Models;
using Factory_Method.Models.Developer;
using Factory_Method.Models.House;

namespace Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            IGroupPicFactory woodDeveloper = new WoodFactory();
            IHouse woodHouse = woodDeveloper.Create();

            IGroupPicFactory panelDeveloper = new PanelFactory();
            IHouse panelHouse = panelDeveloper.Create();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Factory_Method.Models.House;

namespace Factory_Method.Models.Developer
{
    class PanelFactory : IGroupPicFactory
    {
        public IHouse Create()
        {
            return new PanelHouse();
        }

        public void Sell()
        {
            throw new NotImplementedException();
        }

        public void SwitchWallColor()
        {
            throw new NotImplementedException();
        }
    }
}

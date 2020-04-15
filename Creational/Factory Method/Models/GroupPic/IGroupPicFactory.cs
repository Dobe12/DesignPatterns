using System;
using System.Collections.Generic;
using System.Text;
using Factory_Method.Models.House;

namespace Factory_Method.Models.Developer
{
    interface IGroupPicFactory
    {
        IHouse Create();

        void Sell();
        void SwitchWallColor();

    }
}

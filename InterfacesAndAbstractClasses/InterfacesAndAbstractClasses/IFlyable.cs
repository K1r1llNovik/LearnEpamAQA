using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesAndAbstractClasses
{
    interface IFlyable
    {
        void FlyTo(Coordinate newCoordinate);

        DateTime GetFlyTime(Coordinate newCoordinate);
    }
}

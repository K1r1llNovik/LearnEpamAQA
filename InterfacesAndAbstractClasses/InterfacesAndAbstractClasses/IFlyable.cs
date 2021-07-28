using System;

namespace InterfacesAndAbstractClasses
{
    interface IFlyable
    {
        void FlyTo(Coordinate newCoordinate);

        DateTime GetFlyTime(Coordinate newCoordinate);
    }
}

using System;

namespace InterfacesAndAbstractClasses
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Bird bird = new Bird(new Coordinate(10, 5, 3));
            Plane plane = new Plane(1300, new Coordinate(10, 3, 6));
            Drone drone = new Drone(new Coordinate(115, 44, 3));
            Coordinate coordinate = new Coordinate(115, 44, 3);
            Console.WriteLine(coordinate.GetDistance(new Coordinate(550, 320, 150)));

            Console.WriteLine(plane.GetFlyTime(new Coordinate(1150, 780, 980)));

            Console.WriteLine(drone.GetFlyTime(new Coordinate(550, 320, 150)));

            Console.WriteLine(bird.GetFlyTime(new Coordinate(20, 13, 50)));
        }
    }
}

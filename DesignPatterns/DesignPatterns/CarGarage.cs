using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns
{
    public class CarGarage
    {
        private static CarGarage _garage;

        private List<Car> _carGarage;

        private CarGarage()
        {
            _carGarage = new List<Car>();
        }

        private static CarGarage GetCarGarage()
        {
            if (_garage == null)
            {
                _garage = new CarGarage();
            }

            return _garage;
        }

        public void Add(Car car)
        {
            _carGarage.Add(car);
        }

        public int GetCountTypes()
        {
            return _carGarage.GroupBy(c => c.Brand).Count();
        }

        public int GetCountAll()
        {
            return _carGarage.Sum(c => c.Count);
        }

        public double GetAveragePrice()
        {
            return _carGarage.Sum(c => c.PriceOfOne) / _carGarage.Count();
        }

        public double GetAveragePriceType(string brand)
        {
            return _carGarage.Where(c => c.Brand == brand).Sum(c => c.PriceOfOne) / 
                _carGarage.Where(c => c.Brand == brand).Count();
        }
    }
}

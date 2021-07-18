using System;

namespace OOP
{
    [Serializable]
    public class Scooter : Vehicle
    {
        private byte _numberOfMirrors;
        
        /// <summary>
        /// Get and set number of mirrors
        /// </summary>
        public byte NumberOfMirrors
        {
            get
            {
                return _numberOfMirrors;
            }

            set
            {
                if (value < 1 || value > 2)
                {
                    throw new ArgumentException(nameof(_numberOfMirrors));
                }
                _numberOfMirrors = value;
            }
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Scooter() { }

        /// <summary>
        /// Constructor initializes class fields
        /// </summary>
        /// <param name="numberOfMirrors"></param>
        /// <param name="chassis"></param>
        /// <param name="engine"></param>
        /// <param name="transmission"></param>
        public Scooter(byte numberOfMirrors, Chassis chassis, Engine engine, Transmission transmission) 
               : base(chassis, engine, transmission)
        {
            NumberOfMirrors = numberOfMirrors;
        }

        /// <summary>
        /// Method that returns all information about scooter
        /// </summary>
        /// <returns></returns>
        public override string GetInfo()
        {
            return base.GetInfo() + $"Number of mirrors: {NumberOfMirrors}";
        }


    }
}

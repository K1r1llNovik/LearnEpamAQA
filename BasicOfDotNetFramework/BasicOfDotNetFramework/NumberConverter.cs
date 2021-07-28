using System;
using System.Collections.Generic;
using System.Text;

namespace BasicOfDotNetFramework
{
    public static class NumberConverter
    {
        private static Dictionary<uint, string> residualToNumberSystem = new Dictionary<uint, string>
        {
            {0,"0"},{1,"1"},{2,"2"},{3,"3"},{4,"4"},{5,"5"},{6,"6"},{7,"7"},{8,"8"},{9,"9"},{10,"A"},
            {11,"B"},{12,"C"},{13,"D"},{14,"E"},{15,"F"},{16,"G"},{17,"H"},{18,"I"},{19,"J"},{20,"K"}
        };

        /// <summary>
        /// Method which convert number to needed number system
        /// </summary>
        /// <param name="number">Number which needed to convert</param>
        /// <param name="numberSystem">Number system in which we convert</param>
        /// <returns>Converted number</returns>
        public static string GetConvertNumber(uint number, uint numberSystem)
        {
            if (numberSystem < 21 && numberSystem > 1)
            {
                uint residual;
                StringBuilder inverseNumber = new StringBuilder();

                while (true)
                {
                    residual = number % numberSystem;
                    number /= numberSystem;
                    inverseNumber.Insert(0, residualToNumberSystem[residual]);

                    if (number == 0)
                    {
                        break;
                    }
                }

                return inverseNumber.ToString();
            }

            else
            {
                throw new ArgumentOutOfRangeException("Number system should be equal between 2 and 20");
            }
        }
    }
}

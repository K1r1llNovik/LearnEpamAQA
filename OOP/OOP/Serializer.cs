using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

namespace OOP
{
    /// <summary>
    /// Class with serialization
    /// </summary>
    public static class Serializer<T>
    {
        /// <summary>
        /// Method that serialize objects of type T
        /// </summary>
        /// <param name="file">Link to XML file</param>
        /// <param name="list">List of objects of type T for serialization</param>
        public static void Serialize(string file, List<T> list)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<T>));

            using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, list);
            }
        }
    }
}

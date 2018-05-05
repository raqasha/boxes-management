using Krd4.Helpers.Interfaces;
using Krd4.Models;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Krd4.Helpers
{
    class BoxFileHelper : IFileHelper<Box>
    {
        public IList<Box> ReadFromFile(string filename)
        {
            IList<Box> result = new List<Box>();
            using (var streamReader = new StreamReader(filename))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Box>));
                result = (List<Box>)serializer.Deserialize(streamReader);
            }
            return result;
        }

        public void SaveToFile(IList<Box> data, string filename)
        {
            using (var streamWriter = new StreamWriter(filename))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Box>));
                serializer.Serialize(streamWriter, data);
            }
        }

    }
}

using Krd4.Helpers.Interfaces;
using Krd4.Models;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Krd4.Helpers
{
    class UserFileHelper : IFileHelper<User>
    {
        public IList<User> ReadFromFile(string filename)
        {
            IList<User> result = new List<User>();
            using (var streamReader = new StreamReader(filename))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
                result = (List<User>)serializer.Deserialize(streamReader);
            }
            return result;
        }

        public void SaveToFile(IList<User> data, string filename)
        {
            using (var streamWriter = new StreamWriter(filename))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
                serializer.Serialize(streamWriter, data);
            }
        }
    }
}

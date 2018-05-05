using System.Xml.Serialization;

namespace Krd4.Models
{
    public abstract class BaseModel
    {
        [XmlElement("Id")]
        public int Id { get; set; }
    }
}

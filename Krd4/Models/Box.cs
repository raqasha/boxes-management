using Krd4.Enums;
using System.Xml.Serialization;

namespace Krd4.Models
{
    public class Box : BaseModel
    {
        [XmlElement("Number")]
        public int Number { get; set; }
        [XmlElement("Status")]
        public StatusEnum Status { get; set; } 
        [XmlElement("UserId")]
        public int UserId { get; set; }
    }
}

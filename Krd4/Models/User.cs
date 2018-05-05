using Krd4.Enums;
using System.Xml.Serialization;

namespace Krd4.Models
{
    public class User : BaseModel
    {
        [XmlElement("Login")]
        public string Login { get; set; }
        [XmlElement("Password")]
        public string Password { get; set; }
        [XmlElement("TypeOfUser")]
        public RoleEnum TypeOfUser { get; set; }
    }
}

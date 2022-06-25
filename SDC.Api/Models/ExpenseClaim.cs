using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace SDC.Api.Models
{
    [XmlRoot(ElementName = "claim")]
    [Serializable]
    public class ExpenseClaim
    {
        [XmlElement(ElementName = "expense")]
        public Expense Expense { get; set; }

        [XmlElement(ElementName = "vendor")]
        public string Vendor { get; set; }

        [XmlElement(ElementName = "description")]
        public string Description { get; set; }

        [XmlElement(ElementName = "date")]
        public string Date { get; set; }
    }
}

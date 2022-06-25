using System.Xml.Serialization;

namespace SDC.Api.Models
{
    [XmlRoot(ElementName = "expense")]
    [Serializable]
    public class Expense
    {
        #region Public Properties

        [XmlElement(ElementName = "cost_centre")]
        public string CostCentre { get; set; }

        [XmlElement(ElementName = "total")]
        public string Total { get; set; }

        [XmlElement(ElementName = "payment_method")]
        public string PaymentMethod { get; set; }

        #endregion
    }
}

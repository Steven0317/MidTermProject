using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace MedPortal
{
    [XmlRoot(ElementName = "DocBill")]
    public class DocBill
    {
        [XmlAttribute(DataType = "string")]
        public string social;
        [XmlAttribute(DataType = "string")]
        public string office;
        [XmlAttribute(DataType = "string")]
        public string time;
        [XmlAttribute(DataType = "string")]
        public string location;
        [XmlAttribute(DataType = "string")]
        public string bill;
        [XmlAttribute(DataType = "double")]
        public double price;
        [XmlAttribute(DataType = "string")]
        public string paid;
        [XmlAttribute(DataType = "double")]
        public double left;
        [XmlAttribute(DataType = "string")]
        public string invoice;

        public DocBill() { }
        public DocBill(string social, string office, string time, string location, string bill, double price, string paid, double left, string invoice)
        {
            this.social = social;
            this.office = office;
            this.time = time;
            this.location = location;
            this.bill = bill;
            this.price = price;
            this.paid = paid;
            this.left = left;
            this.invoice = invoice;
        }

        public string SSN { get { return social; } set { value = social; } }
        public string Office { get { return office; } set { value = office; } }
        public string Time { get { return time; } set { value = time; } }
        public string Location { get { return location; } set { value = location; } }
        public string Bill { get { return bill; } set { value = bill; } }
        public double PriceOfBill { get { return price; } set { value = price; } }
        public string IsBillPaid { get { return paid; } set { value = paid; } }
        public double LeftToPay { get { return left; } set { value = left; } }
        public string Invoice { get { return invoice;} set {value = invoice;} }
    }
}

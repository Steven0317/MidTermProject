using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedPortal
{
    public class DocBill
    {
        public string social;
        public string office;
        public string time;
        public string location;
        public char bill;
        public double price;
        public char paid;
        public double left;

        public DocBill() { }
        public DocBill(string social, string office, string time, string location, char bill, double price, char paid, double left)
        {
            this.social = social;
            this.office = office;
            this.time = time;
            this.location = location;
            this.bill = bill;
            this.price = price;
            this.paid = paid;
            this.left = left;
        }

        public string SSN { get { return social; } set { value = social; } }
        public string Office { get { return office; } set { value = office; } }
        public string Time { get { return time; } set { value = time; } }
        public string Location { get { return location; } set { value = location; } }
        public char Bill { get { return bill; } set { value = bill; } }
        public double PriceOfBill { get { return bill; } set { value = bill; } }
        public char IsBillPaid { get { return paid; } set { value = paid; } }
        public double LeftToPay { get { return left; } set { value = left; } }

    }
}

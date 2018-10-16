using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedPortal
{
    public class RXinfo
    {
        public string social;
        public string prescriptionName;
        public int scriptNumber;
        public string date;
        public string expiration;
        public int refills;


        public RXinfo() { }
        public RXinfo(string social, string prescriptionName, int scriptNumber, string date, string expiration, int refills)
        {
            this.social = social;
            this.prescriptionName = prescriptionName;
            this.scriptNumber = scriptNumber;
            this.date = date;
            this.expiration = expiration;
            this.refills = refills;
        }

        public string SSN { get { return social; } set { value = social; } }
        public string PrescriptionName { get { return prescriptionName; } set { value = prescriptionName; } }
        public int ScriptNumber { get { return scriptNumber; } set { value = scriptNumber; } }
        public string FillDate { get { return date; } set { value = date; } }
        public string ExpirationDate { get { return expiration; } set { value = expiration; } }
        public int RefillAvailable { get { return refills; } set { value = refills; } }
    }
}

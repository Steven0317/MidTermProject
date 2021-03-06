﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace MedPortal
{
    [XmlRoot(ElementName = "RXinfo")]
    public class RXinfo
    {
        [XmlAttribute(DataType = "string")]
        public string social;
        [XmlAttribute(DataType = "string")]
        public string prescriptionName;
        [XmlAttribute(DataType = "long")]
        public long scriptNumber;
        [XmlAttribute(DataType = "string")]
        public string date;
        [XmlAttribute(DataType = "string")]
        public string expiration;
        [XmlAttribute(DataType = "int")]
        public int refills;
        


        public RXinfo() { }
        public RXinfo(string social, string prescriptionName, long scriptNumber, string date, string expiration, int refills)
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
        public long ScriptNumber { get { return scriptNumber; } set { value = scriptNumber; } }
        public string FillDate { get { return date; } set { value = date; } }
        public string ExpirationDate { get { return expiration; } set { value = expiration; } }
        public int RefillAvailable { get { return refills; } set { value = refills; } }
        
    }
}

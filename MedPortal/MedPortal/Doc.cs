using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedPortal
{
    //helper class for drs
    public class Doc
    {
        public string location;
        public string doctor;

        public Doc() { }

        public Doc(string location, string doctor)
        {
            this.location = location;
            this.doctor = doctor;
        }

        public string Loation { get { return location; } set { value = location; } }
        public string Doctor { get { return doctor; } set { value = doctor; } }
    }
}

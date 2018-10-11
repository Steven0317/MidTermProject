using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedPortal
{
    public class Individual
    {
        public string first;
        public string last;
        public string user;
        public string pass;
        public int age;
        public string dob;
        public string allergies;
        public int social;
        public string pcp;
        public string insuranceProvider;
        public int cc;
        public string name;
        public string expDate;
        public int ccv;


        public Individual() { }
        
        public Individual(string first, string last, string user, string pass, int age, string dob, string allergies, int social, string pcp, string insuranceProvider, int cc, string name, string expDate, int ccv)
        {
            this.first = first;
            this.last = last;
            this.user = user;
            this.pass = pass;
            this.age = age;
            this.dob = dob;
            this.allergies = allergies;
            this.social = social;
            this.pcp = pcp;
            this.insuranceProvider = insuranceProvider;
            this.cc = cc;
            this.name = name;
            this.expDate = expDate;
            this.ccv = ccv;
        }

        public string FirstName { get { return first; } set { value = first; } }
        public string LastName { get {return last; } set {value = last; } }
        public string Username { get {return user; } set {value = user; } }
        public string Password { get {return pass; } set {value = pass; } }
        public int Age { get {return age; } set {value = age; } }
        public string DOB { get {return dob; } set {value = dob; } }
        public string Allergies { get {return allergies; } set {value = allergies; } }
        public int SSN { get {return social; } set {value = social; } }
        public string PCP { get {return pcp; } set {value = pcp; } }
        public string IP { get {return insuranceProvider; } set {value = insuranceProvider; } }
        public int CC { get {return cc; } set {value = cc; } }
        public string Name { get {return name; } set {value = name; } }
        public string EXP { get {return expDate; } set {value = expDate; } }
        public int CCV { get {return ccv; } set {value = ccv; } }

    }
}

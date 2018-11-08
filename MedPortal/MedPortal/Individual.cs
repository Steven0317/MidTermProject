using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Xml.Serialization;

namespace MedPortal
{
    [XmlRoot(ElementName ="Inividual")]
    public class Individual
    {
        [XmlAttribute(DataType = "string")]
        public string first;
        [XmlAttribute(DataType = "string")]
        public string last;
        [XmlAttribute(DataType = "string")]
        public string user;
        [XmlAttribute(DataType = "string")]
        public string pass;
        [XmlAttribute(DataType = "int")]
        public int age;
        [XmlAttribute(DataType = "string")]
        public string dob;
        [XmlAttribute(DataType = "string")]
        public string allergies;
        [XmlAttribute(DataType = "string")]
        public string social;
        [XmlAttribute(DataType = "string")]
        public string pcp;
        [XmlAttribute(DataType = "string")]
        public string insuranceProvider;
        [XmlAttribute(DataType = "string")]
        public string salt;
        [XmlElement(typeof(ImageSource))]
        public ImageSource userImage;
        


        public Individual() { }
        
        public Individual(string first, string last, string user, string pass, int age, string dob, string allergies,
                          string social, string pcp, string insuranceProvider, string salt)
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
            this.salt = salt;
            
        }

        public string FirstName { get { return first; } set { value = first; } }
        public string LastName { get {return last; } set {value = last; } }
        public string Username { get {return user; } set {value = user; } }
        public string Password { get {return pass; } set {value = pass; } }
        public int Age { get {return age; } set {value = age; } }
        public string DOB { get {return dob; } set {value = dob; } }
        public string Allergies { get {return allergies; } set {value = allergies; } }
        public string SSN { get {return social; } set {value = social; } }
        public string PCP { get {return pcp; } set {value = pcp; } }
        public string IP { get {return insuranceProvider; } set {value = insuranceProvider; } }
        public string Salt { get { return salt; } set { value = salt; } }
        //public ImageSource UserImage { get { return Convert.FromBase64String(userImage);  } set { value = Convert.FromBase64String(userImage); }  }

    }
}

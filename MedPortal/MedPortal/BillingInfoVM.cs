using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Xml.Serialization;

namespace MedPortal
{
    public class BillingInfoVM : INotifyPropertyChanged
    {
        /// <summary>
        /// class init
        /// </summary>
        public BillingInfoVM()
        {
            Left = Billing.UserBill.left.ToString();
            UserLogin = LoginPage.LoggedinUser.FirstName + " " + LoginPage.LoggedinUser.LastName;

            if (LoginPage.LoggedinUser.UserImage == null)
            {
                string stringPath = "UserImages/default-user-image.png";
                BitmapImage logo = new BitmapImage();
                logo.BeginInit();
                logo.UriSource = new Uri(stringPath, UriKind.Relative);
                logo.EndInit();

                Image = logo;
            }
            else
            {
                Image = LoginPage.LoggedinUser.userImage;
            }
        }

        XmlSerializer serializer = new XmlSerializer(typeof(List<DocBill>));

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        private string _Left;

        public string Left
        {
            get { return  "Amount: " + _Left; }
            set {
                _Left = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Left"));
            }
        }

        private ImageSource _Image;

        public ImageSource Image
        {
            get { return _Image; }
            set {
                _Image = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Image"));
            }
        }


        private string _UserLogin;

        public string UserLogin
        {
            get { return _UserLogin; }
            set
            {
                _UserLogin = value;
                PropertyChanged(this, new PropertyChangedEventArgs("userLogin"));
            }
        }

        private string _CreditCard;

        public string CreditCard
        {
            get { return _CreditCard; }
            set {
                _CreditCard = value;
                PropertyChanged(this, new PropertyChangedEventArgs("CreditCard"));
            }
        }

        private string _exp;

        public string EXP
        {
            get { return _exp; }
            set {
                _exp = value;
                PropertyChanged(this, new PropertyChangedEventArgs("EXP"));
            }
        }

        private string _Sec;

        public string Sec
        {
            get { return _Sec; }
            set {
                _Sec = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Sec"));
            }
        }

        private string _addr;

        public string Addr
        {
            get { return _addr; }
            set {
                _addr = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Addr"));
            }
        }

        private string _City;

        public string City
        {
            get { return _City; }
            set {
                _City = value;
                PropertyChanged(this, new PropertyChangedEventArgs("City"));
            }
        }

        private string _Zip;

        public string Zip
        {
            get { return _Zip; }
            set {
                _Zip = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Zip"));
            }
        }




        //digit validation
        private bool ValidateDigit(string test)
        {
            return test.All("0123456789-/".Contains);
        }

        //validate entries for bill payment
        private bool ValidateEntries()
        {
            bool ccValid;
            bool expvalid;
            bool secValid;
            bool addrValid;
            bool cityValid;
            bool zipValid;

            ccValid = string.IsNullOrWhiteSpace(_CreditCard) ? false : ValidateDigit(_CreditCard);
            

            expvalid = string.IsNullOrWhiteSpace(_exp) ? false : ValidateDigit(_exp);
            

            secValid = string.IsNullOrWhiteSpace(_Sec) ? false : ValidateDigit(_Sec);
            

            addrValid = string.IsNullOrWhiteSpace(_addr) ? false : true;
            

            cityValid = string.IsNullOrWhiteSpace(_City) ? false : true;
            

            zipValid = string.IsNullOrWhiteSpace(_Zip) ? false : ValidateDigit(_Zip);
           


            return ccValid && expvalid && secValid && addrValid && cityValid && zipValid;
        }

        /// <summary>
        /// validates entered info then pays the selected bill on file
        /// </summary>
        /// <param name="obj"></param>
        private void Pay_Click(object obj)
        {
            if (ValidateEntries())
            {

                foreach (DocBill bill in HomePage.DocCollection)
                {
                    if (bill.social == LoginPage.LoggedinUser.social)
                    {
                        foreach (DocBill user in Billing.userBill)
                        {
                            if (bill.left == user.left)
                            {
                                bill.left = 0;
                            }
                        }


                    }
                }

                if (HomePage.DocCollection.Count == 0 && File.Exists("doctors.xml"))
                {
                    File.Delete("doctors.xml");
                }
                else
                {
                    using (FileStream filestream = new FileStream("doctors.xml", FileMode.Create, FileAccess.ReadWrite))
                    {
                        serializer.Serialize(filestream, HomePage.DocCollection);
                    }

                }

                MessageBox.Show("Payment Successful");
            }
            else
            {
                MessageBox.Show("Incomplete Information, please correct and resubmit");
            }
        }

        public ICommand PayEvent
        {
            get
            {
                if(_userPay == null)
                {
                    _userPay = new DelegateCommand(Pay_Click);
                }
                return _userPay;
            }
        }
        DelegateCommand _userPay;
    }
}

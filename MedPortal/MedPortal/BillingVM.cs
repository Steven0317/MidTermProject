using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace MedPortal
{
    class BillingVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public BillingVM() {

            
            UserLogin = LoginPage.LoggedinUser.FirstName + " " + LoginPage.LoggedinUser.LastName;

            GetBills = getLoggedInDocBill();

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

        private ImageSource _Image;

        public ImageSource Image
        {
            get { return _Image; }
            set
            {
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


        private List<DocBill> docBills;

        public List<DocBill> GetBills
        {
            get { return docBills; }
            set
            {
                docBills = value;
                PropertyChanged(this, new PropertyChangedEventArgs("GetBills"));
            }
        }


        private List<DocBill> getLoggedInDocBill()
        {
            List<DocBill> userBill = new List<DocBill>();

            userBill = (from user in HomePage.DocCollection
                        where user.social == LoginPage.LoggedinUser.social
                        select user).ToList();

            return userBill;
        }
    }
}

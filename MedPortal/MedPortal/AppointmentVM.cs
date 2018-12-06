using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace MedPortal
{
    public class AppointmentVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
       
        /// <summary>
        /// class init
        /// </summary>
        public AppointmentVM()
        {
            UserLogin = LoginPage.LoggedinUser.FirstName + " " + LoginPage.LoggedinUser.LastName;

            UserObserv = getLoggedInDoc();

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
                PropertyChanged(this, new PropertyChangedEventArgs("UserLogin"));
            }
        }

        private ObservableCollection<DocBill> _userObserv;

        public ObservableCollection<DocBill> UserObserv
        {
            get { return _userObserv; }
            set
            {
                _userObserv = value;
                PropertyChanged(this, new PropertyChangedEventArgs("UserObserv"));
            }
        }

        /// <summary>
        /// gets users appointments
        /// </summary>
        /// <returns></returns>
        private ObservableCollection<DocBill> getLoggedInDoc()
        {
            List<DocBill> userDoc = new List<DocBill>();

            userDoc = (from user in HomePage.DocCollection
                       where user.social == LoginPage.LoggedinUser.social
                       select user).ToList();

            ObservableCollection<DocBill> temp = new ObservableCollection<DocBill>(userDoc);
            return temp;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Xml.Serialization;

namespace MedPortal
{
    class PrescriptionVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        XmlSerializer serializer = new XmlSerializer(typeof(List<RXinfo>));
        public List<RXinfo> userRX = new List<RXinfo>();

        public PrescriptionVM()
        {
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

            userObsrv = getLoggedInRX();

        }

        private RXinfo _SelectedItem;

        public RXinfo SelectedItem
        {
            get { return _SelectedItem; }
            set
            {
                _SelectedItem = value;
                PropertyChanged(this, new PropertyChangedEventArgs("_SelectedPet"));
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

        private ObservableCollection<RXinfo> userObsrv;
        public ObservableCollection<RXinfo> UserObsrv
        {
            get { return userObsrv; }
            set
            {
                userObsrv = value;
                PropertyChanged(this, new PropertyChangedEventArgs("UserObsrv"));
            }
        }


        private ObservableCollection<RXinfo> getLoggedInRX()
        {
            List<RXinfo> userRX = new List<RXinfo>();

            userRX = (from user in HomePage.RXCollection
                      where user.social == LoginPage.LoggedinUser.social
                      select user).ToList();

            ObservableCollection<RXinfo> temp = new ObservableCollection<RXinfo>(userRX);
            return temp;
        }


        private void Refill_Click(object obj)
        {
            if (SelectedItem != null)
            {
                RXinfo temp = SelectedItem;

                if (temp.refills == 0)
                {
                    MessageBox.Show("No more refills available");
                }
                else
                {
                    foreach (RXinfo script in HomePage.RXCollection)
                    {
                        if (script.scriptNumber == temp.scriptNumber)
                        {
                            script.refills--;

                        }

                    }
                    UserObsrv = getLoggedInRX();
                    if (HomePage.RXCollection.Count == 0 && File.Exists("rx.xml"))
                    {
                        File.Delete("rx.xml");
                    }
                    else
                    {
                        using (FileStream filestream = new FileStream("rx.xml", FileMode.Create, FileAccess.ReadWrite))
                        {
                            serializer.Serialize(filestream, HomePage.RXCollection);
                        }

                    }

                }
            }
        }

        public ICommand Refill_Command
        {
            get
            {
                if(_refill == null)
                {
                    _refill = new DelegateCommand(Refill_Click);
                }
                return _refill;
            }
        }
        DelegateCommand _refill;
    }
}

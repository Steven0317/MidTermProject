using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MedPortal
{
    /// <summary>
    /// Interaction logic for AccountManagement.xaml
    /// </summary>
    public partial class AccountManagement : Page
    {
        public AccountManagement()
        {
            InitializeComponent();

            Welcome.Text += LoginPage.LoggedinUser.FirstName + " " + LoginPage.LoggedinUser.LastName;

            Name.Text = LoginPage.LoggedinUser.FirstName + " " + LoginPage.LoggedinUser.LastName;
            dob.Text = LoginPage.LoggedinUser.dob;

            string tempsocial = LoginPage.LoggedinUser.social;

            StringBuilder sb = new StringBuilder(tempsocial);

            for(int i = 0; i < 6; ++i)
            {
                if(i != 3)
                sb[i] = 'X';
            }

            social.Text = sb.ToString();

            pcp.Text = LoginPage.LoggedinUser.pcp;
            insurance.Text = LoginPage.LoggedinUser.insuranceProvider;
            allergies.Text = LoginPage.LoggedinUser.allergies;


            if (LoginPage.LoggedinUser.UserImage == null)
            {
                string stringPath = "UserImages/default-user-image.png";
                BitmapImage logo = new BitmapImage();
                logo.BeginInit();
                logo.UriSource = new Uri(stringPath, UriKind.Relative);
                logo.EndInit();

                userImage.Source = logo;
            }
            else
            {
                userImage.Source = LoginPage.LoggedinUser.userImage;
            }

        }

        private void Appointment_Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Appointment.xaml", UriKind.Relative));
        }

        private void Presciption_Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Prescription.xaml", UriKind.Relative));
        }

        private void Billing_Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Billing.xaml", UriKind.Relative));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("HomePage.xaml", UriKind.Relative));
        }

        private void Logout_Button_Click(object sender, RoutedEventArgs e)
        {
            LoginPage.LoggedinUser = null;
            NavigationService.Navigate(new Uri("LoginPage.xaml", UriKind.Relative));
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("AccountManagement.xaml", UriKind.Relative));
        }

       
        //opens file explorer to select anew user default picture
        private void Change_Picture_Click(object sender, RoutedEventArgs e)
        {

            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
           
            dlg.DefaultExt = ".png";
            dlg.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";

            if (dlg.ShowDialog() == true)
            {

                Image myImage = new Image();
                myImage.Source = new BitmapImage(new Uri(dlg.FileName));
                myImage.Source = new ImageSourceConverter().ConvertFromString(new Uri(dlg.FileName).ToString()) as ImageSource;
                LoginPage.LoggedinUser.userImage = myImage.Source;
                userImage.Source = LoginPage.LoggedinUser.userImage;
                 
               
            }
        }
    }
}

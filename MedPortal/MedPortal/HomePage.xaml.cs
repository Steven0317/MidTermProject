using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
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
using System.Xml.Serialization;

namespace MedPortal
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {

        XmlSerializer serializer = new XmlSerializer(typeof(List<DocBill>));
        XmlSerializer RXserializer = new XmlSerializer(typeof(List<RXinfo>));
        public static List<DocBill> DocCollection = new List<DocBill>();
        public static List<RXinfo> RXCollection = new List<RXinfo>();
        public static List<Doc> Doctors = new List<Doc>();

        public HomePage()
        {
            InitializeComponent();
            Welcome.Text +=  LoginPage.LoggedinUser.FirstName + " " + LoginPage.LoggedinUser.LastName;

            try
            {
                ReadDocFromMemory("doctors.xml");
                ReadRXFromMemory("rx.xml");

            }
            catch (Exception ex)
            {
                Console.WriteLine("--------Xml Read Error--------");
                MessageBox.Show($"Unable to read xml file\ninner excepetion:{ex.InnerException.Message} ");
            }




            List<DocBill> userDoc = new List<DocBill>();
            userDoc = getLoggedInDocBill();

            List<DocBill> userBill = new List<DocBill>();
            userBill = getLoggedInBill();

            List<RXinfo> userRX = new List<RXinfo>();
            userRX = getLoggedInRX();

            if (userDoc.Any())
            {
                AppointmentGrid.ItemsSource = userDoc;
            }
            else
            {
                AppointmentGrid.Visibility = Visibility.Hidden;
                AppText.Visibility = Visibility.Visible;
            }

                if (userBill.Any())
                {
                    BillGrid.ItemsSource = userBill;
                }
                if (!userDoc.Any())
                {
                    BillGrid.Visibility = Visibility.Hidden;
                    BillText.Visibility = Visibility.Visible;
                }
            
            if (userRX.Any())
            {
                RXGrid.ItemsSource = userRX; ;
            }
            else
            {
                RXGrid.Visibility = Visibility.Hidden;
                RXText.Visibility = Visibility.Visible;
            }

            Doctors.Add(new Doc("Watson Clinic South", "Dr. Bailey"));
            Doctors.Add(new Doc("Watson Clinic South", "Dr. Danum"));
            Doctors.Add(new Doc("Watson Clinic South", "Dr. Trent"));
            Doctors.Add(new Doc("Watson Clinic South", "Dr. Xavier"));
            Doctors.Add(new Doc("East Bay Clinic", "Dr. Adams"));
            Doctors.Add(new Doc("East Bay Clinic", "Dr. Grange"));
            Doctors.Add(new Doc("East Bay Clinic", "Dr. Miley"));
            Doctors.Add(new Doc("East Bay Clinic", "Dr. Poetl"));
            Doctors.Add(new Doc("Tampa General Hospital", "Dr. Carmen"));
            Doctors.Add(new Doc("Tampa General Hospital", "Dr. Hurtak"));
            Doctors.Add(new Doc("Tampa General Hospital", "Dr. Iguodola"));
            Doctors.Add(new Doc("Tampa General Hospital", "Dr. Ransel"));
            Doctors.Add(new Doc("South Shore Regional", "Dr. Bogaerts"));
            Doctors.Add(new Doc("South Shore Regional", "Dr. Mallov"));
            Doctors.Add(new Doc("South Shore Regional", "Dr. Martinez"));
            Doctors.Add(new Doc("South Shore Regional", "Dr. Swihart"));

        }

        private List<RXinfo> getLoggedInRX()
        {
            List<RXinfo> userRX = new List<RXinfo>();

            userRX = (from user in RXCollection
                           where user.social == LoginPage.LoggedinUser.social 
                           select user).ToList();

            return userRX;
        }

        private List<DocBill> getLoggedInBill()
        {
            List<DocBill> userDocBill = new List<DocBill>();

            userDocBill = (from user in DocCollection
                           where user.social == LoginPage.LoggedinUser.social && user.Bill != "N"
                           select user).ToList();

            return userDocBill;
        }

        private List<DocBill> getLoggedInDocBill()
        {
            List<DocBill> userBill = new List<DocBill>();

            userBill = (from user in DocCollection
                          where user.social == LoginPage.LoggedinUser.social
                          select user).ToList();

            return userBill;
        }

        private void ReadDocFromMemory(string path)
        {

            if (File.Exists(path))
            {
                using (FileStream readStream = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    DocCollection = serializer.Deserialize(readStream) as List<DocBill>;
                }

            }
        }

        private void ReadRXFromMemory(string path)
        {

            if (File.Exists(path))
            {
                using (FileStream readStream = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    RXCollection = RXserializer.Deserialize(readStream) as List<RXinfo>;
                }

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

        private void Logout_Button_Click(object sender, RoutedEventArgs e)
        {
            LoginPage.LoggedinUser = null;
            NavigationService.Navigate(new Uri("LoginPage.xaml", UriKind.Relative));
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("AccountManagement.xaml", UriKind.Relative));
        }

        
    }
}

using System;
using System.Collections.Generic;
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

        public HomePage()
        {
            InitializeComponent();
            //Welcome.Text +=  " " + LoginPage.LoggedinUser.FirstName + "!";

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
    }
}

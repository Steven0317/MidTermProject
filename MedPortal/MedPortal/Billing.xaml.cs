using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
    /// Interaction logic for Billing.xaml
    /// </summary>
    public partial class Billing : Page
    {

        XmlSerializer serializer = new XmlSerializer(typeof(List<DocBill>));
        public static List<DocBill> userBill = new List<DocBill>();
        public List<DocBill> userDoc = new List<DocBill>();
        public static DocBill UserBill;


        public Billing()
        {
            InitializeComponent();

            BillingVM bill = new BillingVM();

            DataContext = bill;
            userBill = getLoggedInBill();

   
        }

        /// <summary>
        /// Sidebar navigation buttons 
        /// </summary>
        
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
        private void Question_Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Chat.xaml", UriKind.Relative));
        }
        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("AccountManagement.xaml", UriKind.Relative));
        }


        /// <summary>
        /// Logout button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Logout_Button_Click(object sender, RoutedEventArgs e)
        {
            LoginPage.LoggedinUser = null;
            NavigationService.Navigate(new Uri("LoginPage.xaml", UriKind.Relative));
        }

        

        private List<DocBill> getLoggedInBill()
        {
            List<DocBill> userDocBill = new List<DocBill>();

            userDocBill = (from user in HomePage.DocCollection
                           where user.social == LoginPage.LoggedinUser.social && user.Bill != "N"
                           select user).ToList();

            return userDocBill;
        }


        private void Pay_Click(object sender, RoutedEventArgs e)
        {

            UserBill =  (DocBill) BillGrid.SelectedItem;

            NavigationService.Navigate(new Uri("BillingInfo.xaml", UriKind.Relative));

        }
    }
}
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
    /// Interaction logic for BillingInfo.xaml
    /// </summary>
    public partial class BillingInfo : Page
    {

        XmlSerializer serializer = new XmlSerializer(typeof(List<DocBill>));

        public BillingInfo()
        {
            InitializeComponent();
            if(Billing.UserBill != null)
            {
                LeftBox.Text += Billing.UserBill.left.ToString();
            }
            else
            {
                LeftBox.Visibility = Visibility.Hidden;
                EnterInfo.Visibility = Visibility.Hidden;
                CC.Visibility = Visibility.Hidden;
                CBox.Visibility = Visibility.Hidden;
                Exp.Visibility = Visibility.Hidden;
                ExpBox.Visibility = Visibility.Hidden;
                Sec.Visibility = Visibility.Hidden;
                SecBox.Visibility = Visibility.Hidden;
                BillAddr.Visibility = Visibility.Hidden;
                BillCity.Visibility = Visibility.Hidden;
                BillZip.Visibility = Visibility.Hidden;
                BillBox.Visibility = Visibility.Hidden;
                CityBox.Visibility = Visibility.Hidden;
                ZipBox.Visibility = Visibility.Hidden;
                Pay.Visibility = Visibility.Hidden;
                BillText.Visibility = Visibility.Visible;

            }

            Welcome.Text += LoginPage.LoggedinUser.FirstName + " " + LoginPage.LoggedinUser.LastName;

        }


        //naviagte buttons for other pages
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

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("AccountManagement.xaml", UriKind.Relative));
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

            ccValid = string.IsNullOrWhiteSpace(CBox.Text) ? false : ValidateDigit(CBox.Text);
            CC.Foreground = ccValid ? Brushes.Black : Brushes.Coral;

            expvalid = string.IsNullOrWhiteSpace(ExpBox.Text) ? false : ValidateDigit(ExpBox.Text);
            Exp.Foreground = expvalid ? Brushes.Black : Brushes.Coral;

            secValid = string.IsNullOrWhiteSpace(SecBox.Text) ? false : ValidateDigit(SecBox.Text);
            Sec.Foreground = secValid ? Brushes.Black : Brushes.Coral;

            addrValid = string.IsNullOrWhiteSpace(BillBox.Text) ? false : true;
            BillAddr.Foreground = addrValid ? Brushes.Black : Brushes.Coral;

            cityValid = string.IsNullOrWhiteSpace(CityBox.Text) ? false : true;
            BillCity.Foreground = cityValid ? Brushes.Black : Brushes.Coral;

            zipValid = string.IsNullOrWhiteSpace(ZipBox.Text) ? false : ValidateDigit(ZipBox.Text);
            BillZip.Foreground = zipValid ? Brushes.Black : Brushes.Coral;

            return ccValid && expvalid && secValid && addrValid && cityValid && zipValid;
        }

        //digit validation
        private bool ValidateDigit(string test)
        {
            return test.All("0123456789-/".Contains);
        }

        //logout function
        private void Logout_Button_Click(object sender, RoutedEventArgs e)
        {
            LoginPage.LoggedinUser = null;
            NavigationService.Navigate(new Uri("LoginPage.xaml", UriKind.Relative));
        }

        //payment validation
        private void Pay_Click(object sender, RoutedEventArgs e)
        {
            if(ValidateEntries())
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

                NavigationService.Navigate(new Uri("Billing.xaml", UriKind.Relative));
            }
        }
    }
}

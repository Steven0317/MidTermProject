using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace MedPortal
{
    /// <summary>
    /// Interaction logic for Billing.xaml
    /// </summary>
    public partial class Billing : Page
    {
        
        public Billing()
        {
            InitializeComponent();

            List<DocBill> userBill = new List<DocBill>();
            userBill = getLoggedInBill();

            List<DocBill> userDoc = new List<DocBill>();
            userDoc = getLoggedInDocBill();

            var item = BillGrid.SelectedItem;

            for (int i = 0; i < userBill.Count; i++)
            {
                if (userBill[i].Bill == "Y")
                {
                    BillGrid.ItemsSource = userBill;
                }
                if (!userDoc.Any())
                {
                    BillGrid.Visibility = Visibility.Hidden;
                    BillText.Visibility = Visibility.Visible;
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("HomePage.xaml", UriKind.Relative));
        }

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

        private List<DocBill> getLoggedInDocBill()
        {
            List<DocBill> userBill = new List<DocBill>();

            userBill = (from user in HomePage.DocCollection
                        where user.social == LoginPage.LoggedinUser.social
                        select user).ToList();

            return userBill;
        }

        private void DataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            List<DocBill> temp = new List<DocBill>();
            string left;
            int index = BillGrid.SelectedIndex;
            double number;
            bool success;

            DocBill item = (DocBill)BillGrid.SelectedItems[index];
            temp.Add(item);
            left = temp[0].LeftToPay.ToString();
            LeftBox.Text = left;
            LeftBox.Visibility = Visibility.Visible;
            LeftBox.IsReadOnly = true;

            PayBox.Visibility = Visibility.Visible;
            success = double.TryParse(PayBox.Text, out number);
            if (success)
            {
                temp[0].LeftToPay = temp[0].LeftToPay - double.Parse(PayBox.Text);

            }
            

        }

       

        private void Pay_Click(object sender, RoutedEventArgs e)
        {
            ObservableCollection<DocBill> temp = new ObservableCollection<DocBill>();
            int index = BillGrid.SelectedIndex;
            DocBill item = (DocBill)BillGrid.SelectedItems[index];
            double left;
            temp.Add(item);
            left = temp[0].LeftToPay - double.Parse(PayBox.Text);
            temp[0].LeftToPay = left;
            
            
        }
    }
}

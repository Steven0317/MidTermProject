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
    /// Interaction logic for Appointment.xaml
    /// </summary>
    public partial class Appointment : Page
    {
        ObservableCollection<DocBill> userObsrv = new ObservableCollection<DocBill>();
        public Appointment()
        {
            InitializeComponent();

            userObsrv = getLoggedInDoc();




            if (userObsrv.Any())
            {
                DocGrid.ItemsSource = userObsrv;
            }
            else
            {
                DocGrid.Visibility = Visibility.Hidden;
                DocText.Visibility = Visibility.Visible;
            }
        }
        private ObservableCollection<DocBill> getLoggedInDoc()
        {
            List<DocBill> userDoc = new List<DocBill>();

            userDoc = (from user in HomePage.DocCollection
                      where user.social == LoginPage.LoggedinUser.social
                      select user).ToList();

            ObservableCollection<DocBill> temp = new ObservableCollection<DocBill>(userDoc);
            return temp;
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

        private void Schedule_ButtonClick (object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("ScheduleAppointment.xaml", UriKind.Relative));
        }
    }
}

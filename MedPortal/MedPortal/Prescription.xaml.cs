using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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
    /// Interaction logic for Prescription.xaml
    /// </summary>
    public partial class Prescription : Page
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<RXinfo>));
        ObservableCollection<RXinfo> userObsrv = new ObservableCollection<RXinfo>();
        public List<RXinfo> userRX = new List<RXinfo>();

        public Prescription()
        {
            InitializeComponent();

            
            userObsrv = getLoggedInRX();

            
            
            
            if (userObsrv.Any())
            {
                RXGrid.ItemsSource = userObsrv;
            }
            else
            {
                RXGrid.Visibility = Visibility.Hidden;
                RXText.Visibility = Visibility.Visible;
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

        private void Refill_Button_Click(object sender, RoutedEventArgs e)
        {
            if(RXGrid.SelectedItem != null)
            {
                RXinfo temp = (RXinfo)(RXGrid.SelectedItem);

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
    }
}

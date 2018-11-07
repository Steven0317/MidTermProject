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
using Xceed.Wpf.Toolkit;
using System.IO;
using System.Xml.Serialization;

namespace MedPortal
{
    /// <summary>
    /// Interaction logic for ScheduleAppointment.xaml
    /// </summary>
    
    public partial class ScheduleAppointment : Page
    {
        ObservableCollection<DocBill> userObsrv = new ObservableCollection<DocBill>();
        XmlSerializer serializer = new XmlSerializer(typeof(List<DocBill>));
        public string location;
        public string time;
        public string provider;
        public ComboBox combo = new ComboBox();
        public StackPanel stack = new StackPanel();
        public DateTimePicker dateTimePicker = new DateTimePicker();


        public ScheduleAppointment()
        {
            InitializeComponent();

            //combo.SelectionChanged += Provider_SelectionChanged;
            dateTimePicker.Format = DateTimeFormat.ShortTime;

            grid.Children.Add(dateTimePicker);
            Grid.SetColumn(dateTimePicker, 6);
            Grid.SetRow(dateTimePicker, 8);

            userObsrv = getloggedindoc();
            
            
            stack.Margin = new Thickness(10);
            stack.Children.Add(combo);
            
            grid.Children.Add(stack);
            Grid.SetColumn(stack, 6);
            Grid.SetRow(stack, 7);
            Grid.SetColumnSpan(stack, 2);

        }
        private ObservableCollection<DocBill> getloggedindoc()
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

        private void Location_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            List<Doc> temp = new List<Doc>();
           
            if (LocationSelect.SelectedIndex == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    combo.Items.Clear();
                    location = "Watson Clinic South";
                    temp.Add(HomePage.Doctors[i]);
                }
            }

            if (LocationSelect.SelectedIndex == 1)
            {
                for (int i = 4; i < 8; i++)
                {
                    combo.Items.Clear();
                    location = "East Bay Clinic";
                    temp.Add(HomePage.Doctors[i]);
                }
            }

            if (LocationSelect.SelectedIndex == 2)
            {
                for (int i = 8; i < 12; i++)
                {
                    combo.Items.Clear();
                    location = "Tampa General Hospital";
                    temp.Add(HomePage.Doctors[i]);
                }
            }

            if (LocationSelect.SelectedIndex == 3)
            {
                for (int i = 12; i < 16; i++)
                {
                    combo.Items.Clear();
                    location = "South Shore Regional";
                    temp.Add(HomePage.Doctors[i]);
                }
            }

            ObservableCollection<string> temp2 = new ObservableCollection<string>();
            foreach (Doc item in temp)
            {
                temp2.Add(item.Doctor);
            }

            foreach (string item in temp2)
            {
                combo.Items.Add(item);
            }

            
        }

        private void Provider_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            provider = combo.SelectedItem.ToString();
        }
        
        private void Schedule_Click(object sender, RoutedEventArgs e)
        {
            HomePage.DocCollection.Add(new DocBill(userObsrv[0].SSN, combo.SelectedItem.ToString(), dateTimePicker.Text, location));

            string path = "doctors.xml";

            if (File.Exists(path))
            {
                File.Delete(path);
                using (FileStream filestream = new FileStream(path, FileMode.Create, FileAccess.ReadWrite))
                {
                    serializer.Serialize(filestream, HomePage.DocCollection);
                }
            }

            NavigationService.Navigate(new Uri("Appointment.xaml", UriKind.Relative));

           
        }

        
    }
}

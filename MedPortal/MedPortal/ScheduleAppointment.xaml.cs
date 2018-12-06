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

            Welcome.Text += LoginPage.LoggedinUser.FirstName + " " + LoginPage.LoggedinUser.LastName;

            
            dateTimePicker.Format = DateTimeFormat.ShortTime;

            dateTimePicker.MaxHeight = 35;

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

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("AccountManagement.xaml", UriKind.Relative));
        }
        private void Question_Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Chat.xaml", UriKind.Relative));
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
        

        /// <summary>
        /// adds an appointment to the users list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            System.Windows.MessageBox.Show("Appointment Added!");
            NavigationService.Navigate(new Uri("Appointment.xaml", UriKind.Relative));

           
        }

        private void Logout_Button_Click(object sender, RoutedEventArgs e)
        {
            LoginPage.LoggedinUser = null;
            NavigationService.Navigate(new Uri("LoginPage.xaml", UriKind.Relative));
        }
    }
}

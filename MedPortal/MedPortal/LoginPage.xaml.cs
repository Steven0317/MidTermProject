using System;
using System.Collections.Generic;
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
using System.IO;
using System.Xml.Serialization;

namespace MedPortal
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    /// 
    

    public partial class LoginPage : Page
    {

        XmlSerializer serializer = new XmlSerializer(typeof(List<Individual>));
        public static List<Individual> UserCollection = new List<Individual>();
        public LoginPage()
        {
            InitializeComponent();

            try
            {
                ReadFromMemory();
            }
            catch(Exception ex)
            {
                Console.WriteLine("--------Xml Read Error--------");
                MessageBox.Show($"Unable to read xml file\ninner excepetion:{ex.InnerException.Message} ");
            }
        }




        private void login_button_Click(object sender, RoutedEventArgs e)
        {
            if(ValidateLogin())
            {
                NavigationService.Navigate(new Uri("HomePage.xaml", UriKind.Relative));
            }
            else
            {
                error.Visibility = Visibility.Visible;
            }
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("NewUser.xaml", UriKind.Relative));
        }
    
        private bool ValidateLogin()
        {
            Hash hash = new Hash();
            return Hash.isValid(password.Password, username.Text);
        }

        private void ReadFromMemory()
        {
            string path = "users.xml";

            if(File.Exists(path))
            {
                using (FileStream readStream = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    UserCollection = serializer.Deserialize(readStream) as List<Individual>;
                }

            }
        }

    }
}

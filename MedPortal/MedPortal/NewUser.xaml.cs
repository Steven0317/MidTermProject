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
    /// Interaction logic for NewUser.xaml
    /// </summary>
    
    public partial class NewUser : Page
    {

        private LoginPage UserCollection = new LoginPage();
        XmlSerializer serializer = new XmlSerializer(typeof(List<Individual>));

        public NewUser()
        {
            InitializeComponent();
        }

        private void create_account_button_Click(object sender, RoutedEventArgs e)
        {

            
            if (ValidateEntries())
            {
                // get user age by tokeinzing dob then subtracting
                // current year fromm dob.
                int UserAge = 0;
                int today = DateTime.Today.Year;
                string[] age = DOBBox.Text.Split('/');
                UserAge = today - Convert.ToInt32(age[2]);

               
                //create pw hash and salt
                Hash hash = new Hash();
                string salt = Convert.ToBase64String(hash.GenerateSalt());
                string password = hash.Sha256(PBox.Text, Convert.FromBase64String(salt)); ;

                //concatenate all alleriges together
                string allergies = ValidateChecks();
    

                Individual temp = new Individual(FBox.Text, LBox.Text, UBox.Text, password, 
                                                    UserAge, DOBBox.Text, allergies, SBox.Text, PCPBox.Text, IPBox.Text, salt);
                LoginPage.UserCollection.Add(temp);

                LoginPage.LoggedinUser = temp;

                NavigationService.Navigate(new Uri("HomePage.xaml", UriKind.Relative));

                string path = "users.xml";

                if (LoginPage.UserCollection.Count == 0 && File.Exists(path))
                {
                    File.Delete(path);
                }
                else
                {
                    using (FileStream filestream = new FileStream(path, FileMode.Create, FileAccess.ReadWrite))
                    {
                        serializer.Serialize(filestream, LoginPage.UserCollection);
                    }

                }
            }
        }
        
        private bool ValidateEntries()
        {
            
            bool fValid;
            bool lValid;
            bool SocValid;
            bool DOBValid;
            bool uValid;
            bool pValid;
            bool cpValid;
            bool pcpValid;
            bool ipValid;

            fValid = string.IsNullOrWhiteSpace(FBox.Text) ? false : ValidateLetter(FBox.Text);
            FName.Foreground = fValid ? Brushes.Black : Brushes.Coral;

            lValid = string.IsNullOrWhiteSpace(LBox.Text) ? false : ValidateLetter(LBox.Text);
            LName.Foreground = lValid ? Brushes.Black : Brushes.Coral;

            SocValid = string.IsNullOrWhiteSpace(SBox.Text) ? false : ValidateDigit(SBox.Text);
            Social.Foreground = SocValid ? Brushes.Black : Brushes.Coral;

            DOBValid = string.IsNullOrWhiteSpace(DOBBox.Text) ? false : ValidateDigit(DOBBox.Text);
            Dob.Foreground = DOBValid ? Brushes.Black : Brushes.Coral;

            uValid = string.IsNullOrWhiteSpace(UBox.Text) && uTool.Visibility == Visibility.Hidden ? false : true;
            UName.Foreground = uValid ? Brushes.Black : Brushes.Coral;

            pValid = string.IsNullOrWhiteSpace(PBox.Text)  || PBox.Text.Length < 8 ? false : true;
            Pword.Foreground = pValid ? Brushes.Black : Brushes.Coral;

            cpValid = string.IsNullOrWhiteSpace(ConfPword.Text)  || CPBox.Text.Length < 8 ? false : true;
            ConfPword.Foreground = pValid ? Brushes.Black : Brushes.Coral;

            pcpValid = string.IsNullOrWhiteSpace(PCPBox.Text) ? false : true;
            PCP.Foreground = pcpValid ? Brushes.Black : Brushes.Coral;

            ipValid = string.IsNullOrWhiteSpace(IPBox.Text) ? false : true;
            IP.Foreground = ipValid ? Brushes.Black : Brushes.Coral;

            return fValid && lValid && SocValid && DOBValid && uValid 
                   && pValid && cpValid && pcpValid &&ipValid;
        }

        private bool ValidateLetter(string test)
        {
            return test.Where(x => char.IsLetter(x)).Count() == test.Length;
        }

        private bool ValidateDigit(string test)
        {
            return test.All("0123456789-/".Contains);
        }

        private void CPBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if(!PBox.Text.Equals(CPBox.Text))
            {
                
                Pword.Foreground = Brushes.Coral;
                ConfPword.Foreground = Brushes.Coral;
                pTool.Foreground = PBox.Text.Length < 8 ? Brushes.Coral : Brushes.Black;
            }
            else
            {
                Pword.Foreground = Brushes.Black;
                ConfPword.Foreground = Brushes.Black;
            }
        }

 
        private string ValidateChecks()
        {
            string allergies = "";

            if(soy.IsChecked == true)
            {
                allergies += " " +"Soy";
            }
            if( dairy.IsChecked == true)
            {
                allergies += " " + "Dairy";
                
            }
            if(nut.IsChecked == true)
            {
                allergies += " " + "Nuts";
            }
            if(fish.IsChecked == true)
            {
                allergies += " " + "Fish";
            }
            if(gluten.IsChecked == true)
            {
                allergies += " " + "Gluten";
            }
            if(egg.IsChecked == true)
            {
                allergies +=  " " + "egg";
            }
            if( string.IsNullOrWhiteSpace(allergies))
            {
                allergies = "None";
            }
            return allergies;
        }

        private void UBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (LoginPage.UserCollection.Any(x => x.user == UBox.Text))
            {
                uTool.Visibility = Visibility.Visible;
            }
            else
            {
                uTool.Visibility = Visibility.Hidden;
            }
        }
    }
}

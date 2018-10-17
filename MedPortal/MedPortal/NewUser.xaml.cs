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

namespace MedPortal
{
    /// <summary>
    /// Interaction logic for NewUser.xaml
    /// </summary>
    public partial class NewUser : Page
    {
        public NewUser()
        {
            InitializeComponent();
        }

        private void create_account_button_Click(object sender, RoutedEventArgs e)
        {
            ValidateEntries();
        }
        
        private bool ValidateEntries()
        {
            //FBox SBox DOBBox LBox
            //UBox PBox CPBox
            //PCPBox IPBox 
            bool fValid;
            bool lValid;
            bool SocValid;
            bool DOBValid;
            bool uValid;
            bool pValid;
            bool pcpValid;
            bool ipValid;

            fValid = string.IsNullOrWhiteSpace(FBox.Text) ? false : ValidateLetter(FBox.Text);
            FName.Foreground = fValid ? Brushes.Black : Brushes.Coral;

            lValid = string.IsNullOrWhiteSpace(LBox.Text) ? false : ValidateLetter(LBox.Text);
            LName.Foreground = lValid ? Brushes.Black : Brushes.Coral;

            
            
            return true;
        }

        private bool ValidateLetter(string test)
        {
            return test.Where(x => char.IsLetter(x)).Count() == test.Length;
        }

        private bool ValidateDigit(string test, int maxLength)
        {
            return test.All("0123456789".Contains);
        }
    }
}

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

        private LoginPage UserCollection = new LoginPage();

        public NewUser()
        {
            InitializeComponent();
        }

        private void create_account_button_Click(object sender, RoutedEventArgs e)
        {

            FBox.Text = DOBBox.Text;
            LBox.Text = SBox.Text;
            if (ValidateEntries())
            {
                FBox.Text = DOBBox.Text;
                LBox.Text = SBox.Text;
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

            DOBValid = string.IsNullOrWhiteSpace(DOBBox.Text) ? false : ValidateLetter(DOBBox.Text);
            Dob.Foreground = DOBValid ? Brushes.Black : Brushes.Coral;

            uValid = string.IsNullOrWhiteSpace(UBox.Text) ? false : true;
            UName.Foreground = uValid ? Brushes.Black : Brushes.Coral;

            pValid = string.IsNullOrWhiteSpace(PBox.Text) || Pword.Text.Length >= 8 ? false : true;
            Pword.Foreground = pValid ? Brushes.Coral : Brushes.Black;

            cpValid = string.IsNullOrWhiteSpace(ConfPword.Text) || ConfPword.Text.Length >= 8 ? false : true;
            ConfPword.Foreground = pValid ? Brushes.Coral : Brushes.Black;
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
    }
}

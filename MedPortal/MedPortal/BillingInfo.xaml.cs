﻿using System;
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
            BillingInfoVM bill =  new BillingInfoVM();

            DataContext = bill;

            
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
        private void Question_Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Chat.xaml", UriKind.Relative));
        }
        //logout function
        private void Logout_Button_Click(object sender, RoutedEventArgs e)
        {
            LoginPage.LoggedinUser = null;
            NavigationService.Navigate(new Uri("LoginPage.xaml", UriKind.Relative));
        }

 
    }
}

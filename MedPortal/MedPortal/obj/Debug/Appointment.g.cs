﻿#pragma checksum "..\..\Appointment.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "BB63D6288B3E063040526CA562E6384795B34AAB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MedPortal;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace MedPortal {
    
    
    /// <summary>
    /// Appointment
    /// </summary>
    public partial class Appointment : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 59 "..\..\Appointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image userImage;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\Appointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Welcome;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\Appointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DocGrid;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\Appointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock DocText;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\Appointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Appointment_Button2;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\Appointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Appointment_Button;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\Appointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Presciption_Button;
        
        #line default
        #line hidden
        
        
        #line 126 "..\..\Appointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Billing_Button;
        
        #line default
        #line hidden
        
        
        #line 140 "..\..\Appointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Question_Button;
        
        #line default
        #line hidden
        
        
        #line 157 "..\..\Appointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Logout_Button;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MedPortal;component/appointment.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Appointment.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 54 "..\..\Appointment.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).Click += new System.Windows.RoutedEventHandler(this.Hyperlink_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.userImage = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.Welcome = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.DocGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.DocText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.Appointment_Button2 = ((System.Windows.Controls.Button)(target));
            
            #line 78 "..\..\Appointment.xaml"
            this.Appointment_Button2.Click += new System.Windows.RoutedEventHandler(this.Schedule_ButtonClick);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 80 "..\..\Appointment.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Appointment_Button = ((System.Windows.Controls.Button)(target));
            
            #line 96 "..\..\Appointment.xaml"
            this.Appointment_Button.Click += new System.Windows.RoutedEventHandler(this.Appointment_Button_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Presciption_Button = ((System.Windows.Controls.Button)(target));
            
            #line 112 "..\..\Appointment.xaml"
            this.Presciption_Button.Click += new System.Windows.RoutedEventHandler(this.Presciption_Button_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Billing_Button = ((System.Windows.Controls.Button)(target));
            
            #line 126 "..\..\Appointment.xaml"
            this.Billing_Button.Click += new System.Windows.RoutedEventHandler(this.Billing_Button_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.Question_Button = ((System.Windows.Controls.Button)(target));
            
            #line 140 "..\..\Appointment.xaml"
            this.Question_Button.Click += new System.Windows.RoutedEventHandler(this.Question_Button_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.Logout_Button = ((System.Windows.Controls.Button)(target));
            
            #line 157 "..\..\Appointment.xaml"
            this.Logout_Button.Click += new System.Windows.RoutedEventHandler(this.Logout_Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


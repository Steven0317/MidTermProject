﻿#pragma checksum "..\..\HomePage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D5A34FE1855C08FB6A855860F44546E79418D557"
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
    /// HomePage
    /// </summary>
    public partial class HomePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 55 "..\..\HomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Welcome;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\HomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid AppointmentGrid;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\HomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid BillGrid;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\HomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid RXGrid;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\HomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock AppText;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\HomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock BillText;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\HomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock RXText;
        
        #line default
        #line hidden
        
        
        #line 132 "..\..\HomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Appointment_Button;
        
        #line default
        #line hidden
        
        
        #line 147 "..\..\HomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Presciption_Button;
        
        #line default
        #line hidden
        
        
        #line 161 "..\..\HomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Billing_Button;
        
        #line default
        #line hidden
        
        
        #line 180 "..\..\HomePage.xaml"
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
            System.Uri resourceLocater = new System.Uri("/MedPortal;component/homepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\HomePage.xaml"
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
            this.Welcome = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.AppointmentGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.BillGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.RXGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.AppText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.BillText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.RXText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.Appointment_Button = ((System.Windows.Controls.Button)(target));
            
            #line 132 "..\..\HomePage.xaml"
            this.Appointment_Button.Click += new System.Windows.RoutedEventHandler(this.Appointment_Button_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Presciption_Button = ((System.Windows.Controls.Button)(target));
            
            #line 147 "..\..\HomePage.xaml"
            this.Presciption_Button.Click += new System.Windows.RoutedEventHandler(this.Presciption_Button_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Billing_Button = ((System.Windows.Controls.Button)(target));
            
            #line 161 "..\..\HomePage.xaml"
            this.Billing_Button.Click += new System.Windows.RoutedEventHandler(this.Billing_Button_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.Logout_Button = ((System.Windows.Controls.Button)(target));
            
            #line 180 "..\..\HomePage.xaml"
            this.Logout_Button.Click += new System.Windows.RoutedEventHandler(this.Logout_Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


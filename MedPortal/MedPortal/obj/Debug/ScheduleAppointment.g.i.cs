﻿#pragma checksum "..\..\ScheduleAppointment.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6A502889AB57FE351BB164C6A2D2483F6B38BC4D"
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
    /// ScheduleAppointment
    /// </summary>
    public partial class ScheduleAppointment : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\ScheduleAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\ScheduleAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Schedule;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\ScheduleAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox LocationSelect;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\ScheduleAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock WCS;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\ScheduleAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock EBC;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\ScheduleAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TGH;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\ScheduleAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock SSR;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\ScheduleAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Appointment_Button;
        
        #line default
        #line hidden
        
        
        #line 115 "..\..\ScheduleAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Presciption_Button;
        
        #line default
        #line hidden
        
        
        #line 129 "..\..\ScheduleAppointment.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Billing_Button;
        
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
            System.Uri resourceLocater = new System.Uri("/MedPortal;component/scheduleappointment.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ScheduleAppointment.xaml"
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
            this.grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.Schedule = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\ScheduleAppointment.xaml"
            this.Schedule.Click += new System.Windows.RoutedEventHandler(this.Schedule_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.LocationSelect = ((System.Windows.Controls.ComboBox)(target));
            
            #line 59 "..\..\ScheduleAppointment.xaml"
            this.LocationSelect.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Location_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.WCS = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.EBC = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.TGH = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.SSR = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            
            #line 84 "..\..\ScheduleAppointment.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Appointment_Button = ((System.Windows.Controls.Button)(target));
            
            #line 100 "..\..\ScheduleAppointment.xaml"
            this.Appointment_Button.Click += new System.Windows.RoutedEventHandler(this.Appointment_Button_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Presciption_Button = ((System.Windows.Controls.Button)(target));
            
            #line 115 "..\..\ScheduleAppointment.xaml"
            this.Presciption_Button.Click += new System.Windows.RoutedEventHandler(this.Presciption_Button_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.Billing_Button = ((System.Windows.Controls.Button)(target));
            
            #line 129 "..\..\ScheduleAppointment.xaml"
            this.Billing_Button.Click += new System.Windows.RoutedEventHandler(this.Billing_Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

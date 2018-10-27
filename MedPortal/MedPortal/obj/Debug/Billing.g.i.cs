#pragma checksum "..\..\Billing.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4A4BBEC2B8932FA18E57D6DCB095B35FF2BFDEED"
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


namespace MedPortal
{


    /// <summary>
    /// Billing
    /// </summary>
    public partial class Billing : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector
    {


#line 53 "..\..\Billing.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock BillText;

#line default
#line hidden


#line 55 "..\..\Billing.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid BillGrid;

#line default
#line hidden


#line 65 "..\..\Billing.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridCheckBoxColumn Check;

#line default
#line hidden


#line 76 "..\..\Billing.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LeftBox;

#line default
#line hidden


#line 77 "..\..\Billing.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PayBox;

#line default
#line hidden


#line 78 "..\..\Billing.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Pay;

#line default
#line hidden


#line 98 "..\..\Billing.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Appointment_Button;

#line default
#line hidden


#line 113 "..\..\Billing.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Presciption_Button;

#line default
#line hidden


#line 127 "..\..\Billing.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Billing_Button;

#line default
#line hidden


#line 145 "..\..\Billing.xaml"
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
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MedPortal;component/billing.xaml", System.UriKind.Relative);

#line 1 "..\..\Billing.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.BillText = ((System.Windows.Controls.TextBlock)(target));
                    return;
                case 2:
                    this.BillGrid = ((System.Windows.Controls.DataGrid)(target));
                    return;
                case 4:
                    this.Check = ((System.Windows.Controls.DataGridCheckBoxColumn)(target));
                    return;
                case 5:
                    this.LeftBox = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 6:
                    this.PayBox = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 7:
                    this.Pay = ((System.Windows.Controls.Button)(target));

#line 78 "..\..\Billing.xaml"
                    this.Pay.Click += new System.Windows.RoutedEventHandler(this.Pay_Click);

#line default
#line hidden
                    return;
                case 8:

#line 82 "..\..\Billing.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);

#line default
#line hidden
                    return;
                case 9:
                    this.Appointment_Button = ((System.Windows.Controls.Button)(target));

#line 98 "..\..\Billing.xaml"
                    this.Appointment_Button.Click += new System.Windows.RoutedEventHandler(this.Appointment_Button_Click);

#line default
#line hidden
                    return;
                case 10:
                    this.Presciption_Button = ((System.Windows.Controls.Button)(target));

#line 113 "..\..\Billing.xaml"
                    this.Presciption_Button.Click += new System.Windows.RoutedEventHandler(this.Presciption_Button_Click);

#line default
#line hidden
                    return;
                case 11:
                    this.Billing_Button = ((System.Windows.Controls.Button)(target));

#line 127 "..\..\Billing.xaml"
                    this.Billing_Button.Click += new System.Windows.RoutedEventHandler(this.Billing_Button_Click);

#line default
#line hidden
                    return;
                case 12:
                    this.Logout_Button = ((System.Windows.Controls.Button)(target));

#line 145 "..\..\Billing.xaml"
                    this.Logout_Button.Click += new System.Windows.RoutedEventHandler(this.Logout_Button_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
        {
            System.Windows.EventSetter eventSetter;
            switch (connectionId)
            {
                case 3:
                    eventSetter = new System.Windows.EventSetter();
                    eventSetter.Event = System.Windows.Controls.Control.MouseDoubleClickEvent;

#line 61 "..\..\Billing.xaml"
                    eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.DataGridRow_MouseDoubleClick);

#line default
#line hidden
                    ((System.Windows.Style)(target)).Setters.Add(eventSetter);
                    break;
            }
        }

        internal System.Windows.Controls.DataGridTextColumn paid;
    }
}


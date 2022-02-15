﻿#pragma checksum "..\..\..\..\..\Views\Patient\PatientWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "EEC078D1C59EEC4A023649704091BBEED2C0AB9C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Diploma.Models;
using Diploma.ViewModels;
using Diploma.Views;
using EnumBindings;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace Diploma.Views {
    
    
    /// <summary>
    /// PatientWindow
    /// </summary>
    public partial class PatientWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 75 "..\..\..\..\..\Views\Patient\PatientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Icon;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\..\..\Views\Patient\PatientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid PatientGrid;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\..\..\Views\Patient\PatientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn NameColumn;
        
        #line default
        #line hidden
        
        
        #line 123 "..\..\..\..\..\Views\Patient\PatientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Label1;
        
        #line default
        #line hidden
        
        
        #line 124 "..\..\..\..\..\Views\Patient\PatientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchName;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\..\..\..\Views\Patient\PatientWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label TitleLabel;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.10.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Diploma;component/views/patient/patientwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\Patient\PatientWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.10.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 10 "..\..\..\..\..\Views\Patient\PatientWindow.xaml"
            ((Diploma.Views.PatientWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Icon = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.PatientGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 92 "..\..\..\..\..\Views\Patient\PatientWindow.xaml"
            this.PatientGrid.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.DataGrid_PreviewMouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.NameColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 5:
            this.Label1 = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.SearchName = ((System.Windows.Controls.TextBox)(target));
            
            #line 124 "..\..\..\..\..\Views\Patient\PatientWindow.xaml"
            this.SearchName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SearchBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.TitleLabel = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


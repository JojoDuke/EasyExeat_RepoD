﻿#pragma checksum "..\..\..\Controls\EditTextUC.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F634AC0F11AE0296C5CF2C91FC898D66B3CF83F5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Fasetto.Word;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using Microsoft.Windows.Themes;
using New_EZexeat.Controls;
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


namespace New_EZexeat.Controls {
    
    
    /// <summary>
    /// EditTextUC
    /// </summary>
    public partial class EditTextUC : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\Controls\EditTextUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox genderTxt;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Controls\EditTextUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker datePicker;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Controls\EditTextUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox bloodTxt;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Controls\EditTextUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox religionTB;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\Controls\EditTextUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox medical;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\Controls\EditTextUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox allergies;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\Controls\EditTextUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox other;
        
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
            System.Uri resourceLocater = new System.Uri("/New_EZexeat;component/controls/edittextuc.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Controls\EditTextUC.xaml"
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
            this.genderTxt = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.datePicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 3:
            this.bloodTxt = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.religionTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.medical = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.allergies = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.other = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            
            #line 74 "..\..\..\Controls\EditTextUC.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SaveButton);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 75 "..\..\..\Controls\EditTextUC.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EditButton);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

﻿#pragma checksum "..\..\User_Homepage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62D70604C5B3233DC44966B48160D5528D812A33"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using New_EZexeat;
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


namespace New_EZexeat {
    
    
    /// <summary>
    /// User_Homepage
    /// </summary>
    public partial class User_Homepage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\User_Homepage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridPrincipal;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\User_Homepage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton homeBtn;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\User_Homepage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton takeExeatBtn;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\User_Homepage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton messagesBtn;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\User_Homepage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UserLogoutBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/New_EZexeat;component/user_homepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\User_Homepage.xaml"
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
            this.GridPrincipal = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.homeBtn = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 50 "..\..\User_Homepage.xaml"
            this.homeBtn.Click += new System.Windows.RoutedEventHandler(this.HomeBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.takeExeatBtn = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 58 "..\..\User_Homepage.xaml"
            this.takeExeatBtn.Click += new System.Windows.RoutedEventHandler(this.TakeExeatBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.messagesBtn = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 66 "..\..\User_Homepage.xaml"
            this.messagesBtn.Click += new System.Windows.RoutedEventHandler(this.MessagesBtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.UserLogoutBtn = ((System.Windows.Controls.Button)(target));
            
            #line 92 "..\..\User_Homepage.xaml"
            this.UserLogoutBtn.Click += new System.Windows.RoutedEventHandler(this.UserLogoutBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


﻿#pragma checksum "c:\users\jomziii\documents\visual studio 2013\Projects\IsolatedStorageC\IsolatedStorageC\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "EF3409B6911BFF99DB3DD87C564E954C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace IsolatedStorageC {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBox txtInput;
        
        internal System.Windows.Controls.Button btnSave;
        
        internal System.Windows.Controls.Button btnRemove;
        
        internal System.Windows.Controls.Button btnDisplay;
        
        internal System.Windows.Controls.TextBlock txbView;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/IsolatedStorageC;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.txtInput = ((System.Windows.Controls.TextBox)(this.FindName("txtInput")));
            this.btnSave = ((System.Windows.Controls.Button)(this.FindName("btnSave")));
            this.btnRemove = ((System.Windows.Controls.Button)(this.FindName("btnRemove")));
            this.btnDisplay = ((System.Windows.Controls.Button)(this.FindName("btnDisplay")));
            this.txbView = ((System.Windows.Controls.TextBlock)(this.FindName("txbView")));
        }
    }
}

﻿#pragma checksum "C:\Users\paul\Documents\GitHub\GPUImageProcessingSDX\GPUImageProcessingSDX\GPUImageProcessingSDX\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CDC81D4DB6B28479FD9D1CADCCE63005"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
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


namespace GPUImageProcessingSDX {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.DrawingSurfaceBackgroundGrid DisplayGrid;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/.in;component/MainPage.xaml", System.UriKind.Relative));
            this.DisplayGrid = ((System.Windows.Controls.DrawingSurfaceBackgroundGrid)(this.FindName("DisplayGrid")));
        }
    }
}


﻿#pragma checksum "..\..\SucheBitalino.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20BEC18BF6B164F3B567E907CE060EE1C45FB699"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

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
using WPF_Bitalino;


namespace WPF_Bitalino {
    
    
    /// <summary>
    /// SearchBluetoothWindow
    /// </summary>
    public partial class SearchBluetoothWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\SucheBitalino.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WPF_Bitalino.SearchBluetoothWindow BitalinoSearch;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\SucheBitalino.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border Search;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\SucheBitalino.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar Progressbar;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\SucheBitalino.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBox_BitalinoIDs;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\SucheBitalino.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_verbinden;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\SucheBitalino.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_abbrechen;
        
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
            System.Uri resourceLocater = new System.Uri("/WPF_Bitalino;component/suchebitalino.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SucheBitalino.xaml"
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
            this.BitalinoSearch = ((WPF_Bitalino.SearchBluetoothWindow)(target));
            
            #line 8 "..\..\SucheBitalino.xaml"
            this.BitalinoSearch.Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Search = ((System.Windows.Controls.Border)(target));
            return;
            case 3:
            this.Progressbar = ((System.Windows.Controls.ProgressBar)(target));
            return;
            case 4:
            this.comboBox_BitalinoIDs = ((System.Windows.Controls.ComboBox)(target));
            
            #line 19 "..\..\SucheBitalino.xaml"
            this.comboBox_BitalinoIDs.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.comboBox_BitalinoIDs_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.button_verbinden = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\SucheBitalino.xaml"
            this.button_verbinden.Click += new System.Windows.RoutedEventHandler(this.button_verbinden_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.button_abbrechen = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\SucheBitalino.xaml"
            this.button_abbrechen.Click += new System.Windows.RoutedEventHandler(this.button_abbrechen_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

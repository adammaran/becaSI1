﻿#pragma checksum "..\..\Sacuvano.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5C7CCED6E01454867AD7315F442771777E343CA8EF146DAD8CC255986BA698AA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AutoProdavnicaNew;
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


namespace AutoProdavnicaNew {
    
    
    /// <summary>
    /// Sacuvano
    /// </summary>
    public partial class Sacuvano : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\Sacuvano.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtFudbalerId;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\Sacuvano.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbsKorisnikId;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Sacuvano.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnIzaberi;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Sacuvano.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnObrisi;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Sacuvano.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridSacuvano;
        
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
            System.Uri resourceLocater = new System.Uri("/AutoProdavnicaNew;component/sacuvano.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Sacuvano.xaml"
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
            this.txtFudbalerId = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.cbsKorisnikId = ((System.Windows.Controls.ComboBox)(target));
            
            #line 12 "..\..\Sacuvano.xaml"
            this.cbsKorisnikId.Loaded += new System.Windows.RoutedEventHandler(this.CbxKorisnik_Loaded);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnIzaberi = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\Sacuvano.xaml"
            this.btnIzaberi.Click += new System.Windows.RoutedEventHandler(this.btnIzaberi_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnObrisi = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\Sacuvano.xaml"
            this.btnObrisi.Click += new System.Windows.RoutedEventHandler(this.BtnObrisi_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.DataGridSacuvano = ((System.Windows.Controls.DataGrid)(target));
            
            #line 15 "..\..\Sacuvano.xaml"
            this.DataGridSacuvano.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DataGridSacuvano_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

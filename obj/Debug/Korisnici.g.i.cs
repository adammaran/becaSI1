﻿#pragma checksum "..\..\Korisnici.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D10A903BAEBF2A610034960B5D923876DFC7F07833C31A2B79143F20C1421493"
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
    /// Korisnici
    /// </summary>
    public partial class Korisnici : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\Korisnici.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtIme;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Korisnici.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPrezime;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Korisnici.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbsKorisnikId;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Korisnici.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDodaj;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Korisnici.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnIzaberi;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Korisnici.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnIzmeni;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Korisnici.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnObrisi;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Korisnici.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridFudbaler;
        
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
            System.Uri resourceLocater = new System.Uri("/AutoProdavnicaNew;component/korisnici.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Korisnici.xaml"
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
            this.txtIme = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtPrezime = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.cbsKorisnikId = ((System.Windows.Controls.ComboBox)(target));
            
            #line 15 "..\..\Korisnici.xaml"
            this.cbsKorisnikId.Loaded += new System.Windows.RoutedEventHandler(this.CbxKorisnik_Loaded);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnDodaj = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\Korisnici.xaml"
            this.btnDodaj.Click += new System.Windows.RoutedEventHandler(this.BtnDodaj_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnIzaberi = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\Korisnici.xaml"
            this.btnIzaberi.Click += new System.Windows.RoutedEventHandler(this.btnIzaberi_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnIzmeni = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\Korisnici.xaml"
            this.btnIzmeni.Click += new System.Windows.RoutedEventHandler(this.BtnIzmeni_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnObrisi = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\Korisnici.xaml"
            this.btnObrisi.Click += new System.Windows.RoutedEventHandler(this.BtnObrisi_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.DataGridFudbaler = ((System.Windows.Controls.DataGrid)(target));
            
            #line 21 "..\..\Korisnici.xaml"
            this.DataGridFudbaler.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DataGridFudbaler_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


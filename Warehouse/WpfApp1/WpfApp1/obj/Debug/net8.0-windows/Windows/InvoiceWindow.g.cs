﻿#pragma checksum "..\..\..\..\Windows\InvoiceWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9D9184D0BF3889B2AB482B1E85903D5FB19B7F75"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using WpfApp1;


namespace WpfApp1 {
    
    
    /// <summary>
    /// InvoiceWindow
    /// </summary>
    public partial class InvoiceWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\..\Windows\InvoiceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dtgInvoice;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\Windows\InvoiceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbUpInvoice;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\Windows\InvoiceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbDownInvoice;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\..\Windows\InvoiceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSearchInvoice;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\Windows\InvoiceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbViewInvoice;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\..\Windows\InvoiceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddInvoice;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\..\Windows\InvoiceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnDeleteInvoice;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\..\Windows\InvoiceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnBackInvoice;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.11.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/windows/invoicewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\InvoiceWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.11.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.dtgInvoice = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.rbUpInvoice = ((System.Windows.Controls.RadioButton)(target));
            
            #line 54 "..\..\..\..\Windows\InvoiceWindow.xaml"
            this.rbUpInvoice.Click += new System.Windows.RoutedEventHandler(this.rbUpInvoice_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.rbDownInvoice = ((System.Windows.Controls.RadioButton)(target));
            
            #line 56 "..\..\..\..\Windows\InvoiceWindow.xaml"
            this.rbDownInvoice.Click += new System.Windows.RoutedEventHandler(this.rbDownInvoice_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtSearchInvoice = ((System.Windows.Controls.TextBox)(target));
            
            #line 60 "..\..\..\..\Windows\InvoiceWindow.xaml"
            this.txtSearchInvoice.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtSearchInvoice_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.cmbViewInvoice = ((System.Windows.Controls.ComboBox)(target));
            
            #line 63 "..\..\..\..\Windows\InvoiceWindow.xaml"
            this.cmbViewInvoice.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbViewInvoice_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnAddInvoice = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\..\..\Windows\InvoiceWindow.xaml"
            this.btnAddInvoice.Click += new System.Windows.RoutedEventHandler(this.btnAddInvoice_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BtnDeleteInvoice = ((System.Windows.Controls.Button)(target));
            
            #line 69 "..\..\..\..\Windows\InvoiceWindow.xaml"
            this.BtnDeleteInvoice.Click += new System.Windows.RoutedEventHandler(this.BtnDeleteInvoice_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BtnBackInvoice = ((System.Windows.Controls.Button)(target));
            
            #line 72 "..\..\..\..\Windows\InvoiceWindow.xaml"
            this.BtnBackInvoice.Click += new System.Windows.RoutedEventHandler(this.BtnBackInvoice_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


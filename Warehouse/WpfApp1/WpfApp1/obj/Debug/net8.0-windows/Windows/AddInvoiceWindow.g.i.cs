﻿#pragma checksum "..\..\..\..\Windows\AddInvoiceWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "230C58BDB317631A91A394D5DA2AB570C826E942"
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
using WpfApp1.Windows;


namespace WpfApp1.Windows {
    
    
    /// <summary>
    /// AddInvoiceWindow
    /// </summary>
    public partial class AddInvoiceWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\..\Windows\AddInvoiceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtdate;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\Windows\AddInvoiceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtproduct;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\Windows\AddInvoiceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtquantity;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\Windows\AddInvoiceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtshop;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\Windows\AddInvoiceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSaveInvoice;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\Windows\AddInvoiceWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnBacksInvoice;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/windows/addinvoicewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\AddInvoiceWindow.xaml"
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
            this.txtdate = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtproduct = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtquantity = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtshop = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.BtnSaveInvoice = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\..\..\Windows\AddInvoiceWindow.xaml"
            this.BtnSaveInvoice.Click += new System.Windows.RoutedEventHandler(this.BtnSaveInvoice_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BtnBacksInvoice = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\..\..\Windows\AddInvoiceWindow.xaml"
            this.BtnBacksInvoice.Click += new System.Windows.RoutedEventHandler(this.BtnBacksInvoice_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


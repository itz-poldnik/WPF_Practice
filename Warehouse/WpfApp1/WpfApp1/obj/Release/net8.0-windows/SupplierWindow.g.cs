﻿#pragma checksum "..\..\..\SupplierWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29B6050DDF960EE203451F3AE0EFC8AEBAA643EB"
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
    /// SupplierWindow
    /// </summary>
    public partial class SupplierWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 14 "..\..\..\SupplierWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dtgSupplier;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\SupplierWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbUpSupplier;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\SupplierWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbDownSupplier;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\SupplierWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSearchSupplier;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\SupplierWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbViewSupplier;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\SupplierWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddSupplier;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\SupplierWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnDeleteSupplier;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\SupplierWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnBackSupplier;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/supplierwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\SupplierWindow.xaml"
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
            this.dtgSupplier = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.rbUpSupplier = ((System.Windows.Controls.RadioButton)(target));
            
            #line 50 "..\..\..\SupplierWindow.xaml"
            this.rbUpSupplier.Click += new System.Windows.RoutedEventHandler(this.rbUpSupplier_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.rbDownSupplier = ((System.Windows.Controls.RadioButton)(target));
            
            #line 52 "..\..\..\SupplierWindow.xaml"
            this.rbDownSupplier.Click += new System.Windows.RoutedEventHandler(this.rbDownSupplier_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtSearchSupplier = ((System.Windows.Controls.TextBox)(target));
            
            #line 56 "..\..\..\SupplierWindow.xaml"
            this.txtSearchSupplier.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtSearchSupplier_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.cmbViewSupplier = ((System.Windows.Controls.ComboBox)(target));
            
            #line 59 "..\..\..\SupplierWindow.xaml"
            this.cmbViewSupplier.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbViewSupplier_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnAddSupplier = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\..\SupplierWindow.xaml"
            this.btnAddSupplier.Click += new System.Windows.RoutedEventHandler(this.btnAddSupplier_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BtnDeleteSupplier = ((System.Windows.Controls.Button)(target));
            
            #line 65 "..\..\..\SupplierWindow.xaml"
            this.BtnDeleteSupplier.Click += new System.Windows.RoutedEventHandler(this.BtnDeleteSupplier_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.BtnBackSupplier = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\..\SupplierWindow.xaml"
            this.BtnBackSupplier.Click += new System.Windows.RoutedEventHandler(this.BtnBackSupplier_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.11.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 2:
            
            #line 37 "..\..\..\SupplierWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnEditSupplier_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}


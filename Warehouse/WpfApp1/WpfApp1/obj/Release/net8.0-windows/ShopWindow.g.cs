﻿#pragma checksum "..\..\..\ShopWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6DDCBFD5CE22C645D218EE4F2233C2BE4B0F81F3"
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
    /// ShopWindow
    /// </summary>
    public partial class ShopWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 14 "..\..\..\ShopWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dtgShop;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\ShopWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbUpShop;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\ShopWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbDownShop;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\ShopWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSearchShop;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\ShopWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbViewShop;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\ShopWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddShop;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\ShopWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnDeleteShop;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\ShopWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnBackShop;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/shopwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ShopWindow.xaml"
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
            this.dtgShop = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.rbUpShop = ((System.Windows.Controls.RadioButton)(target));
            
            #line 50 "..\..\..\ShopWindow.xaml"
            this.rbUpShop.Click += new System.Windows.RoutedEventHandler(this.rbUpShop_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.rbDownShop = ((System.Windows.Controls.RadioButton)(target));
            
            #line 52 "..\..\..\ShopWindow.xaml"
            this.rbDownShop.Click += new System.Windows.RoutedEventHandler(this.rbDownShop_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtSearchShop = ((System.Windows.Controls.TextBox)(target));
            
            #line 56 "..\..\..\ShopWindow.xaml"
            this.txtSearchShop.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtSearchShop_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.cmbViewShop = ((System.Windows.Controls.ComboBox)(target));
            
            #line 59 "..\..\..\ShopWindow.xaml"
            this.cmbViewShop.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbViewShop_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnAddShop = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\..\ShopWindow.xaml"
            this.btnAddShop.Click += new System.Windows.RoutedEventHandler(this.btnAddShop_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BtnDeleteShop = ((System.Windows.Controls.Button)(target));
            
            #line 65 "..\..\..\ShopWindow.xaml"
            this.BtnDeleteShop.Click += new System.Windows.RoutedEventHandler(this.BtnDeleteShop_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.BtnBackShop = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\..\ShopWindow.xaml"
            this.BtnBackShop.Click += new System.Windows.RoutedEventHandler(this.BtnBackShop_Click);
            
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
            
            #line 37 "..\..\..\ShopWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnEditShop_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}


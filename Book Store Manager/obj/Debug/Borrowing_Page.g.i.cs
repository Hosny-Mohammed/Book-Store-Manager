﻿#pragma checksum "..\..\Borrowing_Page.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BC759CFBBB066EE6E2EAB2345FE7D7E4CACC5DD5BE0D07CCE804ABBC4DAC16CB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Book_Store_Manager;
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


namespace Book_Store_Manager {
    
    
    /// <summary>
    /// Borrowing_Page
    /// </summary>
    public partial class Borrowing_Page : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 38 "..\..\Borrowing_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label name_label;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\Borrowing_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ID_label;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\Borrowing_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BookID_txt;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\Borrowing_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UserID_txt;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\Borrowing_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Borrow_btn;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\Borrowing_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid available_Books_DG;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\Borrowing_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Borrowed_Books_DG;
        
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
            System.Uri resourceLocater = new System.Uri("/Book Store Manager;component/borrowing_page.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Borrowing_Page.xaml"
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
            this.name_label = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.ID_label = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.BookID_txt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.UserID_txt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Borrow_btn = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\Borrowing_Page.xaml"
            this.Borrow_btn.Click += new System.Windows.RoutedEventHandler(this.Borrow_btn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 65 "..\..\Borrowing_Page.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.available_Books_DG = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 8:
            this.Borrowed_Books_DG = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


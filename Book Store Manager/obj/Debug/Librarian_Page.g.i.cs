﻿#pragma checksum "..\..\Librarian_Page.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B92492ED65D7113B3535CBFB2BD2391CFBF7A2CE07F20ED61596F6B4353EE61F"
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
    /// Librarian_Page
    /// </summary>
    public partial class Librarian_Page : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\Librarian_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label name_label;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\Librarian_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ID_txt;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\Librarian_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Title_txt;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\Librarian_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Auther_txt;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\Librarian_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ISBN_txt;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\Librarian_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Price_txt;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\Librarian_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Quantity_txt;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\Librarian_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Books_DataGrid;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\Librarian_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Borrower_Details;
        
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
            System.Uri resourceLocater = new System.Uri("/Book Store Manager;component/librarian_page.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Librarian_Page.xaml"
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
            this.ID_txt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Title_txt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Auther_txt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.ISBN_txt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.Price_txt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.Quantity_txt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            
            #line 87 "..\..\Librarian_Page.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Add_Book);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 91 "..\..\Librarian_Page.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Remove_Book);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Books_DataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 11:
            this.Borrower_Details = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


﻿#pragma checksum "D:\_Working\VS2010\Winform\WebManagement\WebManagement.Client\Views\Others\EditLinkView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CF6C91761BB49C447C859F012EDB112C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace WebManagement.Client {
    
    
    public partial class EditLinkView : Telerik.Windows.Controls.RadWindow {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBox txtTieuDe;
        
        internal System.Windows.Controls.TextBox txtDuongDan;
        
        internal Telerik.Windows.Controls.RadButton btnSave;
        
        internal Telerik.Windows.Controls.RadButton btnCancel;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/WebManagement.Client;component/Views/Others/EditLinkView.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.txtTieuDe = ((System.Windows.Controls.TextBox)(this.FindName("txtTieuDe")));
            this.txtDuongDan = ((System.Windows.Controls.TextBox)(this.FindName("txtDuongDan")));
            this.btnSave = ((Telerik.Windows.Controls.RadButton)(this.FindName("btnSave")));
            this.btnCancel = ((Telerik.Windows.Controls.RadButton)(this.FindName("btnCancel")));
        }
    }
}


﻿#pragma checksum "..\..\..\View\TimeControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "19251849CD3F0BC5447F1A313C90D4C1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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


namespace BookingClient.View {
    
    
    /// <summary>
    /// TimeControl
    /// </summary>
    public partial class TimeControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\View\TimeControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal BookingClient.View.TimeControl UserControl;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\View\TimeControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid LayoutRoot;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\View\TimeControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid hour;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\View\TimeControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox mmTxt;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\View\TimeControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid min;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\View\TimeControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ddTxt;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\View\TimeControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid sec;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\View\TimeControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox yyTxt;
        
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
            System.Uri resourceLocater = new System.Uri("/BookingClient;component/view/timecontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\TimeControl.xaml"
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
            this.UserControl = ((BookingClient.View.TimeControl)(target));
            return;
            case 2:
            this.LayoutRoot = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.hour = ((System.Windows.Controls.Grid)(target));
            
            #line 29 "..\..\..\View\TimeControl.xaml"
            this.hour.KeyDown += new System.Windows.Input.KeyEventHandler(this.OnContentChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.mmTxt = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.min = ((System.Windows.Controls.Grid)(target));
            
            #line 40 "..\..\..\View\TimeControl.xaml"
            this.min.KeyDown += new System.Windows.Input.KeyEventHandler(this.OnContentChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ddTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.sec = ((System.Windows.Controls.Grid)(target));
            
            #line 50 "..\..\..\View\TimeControl.xaml"
            this.sec.KeyDown += new System.Windows.Input.KeyEventHandler(this.OnContentChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.yyTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


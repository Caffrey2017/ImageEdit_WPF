﻿#pragma checksum "..\..\..\Windows\GradientBased.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B582F0778D49C0BFB6E23CA65C8346AB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
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


namespace ImageEdit_WPF.Windows {
    
    
    /// <summary>
    /// GradientBased
    /// </summary>
    public partial class GradientBased : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 38 "..\..\..\Windows\GradientBased.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbFilters;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Windows\GradientBased.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdbFirstDerivative;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Windows\GradientBased.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rdbSecondDerivative;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Windows\GradientBased.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbThreshold;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\Windows\GradientBased.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbRedFactor;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\Windows\GradientBased.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbGreenFactor;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\Windows\GradientBased.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbBlueFactor;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\Windows\GradientBased.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ok;
        
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
            System.Uri resourceLocater = new System.Uri("/ImageEdit_WPF;component/windows/gradientbased.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\GradientBased.xaml"
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
            this.cmbFilters = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.rdbFirstDerivative = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 3:
            this.rdbSecondDerivative = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 4:
            this.txbThreshold = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txbRedFactor = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txbGreenFactor = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txbBlueFactor = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.ok = ((System.Windows.Controls.Button)(target));
            
            #line 70 "..\..\..\Windows\GradientBased.xaml"
            this.ok.Click += new System.Windows.RoutedEventHandler(this.Ok_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


﻿#pragma checksum "..\..\..\..\ColorPicker\Pickers\LabPicker.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "75B497BF104626500EC9289C6643CEF3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Imagin.Common;
using Imagin.Controls.Common;
using Imagin.Controls.Extended;
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


namespace Imagin.Controls.Extended {
    
    
    /// <summary>
    /// LabDisplay
    /// </summary>
    public partial class LabDisplay : Imagin.Controls.Extended.NormalizedComponentDisplay, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\..\ColorPicker\Pickers\LabPicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rL;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\ColorPicker\Pickers\LabPicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Imagin.Controls.Common.AdvancedTextBox txtL;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\ColorPicker\Pickers\LabPicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rA;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\ColorPicker\Pickers\LabPicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Imagin.Controls.Common.AdvancedTextBox txtA;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\ColorPicker\Pickers\LabPicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rB;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\..\ColorPicker\Pickers\LabPicker.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Imagin.Controls.Common.AdvancedTextBox txtB;
        
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
            System.Uri resourceLocater = new System.Uri("/Imagin.Controls.Extended;component/colorpicker/pickers/labpicker.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\ColorPicker\Pickers\LabPicker.xaml"
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
            this.rL = ((System.Windows.Controls.RadioButton)(target));
            
            #line 24 "..\..\..\..\ColorPicker\Pickers\LabPicker.xaml"
            this.rL.Checked += new System.Windows.RoutedEventHandler(this.OnChecked);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtL = ((Imagin.Controls.Common.AdvancedTextBox)(target));
            
            #line 35 "..\..\..\..\ColorPicker\Pickers\LabPicker.xaml"
            this.txtL.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.OnTextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.rA = ((System.Windows.Controls.RadioButton)(target));
            
            #line 42 "..\..\..\..\ColorPicker\Pickers\LabPicker.xaml"
            this.rA.Checked += new System.Windows.RoutedEventHandler(this.OnChecked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtA = ((Imagin.Controls.Common.AdvancedTextBox)(target));
            
            #line 54 "..\..\..\..\ColorPicker\Pickers\LabPicker.xaml"
            this.txtA.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.OnTextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.rB = ((System.Windows.Controls.RadioButton)(target));
            
            #line 61 "..\..\..\..\ColorPicker\Pickers\LabPicker.xaml"
            this.rB.Checked += new System.Windows.RoutedEventHandler(this.OnChecked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtB = ((Imagin.Controls.Common.AdvancedTextBox)(target));
            
            #line 73 "..\..\..\..\ColorPicker\Pickers\LabPicker.xaml"
            this.txtB.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.OnTextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

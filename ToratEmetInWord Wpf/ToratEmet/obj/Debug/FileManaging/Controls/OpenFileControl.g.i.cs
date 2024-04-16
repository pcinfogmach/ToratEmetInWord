﻿#pragma checksum "..\..\..\..\FileManaging\Controls\OpenFileControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FC8BC7064A9D0E46E70BD6C630B52DFF64395E648CCE9064BC08300E0D76AFDA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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
using System.Windows.Forms.Integration;
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
using ToratEmet.Controls;
using ToratEmet.TreeModels;


namespace ToratEmet.Controls {
    
    
    /// <summary>
    /// OpenFileControl
    /// </summary>
    public partial class OpenFileControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 45 "..\..\..\..\FileManaging\Controls\OpenFileControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SearchComboBox;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\..\FileManaging\Controls\OpenFileControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchTextBox;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\..\FileManaging\Controls\OpenFileControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox RecentSearchesCombo;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\..\FileManaging\Controls\OpenFileControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SearchButton;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\..\FileManaging\Controls\OpenFileControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RecentSearchesButton;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\..\FileManaging\Controls\OpenFileControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeView treeView;
        
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
            System.Uri resourceLocater = new System.Uri("/ToratEmet;component/filemanaging/controls/openfilecontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\FileManaging\Controls\OpenFileControl.xaml"
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
            this.SearchComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 48 "..\..\..\..\FileManaging\Controls\OpenFileControl.xaml"
            this.SearchComboBox.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.SearchComboBox_PreviewKeyDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.SearchTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 71 "..\..\..\..\FileManaging\Controls\OpenFileControl.xaml"
            this.SearchTextBox.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.SearchTextBox_PreviewKeyDown);
            
            #line default
            #line hidden
            
            #line 72 "..\..\..\..\FileManaging\Controls\OpenFileControl.xaml"
            this.SearchTextBox.GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.SearchTextBox_GotKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.RecentSearchesCombo = ((System.Windows.Controls.ComboBox)(target));
            
            #line 80 "..\..\..\..\FileManaging\Controls\OpenFileControl.xaml"
            this.RecentSearchesCombo.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.RecentSearchesCombo_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.SearchButton = ((System.Windows.Controls.Button)(target));
            
            #line 85 "..\..\..\..\FileManaging\Controls\OpenFileControl.xaml"
            this.SearchButton.Click += new System.Windows.RoutedEventHandler(this.SearchButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.RecentSearchesButton = ((System.Windows.Controls.Button)(target));
            
            #line 91 "..\..\..\..\FileManaging\Controls\OpenFileControl.xaml"
            this.RecentSearchesButton.Click += new System.Windows.RoutedEventHandler(this.RecentSearchesButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.treeView = ((System.Windows.Controls.TreeView)(target));
            
            #line 98 "..\..\..\..\FileManaging\Controls\OpenFileControl.xaml"
            this.treeView.KeyDown += new System.Windows.Input.KeyEventHandler(this.treeView_KeyDown);
            
            #line default
            #line hidden
            
            #line 98 "..\..\..\..\FileManaging\Controls\OpenFileControl.xaml"
            this.treeView.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.treeView_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            System.Windows.EventSetter eventSetter;
            switch (connectionId)
            {
            case 2:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.PreviewMouseDownEvent;
            
            #line 59 "..\..\..\..\FileManaging\Controls\OpenFileControl.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.SearchComboBoxItem_PreviewMouseDown);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            }
        }
    }
}

﻿#pragma checksum "..\..\Window3.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B29936A136F421D17EE9C9D63EEDB028B8738532"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
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
using WpfApplication5;


namespace WpfApplication5 {
    
    
    /// <summary>
    /// Window3
    /// </summary>
    public partial class Window3 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 69 "..\..\Window3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textBlock;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\Window3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image img1;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\Window3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Images_5_jpg;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\Window3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ExitButton;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\Window3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Retour;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\Window3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image img2;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\Window3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse ellipse1;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\Window3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse ellipse2;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\Window3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse ellipse3;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\Window3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image img3;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\Window3.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement MyMediaElement;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApplication5;component/window3.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Window3.xaml"
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
            this.textBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.img1 = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.Images_5_jpg = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.ExitButton = ((System.Windows.Controls.Button)(target));
            
            #line 81 "..\..\Window3.xaml"
            this.ExitButton.Click += new System.Windows.RoutedEventHandler(this.ExitButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Retour = ((System.Windows.Controls.Button)(target));
            
            #line 82 "..\..\Window3.xaml"
            this.Retour.Click += new System.Windows.RoutedEventHandler(this.retour);
            
            #line default
            #line hidden
            return;
            case 6:
            this.img2 = ((System.Windows.Controls.Image)(target));
            return;
            case 7:
            this.ellipse1 = ((System.Windows.Shapes.Ellipse)(target));
            
            #line 84 "..\..\Window3.xaml"
            this.ellipse1.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ellipse1_MD);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ellipse2 = ((System.Windows.Shapes.Ellipse)(target));
            
            #line 85 "..\..\Window3.xaml"
            this.ellipse2.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ellipse2_MD);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ellipse3 = ((System.Windows.Shapes.Ellipse)(target));
            
            #line 86 "..\..\Window3.xaml"
            this.ellipse3.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ellipse3_MD);
            
            #line default
            #line hidden
            return;
            case 10:
            this.img3 = ((System.Windows.Controls.Image)(target));
            return;
            case 11:
            this.MyMediaElement = ((System.Windows.Controls.MediaElement)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}


﻿#pragma checksum "..\..\..\SessionsWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7973F44A35D34C8020E38B782F2808564465EDA7"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using CinemaApp;
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


namespace CinemaApp {
    
    
    /// <summary>
    /// SessionsWindow
    /// </summary>
    public partial class SessionsWindow : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\SessionsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonViewSessionDetails;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\SessionsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonCreateNewSession;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\SessionsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listViewFutureSessions;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/CinemaApp;V1.0.0.0;component/sessionswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\SessionsWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.buttonViewSessionDetails = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\..\SessionsWindow.xaml"
            this.buttonViewSessionDetails.Click += new System.Windows.RoutedEventHandler(this.buttonViewSessionDetails_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.buttonCreateNewSession = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\SessionsWindow.xaml"
            this.buttonCreateNewSession.Click += new System.Windows.RoutedEventHandler(this.buttonCreateNewSession_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.listViewFutureSessions = ((System.Windows.Controls.ListView)(target));
            
            #line 15 "..\..\..\SessionsWindow.xaml"
            this.listViewFutureSessions.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.listViewFutureSessions_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


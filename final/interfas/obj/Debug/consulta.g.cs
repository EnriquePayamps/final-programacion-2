﻿#pragma checksum "..\..\consulta.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "AFB41AA9E3D6693C01809A64BECE2A0AD89EC7F8"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
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


namespace interfas {
    
    
    /// <summary>
    /// consulta
    /// </summary>
    public partial class consulta : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\consulta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtnombre;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\consulta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtventas;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\consulta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtestado;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\consulta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgdatos;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\consulta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnmostrar;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\consulta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbuscar;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\consulta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnmodificar;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\consulta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btneliminar;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\consulta.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnvolver;
        
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
            System.Uri resourceLocater = new System.Uri("/interfas;component/consulta.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\consulta.xaml"
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
            this.txtnombre = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtventas = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtestado = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.dgdatos = ((System.Windows.Controls.DataGrid)(target));
            
            #line 19 "..\..\consulta.xaml"
            this.dgdatos.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dgdatos_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnmostrar = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\consulta.xaml"
            this.btnmostrar.Click += new System.Windows.RoutedEventHandler(this.btnmostrar_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtbuscar = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.btnmodificar = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\consulta.xaml"
            this.btnmodificar.Click += new System.Windows.RoutedEventHandler(this.btnmodificar_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btneliminar = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\consulta.xaml"
            this.btneliminar.Click += new System.Windows.RoutedEventHandler(this.btneliminar_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnvolver = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\consulta.xaml"
            this.btnvolver.Click += new System.Windows.RoutedEventHandler(this.btnvolver_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


﻿#pragma checksum "..\..\Direсtor.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F3BF145391D282C7069572C78BE50AA4688D24C6AB8EF1341E7E98CF74337E37"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using Torti;


namespace Torti {
    
    
    /// <summary>
    /// Direсtor
    /// </summary>
    public partial class Direсtor : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 62 "..\..\Direсtor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid BasaTable;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\Direсtor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OutInstr;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\Direсtor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddInstr;
        
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
            System.Uri resourceLocater = new System.Uri("/Torti;component/dire%d1%81tor.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Direсtor.xaml"
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
            this.BasaTable = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.OutInstr = ((System.Windows.Controls.Button)(target));
            
            #line 70 "..\..\Direсtor.xaml"
            this.OutInstr.Click += new System.Windows.RoutedEventHandler(this.OutInstr_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.AddInstr = ((System.Windows.Controls.Button)(target));
            
            #line 87 "..\..\Direсtor.xaml"
            this.AddInstr.Click += new System.Windows.RoutedEventHandler(this.AddInstr_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 103 "..\..\Direсtor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.UkrTortClick);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 118 "..\..\Direсtor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DelUkrClick);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 135 "..\..\Direсtor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.IngridClick);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 150 "..\..\Direсtor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DelIngClick);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 164 "..\..\Direсtor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EditIngClick);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 179 "..\..\Direсtor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OutClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}


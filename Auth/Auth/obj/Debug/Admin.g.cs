#pragma checksum "..\..\Admin.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6E9BC92CA12AA6B03E7E0751746D438EF024D452D3A1657E25A379D47D8AAD9F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Auth;
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


namespace Auth
{


    /// <summary>
    /// Admin
    /// </summary>
    public partial class Admin : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 10 "..\..\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgr;

#line default
#line hidden


#line 11 "..\..\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox idtxt;

#line default
#line hidden


#line 12 "..\..\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DELETE;

#line default
#line hidden


#line 13 "..\..\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UPDATE;

#line default
#line hidden


#line 14 "..\..\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label idlbl;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Auth;component/admin.xaml", System.UriKind.Relative);

#line 1 "..\..\Admin.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.dgr = ((System.Windows.Controls.DataGrid)(target));

#line 10 "..\..\Admin.xaml"
                    this.dgr.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.dgr_MouseDoubleClick);

#line default
#line hidden
                    return;
                case 2:
                    this.idtxt = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 3:
                    this.DELETE = ((System.Windows.Controls.Button)(target));

#line 12 "..\..\Admin.xaml"
                    this.DELETE.Click += new System.Windows.RoutedEventHandler(this.DELETE_Click);

#line default
#line hidden
                    return;
                case 4:
                    this.UPDATE = ((System.Windows.Controls.Button)(target));
                    return;
                case 5:
                    this.idlbl = ((System.Windows.Controls.Label)(target));
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.TextBox us;
        internal System.Windows.Controls.TextBox pa;
        internal System.Windows.Controls.TextBox ro;
        internal System.Windows.Controls.TextBox fi;
    }
}


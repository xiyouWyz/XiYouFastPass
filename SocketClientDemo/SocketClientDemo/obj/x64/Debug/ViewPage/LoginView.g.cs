﻿#pragma checksum "E:\XiYouFastPass\SocketClientDemo\SocketClientDemo\ViewPage\LoginView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "43683F84BF21BBE1C0B70AC13B9400D5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SocketClientDemo.ViewPage
{
    partial class LoginView : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.one = (global::Windows.UI.Xaml.Controls.RelativePanel)(target);
                }
                break;
            case 2:
                {
                    this.two = (global::Windows.UI.Xaml.Controls.RelativePanel)(target);
                }
                break;
            case 3:
                {
                    this.btn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 20 "..\..\..\ViewPage\LoginView.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btn).Click += this.OnConnect;
                    #line default
                }
                break;
            case 4:
                {
                    global::Windows.UI.Xaml.Controls.TextBlock element4 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    #line 21 "..\..\..\ViewPage\LoginView.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBlock)element4).Tapped += this.Close_Tapped;
                    #line default
                }
                break;
            case 5:
                {
                    this.port = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6:
                {
                    this.TB_CountText = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7:
                {
                    this.ip = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8:
                {
                    this.TB_IPText = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}


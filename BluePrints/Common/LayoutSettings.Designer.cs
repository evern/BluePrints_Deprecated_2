﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BluePrints.Common
{


    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class LayoutSettings : global::System.Configuration.ApplicationSettingsBase
    {

        private static LayoutSettings defaultInstance = ((LayoutSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new LayoutSettings())));

        public static LayoutSettings Default
        {
            get
            {
                return defaultInstance;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string LogicalLayout
        {
            get
            {
                return ((string)(this["LogicalLayout"]));
            }
            set
            {
                this["LogicalLayout"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ViewsLayout
        {
            get
            {
                return ((string)(this["ViewsLayout"]));
            }
            set
            {
                this["ViewsLayout"] = value;
            }
        }
    }
}

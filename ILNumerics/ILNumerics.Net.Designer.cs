﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.42
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ILNumerics {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "8.0.0.0")]
    internal sealed partial class ILNumerics : global::System.Configuration.ApplicationSettingsBase {
        
        private static ILNumerics defaultInstance = ((ILNumerics)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new ILNumerics())));
        
        public static ILNumerics Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0.000000000000000222")]
        public decimal eps {
            get {
                return ((decimal)(this["eps"]));
            }
            set {
                this["eps"] = value;
            }
        }
    }
}

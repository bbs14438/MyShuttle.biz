﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyShuttle.Device.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("myshuttle2")]
        public string EventHubName {
            get {
                return ((string)(this["EventHubName"]));
            }
            set {
                this["EventHubName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("50")]
        public int NumDataRegisters {
            get {
                return ((int)(this["NumDataRegisters"]));
            }
            set {
                this["NumDataRegisters"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3")]
        public int CrashDataRegisters {
            get {
                return ((int)(this["CrashDataRegisters"]));
            }
            set {
                this["CrashDataRegisters"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("OBD_SB001")]
        public string OBDSecurityBeltOn {
            get {
                return ((string)(this["OBDSecurityBeltOn"]));
            }
            set {
                this["OBDSecurityBeltOn"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("OBD_SB002")]
        public string OBDSecurityBeltOff {
            get {
                return ((string)(this["OBDSecurityBeltOff"]));
            }
            set {
                this["OBDSecurityBeltOff"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("OBD_P283")]
        public string OBDParkingOn {
            get {
                return ((string)(this["OBDParkingOn"]));
            }
            set {
                this["OBDParkingOn"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("OBD_P284")]
        public string OBDParkingOff {
            get {
                return ((string)(this["OBDParkingOff"]));
            }
            set {
                this["OBDParkingOff"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("OBD_F678")]
        public string OBDFuelOn {
            get {
                return ((string)(this["OBDFuelOn"]));
            }
            set {
                this["OBDFuelOn"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("OBD_F679")]
        public string OBDFuelOff {
            get {
                return ((string)(this["OBDFuelOff"]));
            }
            set {
                this["OBDFuelOff"] = value;
            }
        }
    }
}

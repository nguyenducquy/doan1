﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectQuanlyNhahang.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=HUNGREOHR7\\SQLEXPRESS;Initial Catalog=\"Restaurant Manager\";Integrated" +
            " Security=True")]
        public string Restaurant_ManagerConnectionString {
            get {
                return ((string)(this["Restaurant_ManagerConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=HUNGREOHR7\\SQLEXPRESS;Initial Catalog=QuanLyNhaHang;Integrated Securi" +
            "ty=True")]
        public string QuanLyNhaHangConnectionString {
            get {
                return ((string)(this["QuanLyNhaHangConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=HUNGREOHR7\\HUNGREO;Initial Catalog=QuanLyNhaHang;Persist Security Inf" +
            "o=True;User ID=sa;Password=123456")]
        public string QuanLyNhaHangConnectionString1 {
            get {
                return ((string)(this["QuanLyNhaHangConnectionString1"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=HUNGREOHR7\\HUNGREO;Initial Catalog=QuanLyNhaHang;Persist Security Inf" +
            "o=True;User ID=sa")]
        public string QuanLyNhaHangConnectionString2 {
            get {
                return ((string)(this["QuanLyNhaHangConnectionString2"]));
            }
        }
    }
}
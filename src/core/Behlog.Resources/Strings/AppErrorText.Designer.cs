﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Behlog.Resources.Strings {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class AppErrorText {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal AppErrorText() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Behlog.Resources.Strings.AppErrorText", typeof(AppErrorText).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to لطفاً ایمیل خود را تایید کنید..
        /// </summary>
        public static string LoginEmailNotVerified {
            get {
                return ResourceManager.GetString("LoginEmailNotVerified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to کلمه عبور یا نام کاربری اشتباه است..
        /// </summary>
        public static string LoginInvallidUserPass {
            get {
                return ResourceManager.GetString("LoginInvallidUserPass", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to عدم دسترسی ورود به سیستم. لطفاً با پشتیبانی تماس بگیرید..
        /// </summary>
        public static string LoginIsNotAllowed {
            get {
                return ResourceManager.GetString("LoginIsNotAllowed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to حساب کاربری شما قفل شده است..
        /// </summary>
        public static string LoginLockedOut {
            get {
                return ResourceManager.GetString("LoginLockedOut", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to نام کاربری و یا کلمه‌ی عبور وارد شده معتبر نیستند.
        /// </summary>
        public static string LoginNotValid {
            get {
                return ResourceManager.GetString("LoginNotValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to اکانت شما غیرفعال شده است..
        /// </summary>
        public static string LoginUserDisabled {
            get {
                return ResourceManager.GetString("LoginUserDisabled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to تاریخ وارد شده اشتباه است..
        /// </summary>
        public static string PersianDate_Invalid {
            get {
                return ResourceManager.GetString("PersianDate_Invalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to این آدرس ایمیل قبلاً ثبت شده است..
        /// </summary>
        public static string Subscriber_Email_Exist {
            get {
                return ResourceManager.GetString("Subscriber_Email_Exist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to خطایی در سیستم ایجاد شده. لطفاً دوباره تلاش کنید..
        /// </summary>
        public static string Subscriber_Error {
            get {
                return ResourceManager.GetString("Subscriber_Error", resourceCulture);
            }
        }
    }
}
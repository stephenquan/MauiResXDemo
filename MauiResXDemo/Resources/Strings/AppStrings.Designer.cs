
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// 
// This template generates PublicResXFileCodeGenerator compatible code plus some
// useful extensions. 
// 
// The original version provided by ResXResourceManager is restricted to resource key names
// that are valid c# identifiers to keep this template simple (KISS!).
// 
// Us it as it is or as a scaffold to generate the code you need.
//
// As long as you have ResXResourceManager running in the background, the generated code 
// will be kept up to date.
//  
// Support runtime changes by Stephen Quan.
//------------------------------------------------------------------------------

namespace MauiResXDemo.Resources.Strings {
    using System;
    using System.ComponentModel;

    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by a text template.
    // To add or remove a member, edit your .ResX file.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ResXResourceManager", "1.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public static class AppStrings {
        /// <summary>
        ///   A singleton instance of the <see cref="AppStringsObj"/> class.
        /// </summary>
        public static AppStringsObj Instance { get; } = new AppStringsObj();
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MauiResXDemo.Resources.Strings.AppStrings", typeof(AppStrings).Assembly);
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
            get => Instance.Culture;
            set => Instance.Culture = value;
        }

        /// <summary>
        ///   Looks up a localized string similar to "Click me"
        /// </summary>
        public static string BTN_CLICK_ME => Instance.BTN_CLICK_ME;

        /// <summary>
        ///   Looks up a localized string similar to "Clicked {0} times"
        /// </summary>
        public static string BTN_CLICKED_N_TIMES => Instance.BTN_CLICKED_N_TIMES;

        /// <summary>
        ///   Looks up a localized string similar to "Hello, World!"
        /// </summary>
        public static string LBL_HELLO => Instance.LBL_HELLO;

        /// <summary>
        ///   Looks up a localized string similar to "Welcome to .NET MAUI"
        /// </summary>
        public static string LBL_WELCOME => Instance.LBL_WELCOME;

        /// <summary>
        ///   Looks up a localized string similar to "Home"
        /// </summary>
        public static string TITLE_HOME => Instance.TITLE_HOME;

        /// <summary>
        /// Used to notify when localized properties have changed.
        /// </summary>
        public static void Invalidate() => Instance.Invalidate();
    }

        /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by a text template.
    // To add or remove a member, edit your .ResX file.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ResXResourceManager", "1.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class AppStringsObj : INotifyPropertyChanged {
        static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        public AppStringsObj() { }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
                Invalidate();
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to "Click me"
        /// </summary>
        public string BTN_CLICK_ME {
            get {
                return AppStrings.ResourceManager.GetString("BTN_CLICK_ME", resourceCulture) ?? string.Empty;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to "Clicked {0} times"
        /// </summary>
        public string BTN_CLICKED_N_TIMES {
            get {
                return AppStrings.ResourceManager.GetString("BTN_CLICKED_N_TIMES", resourceCulture) ?? string.Empty;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to "Hello, World!"
        /// </summary>
        public string LBL_HELLO {
            get {
                return AppStrings.ResourceManager.GetString("LBL_HELLO", resourceCulture) ?? string.Empty;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to "Welcome to .NET MAUI"
        /// </summary>
        public string LBL_WELCOME {
            get {
                return AppStrings.ResourceManager.GetString("LBL_WELCOME", resourceCulture) ?? string.Empty;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to "Home"
        /// </summary>
        public string TITLE_HOME {
            get {
                return AppStrings.ResourceManager.GetString("TITLE_HOME", resourceCulture) ?? string.Empty;
            }
        }

        /// <summary>
        /// Used to notify when localized properties have changed.
        /// </summary>
        public void Invalidate() {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(string.Empty));
        }

        /// <summary>
        ///  The PropertyChanged event handler.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
    }

    /// <summary>
    /// Keys of all available strings in the applications resx-resources.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("ResXResourceManager", "1.0.0.0")]
    [global::System.Runtime.CompilerServices.CompilerGenerated]
    public enum StringResourceKey
    {
        /// <summary>
        ///   Looks up a localized string similar to Click me.
        /// </summary>
        BTN_CLICK_ME,
        /// <summary>
        ///   Looks up a localized string similar to Clicked {0} times.
        /// </summary>
        BTN_CLICKED_N_TIMES,
        /// <summary>
        ///   Looks up a localized string similar to Hello, World!.
        /// </summary>
        LBL_HELLO,
        /// <summary>
        ///   Looks up a localized string similar to Welcome to .NET MAUI.
        /// </summary>
        LBL_WELCOME,
        /// <summary>
        ///   Looks up a localized string similar to Home.
        /// </summary>
        TITLE_HOME,
    }

    /// <summary>
    /// Specifies a localized description for an object.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("ResXResourceManager", "1.0.0.0")]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [AttributeUsage(AttributeTargets.All, AllowMultiple=false)]
    public sealed class LocalizedDescriptionAttribute : System.ComponentModel.DescriptionAttribute
    {
        private readonly string _resourceKey;

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalizedDescriptionAttribute"/> class.
        /// </summary>
        /// <param name="resourceKey">The resource key of the associated resource.</param>
        public LocalizedDescriptionAttribute(StringResourceKey resourceKey)
        {
            _resourceKey = resourceKey.ToString();
        }

        /// <summary>
        /// Gets the localized description from the resource id stored in this attribute.
        /// </summary>
        public override string Description
        {
            get
            {
                return AppStrings.ResourceManager.GetString(_resourceKey);
            }
        }
    }

    /// <summary>
    /// Specifies a localized display name for an object.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("ResXResourceManager", "1.0.0.0")]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [AttributeUsage(AttributeTargets.All, AllowMultiple=false)]
    public sealed class LocalizedDisplayNameAttribute : System.ComponentModel.DisplayNameAttribute
    {
        private readonly string _resourceKey;

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalizedDisplayNameAttribute"/> class.
        /// </summary>
        /// <param name="resourceKey">The resource key of the associated resource.</param>
        public LocalizedDisplayNameAttribute(StringResourceKey resourceKey)
        {
            _resourceKey = resourceKey.ToString();
        }

        /// <summary>
        /// Gets the localized display name from the resource id stored in this attribute.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return AppStrings.ResourceManager.GetString(_resourceKey);
            }
        }
    }

    /// <summary>
    /// Specifies a localized category for an object.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("ResXResourceManager", "1.0.0.0")]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [AttributeUsage(AttributeTargets.All, AllowMultiple=false)]
    public sealed class LocalizedCategoryAttribute : System.ComponentModel.CategoryAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocalizedCategoryAttribute"/> class.
        /// </summary>
        /// <param name="resourceKey">The resource key of the associated resource.</param>
        public LocalizedCategoryAttribute(StringResourceKey resourceKey)
            : base(resourceKey.ToString())
        {
        }

        /// <summary>
        /// Gets the localized category name from the resource id stored in this attribute.
        /// </summary>
        protected override string GetLocalizedString(string value)
        {
            return AppStrings.ResourceManager.GetString(value);
        }
    }

    /// <summary>
    /// A localizable version of the <see cref="System.ComponentModel.DataAnnotations.DataTypeAttribute"/> class.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("ResXResourceManager", "1.0.0.0")]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.Property, AllowMultiple = false)]
    public class DataTypeAttribute : System.ComponentModel.DataAnnotations.DataTypeAttribute
    {
        private StringResourceKey _resourceKey;

        /// <summary>
        /// Initializes a new instance of the <see cref="DataTypeAttribute"/> class.
        /// </summary>
        public DataTypeAttribute(StringResourceKey resourceKey, System.ComponentModel.DataAnnotations.DataType dataType)
            : base(dataType)
        {
            ResourceKey = resourceKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataTypeAttribute"/> class.
        /// </summary>
        public DataTypeAttribute(StringResourceKey resourceKey, string customDataType)
            : base(customDataType)
        {
            ResourceKey = resourceKey;
        }

        /// <summary>
        /// Gets or sets the resource key.
        /// </summary>
        public StringResourceKey ResourceKey
        {
            get
            {
                return _resourceKey;
            }
            set
            {
                _resourceKey = value;
                ErrorMessageResourceType = typeof(AppStrings);
                ErrorMessageResourceName = value.ToString();
            }
        }
    }
    
    /// <summary>
    /// A localizable version of the <see cref="System.ComponentModel.DataAnnotations.RangeAttribute"/> class.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("ResXResourceManager", "1.0.0.0")]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.Property, AllowMultiple = false)]
    public class RangeAttribute : System.ComponentModel.DataAnnotations.RangeAttribute
    {
        private StringResourceKey _resourceKey;

        /// <summary>
        /// Initializes a new instance of the <see cref="RangeAttribute"/> class.
        /// </summary>
        public RangeAttribute(StringResourceKey resourceKey, int minimum, int maximum)
            : base(minimum, maximum)
        {
            ResourceKey = resourceKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RangeAttribute"/> class.
        /// </summary>
        public RangeAttribute(StringResourceKey resourceKey, double minimum, double maximum)
            : base(minimum, maximum)
        {
            ResourceKey = resourceKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RangeAttribute"/> class.
        /// </summary>
        public RangeAttribute(StringResourceKey resourceKey, Type type, string minimum, string maximum)
            : base(type, minimum, maximum)
        {
            ResourceKey = resourceKey;
        }

        /// <summary>
        /// Gets or sets the resource key.
        /// </summary>
        public StringResourceKey ResourceKey
        {
            get
            {
                return _resourceKey;
            }
            set
            {
                _resourceKey = value;
                ErrorMessageResourceType = typeof(AppStrings);
                ErrorMessageResourceName = value.ToString();
            }
        }
    }
    
    /// <summary>
    /// A localizable version of the <see cref="System.ComponentModel.DataAnnotations.RegularExpressionAttribute"/> class.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("ResXResourceManager", "1.0.0.0")]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.Property, AllowMultiple = false)]
    public class RegularExpressionAttribute : System.ComponentModel.DataAnnotations.RegularExpressionAttribute
    {
        private StringResourceKey _resourceKey;

        /// <summary>
        /// Initializes a new instance of the <see cref="RegularExpressionAttribute"/> class.
        /// </summary>
        public RegularExpressionAttribute(StringResourceKey resourceKey, string pattern)
            : base(pattern)
        {
            ResourceKey = resourceKey;
        }

        /// <summary>
        /// Gets or sets the resource key.
        /// </summary>
        public StringResourceKey ResourceKey
        {
            get
            {
                return _resourceKey;
            }
            set
            {
                _resourceKey = value;
                ErrorMessageResourceType = typeof(AppStrings);
                ErrorMessageResourceName = value.ToString();
            }
        }
    }
    
    /// <summary>
    /// A localizable version of the <see cref="System.ComponentModel.DataAnnotations.RequiredAttribute"/> class.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("ResXResourceManager", "1.0.0.0")]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.Property, AllowMultiple = false)]
    public class RequiredAttribute : System.ComponentModel.DataAnnotations.RequiredAttribute
    {
        private StringResourceKey _resourceKey;

        /// <summary>
        /// Initializes a new instance of the <see cref="RequiredAttribute"/> class.
        /// </summary>
        public RequiredAttribute(StringResourceKey resourceKey)
            : base()
        {
            ResourceKey = resourceKey;
        }

        /// <summary>
        /// Gets or sets the resource key.
        /// </summary>
        public StringResourceKey ResourceKey
        {
            get
            {
                return _resourceKey;
            }
            set
            {
                _resourceKey = value;
                ErrorMessageResourceType = typeof(AppStrings);
                ErrorMessageResourceName = value.ToString();
            }
        }
    }
    
    /// <summary>
    /// A localizable version of the <see cref="System.ComponentModel.DataAnnotations.StringLengthAttribute"/> class.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("ResXResourceManager", "1.0.0.0")]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.Property, AllowMultiple = false)]
    public class StringLengthAttribute : System.ComponentModel.DataAnnotations.StringLengthAttribute
    {
        private StringResourceKey _resourceKey;

        /// <summary>
        /// Initializes a new instance of the <see cref="StringLengthAttribute"/> class.
        /// </summary>
        public StringLengthAttribute(StringResourceKey resourceKey, int maximumLength)
            : base(maximumLength)
        {
            ResourceKey = resourceKey;
        }

        /// <summary>
        /// Gets or sets the resource key.
        /// </summary>
        public StringResourceKey ResourceKey
        {
            get
            {
                return _resourceKey;
            }
            set
            {
                _resourceKey = value;
                ErrorMessageResourceType = typeof(AppStrings);
                ErrorMessageResourceName = value.ToString();
            }
        }
    }
    

}

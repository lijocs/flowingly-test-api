﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SDC.Api.Tests {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SDC.Api.Tests.Strings", typeof(Strings).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hi Patricia,
        ///Please create an expense claim for the below. Relevant details are marked up as requested...
        ///&lt;expense&gt;&lt;costcentre&gt;DEV632&lt;/costcentre&gt;&lt;total&gt;35,000&lt;/total&gt;&lt;payment_method&gt;personal
        ///card&lt;/payment_method&gt;&lt;/expense&gt;
        ///From: William Steele
        ///Sent: Friday, 16 June 2022 10:32 AM
        ///To: Maria Washington
        ///Subject: test
        ///Hi Maria,
        ///Please create a reservation for 10 at the &lt;vendor&gt;Seaside Steakhouse&lt;/vendor&gt; for our
        ///&lt;description&gt;development team’s project end celebration&lt;/description&gt; on &lt;date&gt;27 April
        ///2 [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string CostCentreMissingMessageFormat {
            get {
                return ResourceManager.GetString("CostCentreMissingMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UNKNOWN.
        /// </summary>
        internal static string CostCentreUnknown {
            get {
                return ResourceManager.GetString("CostCentreUnknown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hi Patricia,
        ///Please create an expense claim for the below. Relevant details are marked up as requested...
        ///&lt;expense1&gt;&lt;cost_centre&gt;DEV632&lt;/cost_centre&gt;&lt;total&gt;35,000&lt;/total&gt;&lt;payment_method&gt;personal
        ///card&lt;/payment_method&gt;&lt;/expense&gt;
        ///From: William Steele
        ///Sent: Friday, 16 June 2022 10:32 AM
        ///To: Maria Washington
        ///Subject: test
        ///Hi Maria,
        ///Please create a reservation for 10 at the &lt;vendor&gt;Seaside Steakhouse&lt;/vendor&gt; for our
        ///&lt;description&gt;development team’s project end celebration&lt;/description&gt; on &lt;date&gt;27 April [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string InvalidMessageFormat {
            get {
                return ResourceManager.GetString("InvalidMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hi Patricia,
        ///Please create an expense claim for the below. Relevant details are marked up as requested...
        ///&lt;expense&gt;&lt;cost_centre&gt;DEV632&lt;/cost_centre&gt;&lt;totall&gt;35,000&lt;/totall&gt;&lt;payment_method&gt;personal
        ///card&lt;/payment_method&gt;&lt;/expense&gt;
        ///From: William Steele
        ///Sent: Friday, 16 June 2022 10:32 AM
        ///To: Maria Washington
        ///Subject: test
        ///Hi Maria,
        ///Please create a reservation for 10 at the &lt;vendor&gt;Seaside Steakhouse&lt;/vendor&gt; for our
        ///&lt;description&gt;development team’s project end celebration&lt;/description&gt; on &lt;date&gt;27 Apri [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string TotalFieldMissingMessageFormat {
            get {
                return ResourceManager.GetString("TotalFieldMissingMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hi Patricia,
        ///Please create an expense claim for the below. Relevant details are marked up as requested...
        ///&lt;expense&gt;&lt;cost_centre&gt;DEV632&lt;/cost_centre&gt;&lt;total&gt;35,000&lt;/total&gt;&lt;payment_method&gt;personal
        ///card&lt;/payment_method&gt;&lt;/expense&gt;
        ///From: William Steele
        ///Sent: Friday, 16 June 2022 10:32 AM
        ///To: Maria Washington
        ///Subject: test
        ///Hi Maria,
        ///Please create a reservation for 10 at the &lt;vendor&gt;Seaside Steakhouse&lt;/vendor&gt; for our
        ///&lt;description&gt;development team’s project end celebration&lt;/description&gt; on &lt;date&gt;27 April
        /// [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ValidMessageFormat {
            get {
                return ResourceManager.GetString("ValidMessageFormat", resourceCulture);
            }
        }
    }
}

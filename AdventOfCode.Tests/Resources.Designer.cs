﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdventOfCode.Tests {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AdventOfCode.Tests.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to 0 &lt;-&gt; 2
        ///1 &lt;-&gt; 1
        ///2 &lt;-&gt; 0, 3, 4
        ///3 &lt;-&gt; 2, 4
        ///4 &lt;-&gt; 2, 3, 6
        ///5 &lt;-&gt; 6
        ///6 &lt;-&gt; 4, 5.
        /// </summary>
        internal static string ExampleCommunicationGraph {
            get {
                return ResourceManager.GetString("ExampleCommunicationGraph", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to pbga (66)
        ///xhth (57)
        ///ebii (61)
        ///havc (66)
        ///ktlj (57)
        ///fwft (72) -&gt; ktlj, cntj, xhth
        ///qoyq (66)
        ///padx (45) -&gt; pbga, havc, qoyq
        ///tknk (41) -&gt; ugml, padx, fwft
        ///jptl (61)
        ///ugml (68) -&gt; gyxo, ebii, jptl
        ///gyxo (61)
        ///cntj (57).
        /// </summary>
        internal static string ExampleProgramTree {
            get {
                return ResourceManager.GetString("ExampleProgramTree", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to b inc 5 if a &gt; 1
        ///a inc 1 if b &lt; 5
        ///c dec -10 if a &gt;= 1
        ///c inc -20 if c == 10.
        /// </summary>
        internal static string ExampleRegisterInstructions {
            get {
                return ResourceManager.GetString("ExampleRegisterInstructions", resourceCulture);
            }
        }
    }
}

// Copyright (c) .NET Foundation and contributors. All rights reserved. Licensed under the Microsoft Reciprocal License. See LICENSE.TXT file in the project root for full license information.

namespace WixToolset.Core {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class WixStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal WixStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("WixToolset.Core.WixStrings", typeof(WixStrings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Could not find a unique identifier for the given resource name..
        /// </summary>
        internal static string EXP_CouldnotFileUniqueIDForResourceName {
            get {
                return ResourceManager.GetString("EXP_CouldnotFileUniqueIDForResourceName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Found an ActionRow with a non-existent {0} action: {1}..
        /// </summary>
        public static string EXP_FoundActionRowWinNonExistentAction {
            get {
                return ResourceManager.GetString("EXP_FoundActionRowWinNonExistentAction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Found an ActionRow with no Sequence, Before, or After column set..
        /// </summary>
        public static string EXP_FoundActionRowWithNoSequenceBeforeOrAfterColumnSet {
            get {
                return ResourceManager.GetString("EXP_FoundActionRowWithNoSequenceBeforeOrAfterColumnSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Multiple harvester extensions specified..
        /// </summary>
        internal static string EXP_MultipleHarvesterExtensionsSpecified {
            get {
                return ResourceManager.GetString("EXP_MultipleHarvesterExtensionsSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unexpected complex reference child type: {0}.
        /// </summary>
        internal static string EXP_UnexpectedComplexReferenceChildType {
            get {
                return ResourceManager.GetString("EXP_UnexpectedComplexReferenceChildType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unexpected entry section type: {0}.
        /// </summary>
        internal static string EXP_UnexpectedEntrySectionType {
            get {
                return ResourceManager.GetString("EXP_UnexpectedEntrySectionType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Encountered an unexpected error while merging &apos;{0}&apos;. More information about the merge and the failure can be found in the merge log: &apos;{1}&apos;.
        /// </summary>
        public static string EXP_UnexpectedMergerErrorInSourceFile {
            get {
                return ResourceManager.GetString("EXP_UnexpectedMergerErrorInSourceFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Encountered an unexpected merge error of type &apos;{0}&apos; for which there is currently no error message to display.  More information about the merge and the failure can be found in the merge log: &apos;{1}&apos;.
        /// </summary>
        public static string EXP_UnexpectedMergerErrorWithType {
            get {
                return ResourceManager.GetString("EXP_UnexpectedMergerErrorWithType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown platform enumeration &apos;{0}&apos; encountered..
        /// </summary>
        internal static string EXP_UnknownPlatformEnum {
            get {
                return ResourceManager.GetString("EXP_UnknownPlatformEnum", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}({1}).
        /// </summary>
        internal static string Format_FirstLineNumber {
            get {
                return ResourceManager.GetString("Format_FirstLineNumber", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}.
        /// </summary>
        internal static string Format_InfoMessage {
            get {
                return ResourceManager.GetString("Format_InfoMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: line {1}.
        /// </summary>
        internal static string Format_LineNumber {
            get {
                return ResourceManager.GetString("Format_LineNumber", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} : {1} {2}{3:0000} : {4}.
        /// </summary>
        internal static string Format_NonInfoMessage {
            get {
                return ResourceManager.GetString("Format_NonInfoMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Source trace:{0}.
        /// </summary>
        internal static string INF_SourceTrace {
            get {
                return ResourceManager.GetString("INF_SourceTrace", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to at {0}{1}.
        /// </summary>
        internal static string INF_SourceTraceLocation {
            get {
                return ResourceManager.GetString("INF_SourceTraceLocation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to error.
        /// </summary>
        internal static string MessageType_Error {
            get {
                return ResourceManager.GetString("MessageType_Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to warning.
        /// </summary>
        internal static string MessageType_Warning {
            get {
                return ResourceManager.GetString("MessageType_Warning", resourceCulture);
            }
        }
    }
}

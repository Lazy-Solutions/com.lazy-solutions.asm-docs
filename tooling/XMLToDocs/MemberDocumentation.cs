using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace AdvancedSceneManager.Documentation
{

    /// <summary>
    /// Holds documentation metadata for a reflected member.
    /// Typically populated by parsing XML doc files or Roslyn.
    /// </summary>
    public class MemberDocumentation
    {
        /// <summary>
        /// The reflection member this documentation belongs to.
        /// </summary>
        public MemberInfo Member { get; set; }

        public string Summary { get; set; }
        public string Remarks { get; set; }
        public string Example { get; set; }
        public Dictionary<string, string> Parameters { get; set; } = new();
        public Dictionary<string, string> TypeParameters { get; set; } = new();
        public string Returns { get; set; }
        public Dictionary<Type, string> Exceptions { get; set; } = new();
        public List<string> SeeAlso { get; set; } = new();
        public MemberInfo InheritsFrom { get; set; }
        public MemberInfo ImplicitlyInheritsFrom { get; set; }
        public string ObsoleteMessage { get; set; }
        public string RawXml { get; set; }

        /// <summary>
        /// Returns the effective value for a property, falling back to inherited docs if needed.
        /// </summary>
        public T GetEffective<T>(Func<MemberDocumentation, T> selector, HashSet<MemberInfo> visited = null)
        {
            visited ??= new HashSet<MemberInfo>();

            // Break circular inheritance
            if (!visited.Add(Member))
                return default;

            var value = selector(this);

            // ObsoleteMessage should never inherit
            if (selector == (Func<MemberDocumentation, T>)(d => (T)(object)d.ObsoleteMessage))
                return value;

            if (IsEmpty(value))
            {
                // Explicit <inheritdoc cref="...">
                if (InheritsFrom != null)
                {
                    var inherited = InheritsFrom.GetDocumentation();
                    if (inherited != null)
                        return inherited.GetEffective(selector, visited);
                }

                // Implicit base/interface inheritance
                if (ImplicitlyInheritsFrom != null)
                {
                    var implicitDoc = ImplicitlyInheritsFrom.GetDocumentation();
                    if (implicitDoc != null)
                        return implicitDoc.GetEffective(selector, visited);
                }
            }

            return value;
        }

        /// <summary>
        /// Utility to decide whether a value should be considered "empty".
        /// </summary>
        private static bool IsEmpty<T>(T value)
        {
            if (value == null) return true;

            if (value is string s) return string.IsNullOrWhiteSpace(s);
            if (value is ICollection coll) return coll.Count == 0;

            return false;
        }
    }

}

#region AutoStaticsCleanupAttribute

//These two attributes were introduced in 6.5, and are required (via import warnings).
//Our min version is 6.0, so we need to define dummy ones in earlier versions, unless we want hundreds of version defines everywhere.

#if !UNITY_6000_5_OR_NEWER

namespace Unity.Scripting.LifecycleManagement
{

    [System.AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Event | System.AttributeTargets.Field | System.AttributeTargets.Property | System.AttributeTargets.Struct, AllowMultiple = false)]
    internal sealed class NoAutoStaticsCleanupAttribute : System.Attribute
    { }

    [System.AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Event | System.AttributeTargets.Field | System.AttributeTargets.Property | System.AttributeTargets.Struct, AllowMultiple = true)]
    internal sealed class AutoStaticsCleanupAttribute : System.Attribute
    { }

}

#endif

#endregion

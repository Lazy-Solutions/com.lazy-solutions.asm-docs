#region AutoStaticsCleanupAttribute

//These two attributes were introduced in 6.5, and are required (via import warnings).
//Our min version is 6.0, so we need to define dummy ones in earlier versions, unless we want hundreds of version defines everywhere.

#if !UNITY_6000_5_OR_NEWER
namespace Unity.Scripting.LifecycleManagement
{

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Event | AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Struct, AllowMultiple = false)]
    internal sealed class NoAutoStaticsCleanupAttribute : Attribute
    { }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Event | AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Struct, AllowMultiple = true)]
    internal sealed class AutoStaticsCleanupAttribute : Attribute
    { }

}
#endif

#endregion
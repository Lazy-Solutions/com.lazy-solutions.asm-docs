#if ASM
using AdvancedSceneManager.Documentation;

[assembly: Include("Packages/" + Package.packageName + "/**/*.md")]

namespace AdvancedSceneManager.Documentation
{

    public static class Package
    {
        public const string packageName = "com.lazy-solutions.asm-docs";
        public static string folder { get; } = $"Packages/{packageName}";
        public static string apiFolder { get; } = $"Packages/{packageName}/API";
        public static string readMePath { get; } = $"Packages/{packageName}/readme.asset";
    }

}
#endif
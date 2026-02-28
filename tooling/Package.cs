#if CSPROJ_ATTRIBUTES
using AdvancedSceneManager.CsProjAttributes;
using AdvancedSceneManager.Documentation;
[assembly: Include("Packages/" + Package.packageName + "/**/*.md")]
#endif

namespace AdvancedSceneManager.Documentation
{

    public static class Package
    {
        public const string repoUrl = "https://github.com/Lazy-Solutions/com.lazy-solutions.asm-docs";
        public const string packageName = "com.lazy-solutions.asm-docs";
        public static string folder { get; } = $"Packages/{packageName}";
        public static string apiFolder { get; } = $"Packages/{packageName}/api";
        public static string guidesFolder { get; } = $"Packages/{packageName}/guides";
        public static string readMePath { get; } = $"Packages/{packageName}/readme.asset";
    }

}

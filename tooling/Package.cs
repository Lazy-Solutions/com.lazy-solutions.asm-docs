namespace AdvancedSceneManager.Documentation
{

    public static class Package
    {
        public const string packageName = "com.lazy-solutions.asm-docs";
        public static string repoUrl { get; } = $"https://github.com/Lazy-Solutions/{packageName}";
        public static string folder { get; } = $"Packages/{packageName}";
        public static string apiFolder { get; } = $"Packages/{packageName}/api";
        public static string guidesFolder { get; } = $"Packages/{packageName}/guides";
        public static string readMePath { get; } = $"Packages/{packageName}/readme.asset";
    }

}

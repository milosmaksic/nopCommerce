namespace Nop.Core
{
    public static class Extensions
    {
        public static string ToOsPath(this string path)
        {
            if (System.Runtime.InteropServices.RuntimeInformation.OSDescription.Contains("Linux"))
            {
                path = path.Replace(@"\", "/");
            }

            return path;
        }
    }
}
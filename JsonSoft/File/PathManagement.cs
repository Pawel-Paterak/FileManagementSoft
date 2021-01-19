using System.IO;

namespace FMSoft.File
{
    public class PathManagement
    {
        public static string GetDirectoryFromPath(string path)
            => Path.GetDirectoryName(path);
    }
}

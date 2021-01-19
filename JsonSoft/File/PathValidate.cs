using System.IO;

namespace FMSoft.File
{
    public class PathValidate
    {
        public static bool CheckFileExtension(string file, string extension)
            => Path.GetExtension(file) == extension;

        public static bool ExistsFileExtension(string file)
            => Path.HasExtension(file);

        public static bool HasPathToDirectory(string path)
            => path[path.Length - 1]  == '/' || path[path.Length - 1] == '\\';
    }
}

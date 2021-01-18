using System.IO;
using io = System.IO;

namespace FMSoft.File
{
    public static class FileValidate
    {
        public static bool ExistsDirectory(string path)
            => Directory.Exists(path);

        public static bool ExistsFile(string path)
            => io.File.Exists(path);

        public static bool CheckFileExtension(string file, string extension)
            => Path.GetExtension(file) == extension;
    }
}

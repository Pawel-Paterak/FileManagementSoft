using System.IO;

namespace JsonSoft
{
    public static class FileValidate
    {
        public static bool ExistsDirectory(string path)
            => Directory.Exists(path);

        public static bool ExistsFile(string path)
            => File.Exists(path);

        public static string CheckFileExtension(string file, string extension)
           => Path.ChangeExtension(file, extension);
    }
}

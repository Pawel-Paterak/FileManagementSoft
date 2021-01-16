using System.IO;

namespace JsonSoft
{
    public static class FileValidate
    {
        public static bool ExistsDirectory(string path)
            => Directory.Exists(path);

        public static bool ExistsFile(string path)
            => File.Exists(path);

        public static bool CheckFileExtension(string file, string extension)
            => Path.GetExtension(file) == extension;

        public static bool ChangeFileExtension(ref string file, string extension)
        {
            if (!CheckFileExtension(file, extension))
            {
                file = Path.ChangeExtension(file, extension);
                return true;
            }
            return false;
        }
    }
}

using System.IO;

namespace FMSoft.File
{
    public class FileManagement
    {
        public bool ChangeFileExtension(ref string file, string extension)
        {
            if (!PathValidate.CheckFileExtension(file, extension))
            {
                file = Path.ChangeExtension(file, extension);
                return true;
            }
            return false;
        }

        public string ReadText(string path)
            => FileValidate.ExistsFile(path) ? System.IO.File.ReadAllText(path) : null;
    }
}

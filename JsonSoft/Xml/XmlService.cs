using FMSoft.Xml.Reader;
using FMSoft.Xml.Writer;
using FMSoft.File;

namespace FMSoft.Xml
{
    public class XmlService
    {
        private readonly XmlReader xmlReader = new XmlReader();
        private readonly XmlWriter xmlWriter = new XmlWriter();
        private readonly FileManagement fileManagement = new FileManagement();

        public void Serialize<T>(T obj, string path) where T : class
        {
            string directory = PathManagement.GetDirectoryFromPath(path);
            if (FileValidate.ExistsDirectory(directory))
            {
                fileManagement.ChangeFileExtension(ref path, PathExtension.Xml);
                xmlWriter.Serialize(obj, path);
            }
        }

        public T Deserialize<T>(string path) where T : class
        {
            string directory = PathManagement.GetDirectoryFromPath(path);
            if (FileValidate.ExistsDirectory(directory))
            {
                fileManagement.ChangeFileExtension(ref path, PathExtension.Xml);
                return xmlReader.Deserialize<T>(path);
            }
            return null;
        }
    }
}

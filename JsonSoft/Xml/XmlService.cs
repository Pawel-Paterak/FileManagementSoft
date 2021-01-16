using JsonSoft.Xml.Reader;
using JsonSoft.Xml.Writer;

namespace JsonSoft.Xml
{
    public class XmlService
    {
        private readonly XmlReader xmlReader = new XmlReader();
        private readonly XmlWriter xmlWriter = new XmlWriter();
        private const string extensionXml = ".Xml";

        public void Serialize<T>(T obj, string path) where T : class
        {
            if(FileValidate.ExistsFile(path))
            {
                FileValidate.ChangeFileExtension(ref path, extensionXml);
                xmlWriter.Serializer(obj, path);
            }
        }

        public T Deserialize<T>(string path) where T : class
        {
            if (FileValidate.ExistsFile(path))
            {
                FileValidate.ChangeFileExtension(ref path, extensionXml);
                return xmlReader.Deserialize<T>(path);
            }
            return null;
        }
    }
}

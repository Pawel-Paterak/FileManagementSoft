using System.IO;
using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;

namespace JsonSoft.Xml.Writer
{
    public class XmlWriter
    {
        public void Serializer<T>(T obj, string path)
        {
            using (StreamWriter sW = new StreamWriter(path))
            {
                IExtendedXmlSerializer serializer = new ConfigurationContainer().Create();
                serializer.Serialize(sW, obj);
            }
        }
    }
}

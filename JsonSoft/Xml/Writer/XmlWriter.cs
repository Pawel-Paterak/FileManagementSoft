using System.IO;
using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;

namespace FMSoft.Xml.Writer
{
    public class XmlWriter
    {
        public void Serialize<T>(T obj, string path)
        {
            using (StreamWriter sW = new StreamWriter(path))
            {
                IExtendedXmlSerializer serializer = new ConfigurationContainer().Create();
                serializer.Serialize(sW, obj);
            }
        }

        public string SerializeToData<T>(T obj) where T : class
            => new ConfigurationContainer().Create().Serialize(obj);
    }
}

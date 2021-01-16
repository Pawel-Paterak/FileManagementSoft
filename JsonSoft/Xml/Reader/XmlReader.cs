using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
using System.IO;

namespace JsonSoft.Xml.Reader
{
    public class XmlReader
    {
        public T Deserialize<T>(string path) where T : class
        {
            T temp = null;
            
            using (StreamReader sR = new StreamReader(path))
            {
                IExtendedXmlSerializer serializer = new ConfigurationContainer().Create();
                temp = serializer.Deserialize<T>(sR);
            }
            return temp;
        }
    }
}

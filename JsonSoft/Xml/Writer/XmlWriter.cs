using System.IO;
using System.Xml.Serialization;

namespace FMSoft.Xml.Writer
{
    public class XmlWriter
    {
        public void Serialize<T>(T obj, string path) where T : class
        {
            using (StreamWriter sW = new StreamWriter(path))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(sW, obj);
            }
        }

        public string SerializeToData<T>(T obj) where T : class
        {
            using (StringWriter sW = new StringWriter())
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(sW, obj);
                return sW.ToString();
            }
            
        }
    }
}

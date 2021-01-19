using System.IO;
using System.Xml.Serialization;

namespace FMSoft.Xml.Reader
{
    public class XmlReader
    {
        public T Deserialize<T>(string path) where T : class
        {
            T temp = null;
            using (StreamReader sR = new StreamReader(path))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                temp = serializer.Deserialize(sR) as T;
            }
            return temp;
        }

        public T DeserializeFromData<T>(string data) where T : class
        {
            T temp = null;
            using (StringReader sR = new StringReader(data))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                temp = serializer.Deserialize(sR) as T;
            }
            return temp;
        }
    }
}

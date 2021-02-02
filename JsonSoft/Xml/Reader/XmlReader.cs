using YAXLib;

namespace FMSoft.Xml.Reader
{
    public class XmlReader
    {
        public T Deserialize<T>(string path) where T : class
            => new YAXSerializer(typeof(T)).DeserializeFromFile(path) as T;

        public T DeserializeFromData<T>(string data) where T : class
            => new YAXSerializer(typeof(T)).Deserialize(data) as T;
    }
}

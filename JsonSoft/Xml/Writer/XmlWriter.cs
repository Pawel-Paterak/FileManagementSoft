using System.IO;
using System.Xml.Serialization;
using YAXLib;

namespace FMSoft.Xml.Writer
{
    public class XmlWriter
    {
        public void Serialize<T>(T obj, string path) where T : class
            => new YAXSerializer(typeof(T)).SerializeToFile(obj, path);

        public string SerializeToData<T>(T obj) where T : class
            => new YAXSerializer(typeof(T)).Serialize(obj);
    }
}

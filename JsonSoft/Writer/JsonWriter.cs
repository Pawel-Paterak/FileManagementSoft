using Newtonsoft.Json;
using System.IO;

namespace JsonSoft.Writer
{
    public class JsonWriter
    {
        public void Serialize<T>(T obj, string path) where T : class
        {
            using (StreamWriter sW = new StreamWriter(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(sW, obj);
            }
        }
    }
}

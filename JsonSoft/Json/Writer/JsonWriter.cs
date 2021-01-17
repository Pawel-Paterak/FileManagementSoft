using Newtonsoft.Json;
using System.IO;

namespace JsonSoft.Json.Writer
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

        public string SerializeToData<T>(T obj) where T : class
           => JsonConvert.SerializeObject(obj);
    }
}

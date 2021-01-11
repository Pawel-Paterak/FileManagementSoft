using Newtonsoft.Json;
using System.IO;

namespace JsonSoft.Reader
{
    public class JsonReader
    {
        public T Deserialize<T>(string path) where T : class
        {
            T temp = default;
            using (StreamReader sR = new StreamReader(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                temp = serializer.Deserialize(sR, typeof(T)) as T;
            }
            return temp;
        }
    }
}

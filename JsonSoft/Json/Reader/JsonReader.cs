using Newtonsoft.Json;
using System.IO;

namespace FMSoft.Json.Reader
{
    public class JsonReader
    {
        public T Deserialize<T>(string path) where T : class
        {
            T temp = null;
            using (StreamReader sR = new StreamReader(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                temp = serializer.Deserialize(sR, typeof(T)) as T;
            }
            return temp;
        }

        public T DeserializeFromData<T>(string data) where T : class
            => JsonConvert.DeserializeObject<T>(data);
    }
}

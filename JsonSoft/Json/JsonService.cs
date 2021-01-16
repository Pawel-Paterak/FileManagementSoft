using JsonSoft.Json.Reader;
using JsonSoft.Json.Writer;

namespace JsonSoft.Json
{
    public class JsonService
    {
        private readonly JsonWriter jsonWriter = new JsonWriter();
        private readonly JsonReader jsonReader = new JsonReader();
        private const string exenstionJson = ".Json";

        public void Serialize<T>(T obj, string path) where T : class
        {
            if (FileValidate.ExistsFile(path))
            {
                FileValidate.ChangeFileExtension(ref path, exenstionJson);
                jsonWriter.Serialize(obj, path);
            }
        }

        public T Deserialize<T>(string path) where T : class
        {
            if (FileValidate.ExistsFile(path))
            {
                FileValidate.ChangeFileExtension(ref path, exenstionJson);
                return jsonReader.Deserialize<T>(path);
            }
            return null;
        }
    }
}

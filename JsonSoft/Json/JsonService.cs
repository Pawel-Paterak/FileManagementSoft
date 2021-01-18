using FMSoft.Json.Reader;
using FMSoft.Json.Writer;
using FMSoft.File;

namespace FMSoft.Json
{
    public class JsonService
    {
        private readonly JsonWriter jsonWriter = new JsonWriter();
        private readonly JsonReader jsonReader = new JsonReader();
        private readonly FileManagement fileManagement = new FileManagement();

        public void Serialize<T>(T obj, string path) where T : class
        {
            if (FileValidate.ExistsFile(path))
            {
                fileManagement.ChangeFileExtension(ref path, PathExtension.Json);
                jsonWriter.Serialize(obj, path);
            }
        }

        public T Deserialize<T>(string path) where T : class
        {
            if (FileValidate.ExistsFile(path))
            {
                fileManagement.ChangeFileExtension(ref path, PathExtension.Json);
                return jsonReader.Deserialize<T>(path);
            }
            return null;
        }
    }
}

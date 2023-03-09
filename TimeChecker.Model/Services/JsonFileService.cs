using Newtonsoft.Json;
using System.IO;

namespace TimeChecker.Model.Services
{
    public class JsonFileService : IFileService
    {
        private JsonSerializerSettings jsonSerializerSettings;

        public JsonFileService()
        {
            jsonSerializerSettings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto,
                TypeNameAssemblyFormatHandling = TypeNameAssemblyFormatHandling.Simple,
                Formatting = Formatting.Indented,
                Culture = System.Globalization.CultureInfo.GetCultureInfo("ru-RU")
            };
        }

        public T Open<T>(string filename)
        {
            filename = Path.ChangeExtension(filename, "json");

            if (!File.Exists(filename))
                return default(T);

            var jsonString = File.ReadAllText(filename);
            return JsonConvert.DeserializeObject<T>(jsonString, jsonSerializerSettings);
        }

        public void Save<T>(string filename, T list)
        {
            filename = Path.ChangeExtension(filename, "json");

            var jsonString = JsonConvert.SerializeObject(list, jsonSerializerSettings);
            File.WriteAllText(filename, jsonString);
        }
    }
}

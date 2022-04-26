using System.Globalization;
using System.IO;
using Newtonsoft.Json;
using Tasks.Utils;

namespace Logic.Utils
{
    public static class JsonHelper
    {
        public static string Serialize<T>(T obj, bool writeIndented)
        {
            var settings = new JsonSerializerSettings()
            {
                Formatting = writeIndented
                    ? Formatting.Indented
                    : Formatting.None,
                Culture = CultureInfo.CurrentCulture,
            };

            return JsonConvert.SerializeObject(obj, settings);
        }

        public static T DeserializeFromFile<T>(string path)
        {
            Preconditions.RequireNonEmptyString(path);
            if (!File.Exists(path))
            {
                throw new FileNotFoundException("File not found");
            }

            using (var sr = new StreamReader(path))
            {
                return JsonConvert.DeserializeObject<T>(sr.ReadToEnd());
            }
        }
    }
}
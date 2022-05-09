using Newtonsoft.Json;
using System.Globalization;
using System.IO;

namespace Logic.Utils
{
    public static class JsonHelper<T> where T : new()
    {
        public static string Serialize(T obj, bool writeIndented)
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

        public static T DeserializeFromFile(string path)
        {
            Preconditions.RequireNonEmptyString(path);
            if (!File.Exists(path))
            {
                return new T();
            }

            using (var sr = new StreamReader(path))
            {
                return JsonConvert.DeserializeObject<T>(sr.ReadToEnd());
            }
        }
    }
}
using Newtonsoft.Json;
using System;
using System.Globalization;
using System.IO;
using ToDoApp.Tasks;
using ToDoApp.Utils;

namespace ToDoApp.Repositories
{
    public class DiaryFileRepository : IRepository<Diary>
    {
        private readonly string _filePath;

        public DiaryFileRepository(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                throw new ArgumentNullException(nameof(filePath), "File path cannot be null");
            }

            _filePath = filePath;
        }


        public void Save(Diary obj)
        {
            Save(obj, true);
        }

        public void Save(Diary obj, bool writeIndented)
        {
            Preconditions.RequireNonNull(obj);
            var settings = new JsonSerializerSettings()
            {
                Formatting = writeIndented
                    ? Formatting.Indented
                    : Formatting.None,
                Culture = CultureInfo.CurrentCulture,
            };

            var json = JsonConvert.SerializeObject(obj, settings);
            File.WriteAllText(_filePath, json);
        }

        public Diary Read()
        {
            Preconditions.RequireNonEmptyString(_filePath);
            if (!File.Exists(_filePath))
            {
                return new Diary();
            }

            var json = File.ReadAllText(_filePath);
            return JsonConvert.DeserializeObject<Diary>(json);
        }
    }
}
using Logic.Utils;
using System;
using System.IO;
using Tasks;

namespace Logic.Repositories
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
            if (obj is null)
            {
                throw new ArgumentNullException(nameof(obj));
            }

            var json = JsonHelper<Diary>.Serialize(obj, writeIndented);
            using (var sw = new StreamWriter(_filePath))
            {
                sw.WriteLine(json);
            }
        }

        public Diary Read()
        {
            return JsonHelper<Diary>.DeserializeFromFile(_filePath);
        }
    }
}
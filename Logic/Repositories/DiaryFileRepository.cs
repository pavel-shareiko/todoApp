using System;
using System.IO;
using Logic.Utils;
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
            var json = JsonHelper.Serialize(obj, false);
            using (var sw = new StreamWriter(_filePath))
            {
                sw.WriteLine(json);
            }
        }

        public Diary Read()
        {
            return JsonHelper.DeserializeFromFile<Diary>(_filePath);
        }
    }
}
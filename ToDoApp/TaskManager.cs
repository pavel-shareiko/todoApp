using Logic.Repositories;
using Logic.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using Tasks;

namespace ToDoApp
{
    public static class TaskManager
    {
        public static Diary Diary { get; private set; }
        public static IEnumerable<Task> Tasks => Diary.Tasks;

        static TaskManager()
        {
            Load();
        }

        public static void Load()
        {
            var repository = new DiaryFileRepository(Properties.Settings.Default.DiarySaveFileName);
            Diary = repository.Read();
        }

        public static void Save()
        {
            var repository = new DiaryFileRepository(Properties.Settings.Default.DiarySaveFileName);
            repository.Save(Diary);
        }

        public static async System.Threading.Tasks.Task<List<Task>> GetTasksAsync(int offset, int count)
        {
            var tasks = Tasks.ToList();
            
            if (tasks.Count < offset || tasks.Count == 0)
            {
                return new List<Task>();
            }

            return await System.Threading.Tasks.Task.Run(() =>
            {
                if (tasks.Count < offset + count)
                {
                    return tasks.GetRange(offset, tasks.Count - offset);
                }

                return Tasks
                .Skip(offset)
                .Take(count).ToList();
            });
        }

        public static int GetTasksCount()
        {
            return Tasks.Count();
        }

        public static bool RemoveTask(Task task)
        {
            return Diary.RemoveTask(task);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using ToDoApp.Repositories;

namespace ToDoApp.Tasks
{
    public static class TaskManager
    {
        public static Diary Diary { get; private set; }
        public static IEnumerable<Task> Tasks => Diary.Tasks;
        private static readonly IRepository<Diary> repository;

        static TaskManager()
        {
            repository = new DiaryFileRepository(Properties.Settings.Default.DiarySaveFileName);
            Load();
        }

        public static void Load()
        {
            Diary = repository.Read();
        }

        public static void Save()
        {
            repository.Save(Diary);
        }

        public static async System.Threading.Tasks.Task<List<Task>> GetTasksAsync(int offset, int count, IComparer<Task> comparer = null, Func<Task, bool> selector = null)
        {
            var tasks = Tasks.ToList();

            if (tasks.Count < offset || tasks.Count == 0)
            {
                return new List<Task>();
            }

            return await System.Threading.Tasks.Task.Run(() =>
            {
                if (comparer != null)
                {
                    tasks.Sort(comparer);
                }

                if (selector != null)
                {
                    tasks = tasks.Where(selector).ToList();
                }

                if (tasks.Count < offset + count)
                {
                    return tasks.GetRange(offset, tasks.Count - offset);
                }

                return tasks.Skip(offset).Take(count).ToList();
            });
        }

        public static int GetTasksCount(Func<Task, bool> selector = null)
        {
            return selector == null
                ? Diary.Count
                : Tasks.Count(selector);
        }

        public static Task GetTaskById(Guid id)
        {
            return Diary.Tasks.FirstOrDefault(t => t.Id == id);
        }

        public static bool RemoveTask(Task task)
        {
            return Diary.RemoveTask(task);
        }
    }
}

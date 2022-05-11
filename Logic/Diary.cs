using Logic.Tasks;
using Logic.Utils;
using System.Collections.Generic;
using System.Linq;

namespace Tasks
{

    public class Diary
    {
        private readonly List<Task> _tasks;

        public IEnumerable<Task> Tasks => _tasks.AsEnumerable();
        public int Count => _tasks.Count;

        public Diary()
        {
            _tasks = new List<Task>();
        }

        public void AddTask(Task task)
        {
            Preconditions.RequireNonNull(task);
            _tasks.Add(task);
        }

        public bool RemoveTask(Task task)
        {
            Preconditions.RequireNonNull(task);
            return _tasks.Remove(task);
        }
    }
}
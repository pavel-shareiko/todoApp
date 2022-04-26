using System.Collections.Generic;
using System.Linq;
using Tasks.Tasks;
using Tasks.Utils;

namespace Tasks
{

    public class Diary
    {
        private readonly List<Task> _tasks;

        public IEnumerable<Task> Tasks => _tasks.AsEnumerable();

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
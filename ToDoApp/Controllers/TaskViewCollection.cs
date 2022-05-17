using Logic.Tasks;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using ToDoApp.Controls;
using ToDoApp.UI;
using ToDoApp.UI.Controls;

namespace ToDoApp.Controllers
{
    public class TaskViewCollection : IEnumerable<TaskView>
    {
        public event EventHandler<CollectionUpdatedEventArgs> CollectionUpdated;

        private readonly List<TaskView> _taskViews = new List<TaskView>();

        public TaskViewCollection(ICollection<Task> tasks, TaskController controller)
        {
            foreach (var task in tasks)
            {
                var taskView = CreateTaskViewForTask(task, controller);
                _taskViews.Add(taskView);
            }
        }

        public void Add(TaskView task)
        {
            _taskViews.Add(task);
            CollectionUpdated?.Invoke(this, new CollectionUpdatedEventArgs(task));
        }

        public bool Remove(TaskView task)
        {
            var result = _taskViews.Remove(task);
            if (result)
            {
                CollectionUpdated?.Invoke(this, new CollectionUpdatedEventArgs(task));
            }
            return result;
        }

        private TaskView CreateTaskViewForTask(Task task, TaskController controller)
        {
            return new TaskView(task, controller)
            {
                BackColor = ApplicationStyle.BackgroundColor,
                ForeColor = ApplicationStyle.TextColor,
                Dock = DockStyle.Top
            };
        }

        public IEnumerator<TaskView> GetEnumerator()
        {
            return _taskViews.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class CollectionUpdatedEventArgs : EventArgs
    {
        public TaskView TaskView { get; }

        public CollectionUpdatedEventArgs(TaskView taskView)
        {
            TaskView = taskView;
        }
    }
}

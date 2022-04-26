using System;

namespace Tasks.Tasks
{

    public class Task
    {
        private TaskImportance _importance;

        public string Description { get; set; }
        public Guid Id { get; }

        public TaskImportance Importance
        {
            get => _importance;
            set
            {
                if (!Enum.IsDefined(typeof(TaskImportance), value))
                {
                    throw new ArgumentException($"{value} is not a valid task importance");
                }

                _importance = value;
            }
        }

        public Task()
        {
            Importance = TaskImportance.Default;
            Id = Guid.NewGuid();
        }
    }
}
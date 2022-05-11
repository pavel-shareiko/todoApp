using System;
using System.ComponentModel.DataAnnotations;

namespace Logic.Tasks
{
    public class Task
    {
        private TaskImportance _importance = TaskImportance.Low;

        [Required]
        [MaxLength(128)]
        public string Name { get; set; }
        public string Description { get; set; }

        [Required]
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
        public DateTime? DeadLine { get; set; }

        public DateTime CreationDate { get; set; }

        public Task()
        {
            CreationDate = DateTime.Now;
        }

        public Task(Task task)
        {
            if (task == null)
            {
                throw new ArgumentNullException(nameof(task));
            }

            Name = task.Name;
            Description = task.Description;
            Importance = task.Importance;
            DeadLine = task.DeadLine;
            CreationDate = task.CreationDate;
        }

        public void CopyTo(Task task)
        {
            if (task == null)
            {
                task = new Task(this);
                return;
            }

            task.Name = Name;
            task.Description = Description;
            task.Importance = Importance;
            task.DeadLine = DeadLine;
            task.CreationDate = CreationDate;
        }
    }
}
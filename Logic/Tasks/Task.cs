using Logic.Attributes;
using System;
using System.ComponentModel.DataAnnotations;

namespace Logic.Tasks
{
    public class Task
    {
        private TaskImportance _importance = TaskImportance.Low;
        private bool isCompleted;
        private string name;
        private string description;
        private DateTime? deadLine;
        private DateTime creationDate;
        private DateTime? completionDate;

        public event EventHandler<StateChangedEventArgs> StateChanged;

        [Order, Required, MaxLength(128)]
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                var oldValue = name;
                name = value;
                OnStateChanged(new StateChangedEventArgs(StatusUpdate.CompletionStatusChanged, oldValue, value));
            }
        }

        [Order]
        public string Description
        {
            get { return description; }
            set
            {
                var oldValue = description;
                description = value;
                OnStateChanged(new StateChangedEventArgs(StatusUpdate.DescriptionChanged, oldValue, value));
            }
        }

        [Order, Required]
        public TaskImportance Importance
        {
            get => _importance;
            set
            {
                if (!Enum.IsDefined(typeof(TaskImportance), value))
                {
                    throw new ArgumentException($"{value} is not a valid task importance");
                }

                var oldValue = _importance;
                _importance = value;
                OnStateChanged(new StateChangedEventArgs(StatusUpdate.ImportanceChanged, oldValue, value));
            }
        }

        [Order]
        public DateTime? DeadLine
        {
            get { return deadLine; }
            set
            {
                var oldValue = deadLine;
                deadLine = value;
                OnStateChanged(new StateChangedEventArgs(StatusUpdate.DeadLineChanged, oldValue, value));
            }
        }

        [Order]
        public DateTime CreationDate
        {
            get { return creationDate; }
            set
            {
                var oldValue = creationDate;
                creationDate = value;
                OnStateChanged(new StateChangedEventArgs(StatusUpdate.CreationDateChanged, oldValue, value));
            }
        }

        [Order]
        public bool IsCompleted
        {
            get => isCompleted;
            set
            {
                var oldValue = isCompleted;
                isCompleted = value;
                OnStateChanged(new StateChangedEventArgs(StatusUpdate.CompletionStatusChanged, oldValue, value));
            }
        }

        [Order]
        [DependsOn("IsCompleted")]
        public DateTime? CompletionDate
        {
            get { return completionDate; }
            set
            {
                var oldValue = completionDate;
                completionDate = value;
                OnStateChanged(new StateChangedEventArgs(StatusUpdate.CompletionDateChanged, oldValue, value));
            }
        }

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

        public void CopyTo(ref Task task)
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

        public void Complete()
        {
            IsCompleted = true;
            CompletionDate = DateTime.Now;
        }

        public void Uncomplete()
        {
            IsCompleted = false;
            CompletionDate = null;
        }

        public override string ToString()
        {
            return $"{Name}, DeadLine: {DeadLine}, Importance: {Importance}, IsCompleted: {IsCompleted}";
        }

        protected virtual void OnStateChanged(StateChangedEventArgs e)
        {
            StateChanged?.Invoke(this, e);
        }
    }
}
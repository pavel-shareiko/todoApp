using System.Collections.Generic;

namespace ToDoApp.Tasks
{
    public class TaskComparer : IComparer<Task>
    {
        public int Compare(Task x, Task y)
        {
            if (x.IsCompleted && !y.IsCompleted)
            {
                return 1;
            }

            if (!x.IsCompleted && y.IsCompleted)
            {
                return -1;
            }

            if (x.DeadLine.HasValue && !y.DeadLine.HasValue)
            {
                return -1;
            }

            if (!x.DeadLine.HasValue && y.DeadLine.HasValue)
            {
                return 1;
            }

            if (!x.DeadLine.HasValue && !y.DeadLine.HasValue)
            {
                goto importanceComparison;
            }

            if (x.DeadLine.Value.Date != y.DeadLine.Value.Date)
            {
                return x.DeadLine.Value.Date.CompareTo(y.DeadLine.Value.Date);
            }

        importanceComparison:

            if (x.Importance != y.Importance)
            {
                return y.Importance.CompareTo(x.Importance);
            }

            return x.CreationDate.CompareTo(y.CreationDate);
        }
    }
}
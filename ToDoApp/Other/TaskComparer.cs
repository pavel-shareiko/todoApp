using System.Collections.Generic;

namespace ToDoApp.Controls
{
    public class TaskComparer : IComparer<Logic.Tasks.Task>
    {
        public int Compare(Logic.Tasks.Task x, Logic.Tasks.Task y)
        {
            // The comparison should be reversed because the list is sorted in descending order
            // The most important factor is the deadline, then comes the importance, and then the creation date
            // Completed tasks have the lowest priority

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
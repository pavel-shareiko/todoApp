using System;
using Tasks.Tasks;

namespace Tasks
{
    public class ScheduledTask : Task
    {
        public DateTime DeadLine { get; set; }


        public void Schedule(DateTime deadline)
        {
            DeadLine = deadline;
        }

        public void MoveDeadLine(DateTime newDeadLine)
        {
            DeadLine = newDeadLine;
        }
    }
}
namespace Logic.Services
{
    // The class that should iterate over every task periodically.
    // and notify the user if the deadline of the task is approaching.
    // Scan period and notification period are configurable.
    public class NotificationService
    {
        private static NotificationService _instance;
        public static NotificationService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new NotificationService();
                }
                return _instance;
            }
        }

        // Start method invokes a timer that will periodically call the method CheckDeadlines.
        public void Start()
        {
            
        }
    }
}

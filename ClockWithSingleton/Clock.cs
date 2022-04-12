
namespace ClockWithSingleton;

public class Clock
{
    private Clock() { }

        private static Clock? _instance;
        private static readonly object _lock = new();

        public static Clock GetTime()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                    _instance = new Clock
                    {
                        localDate = DateTime.Now
                    };
                }
                }
            }
            return _instance;
        }

        public DateTime localDate { get; set; }
}



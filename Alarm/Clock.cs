namespace Alarm
{
    class Clock
    {
        public event EventHandler<string> TimeEvent;
        public void StartClock(int time)
        {
            for (int i = time; i > 0; i--)
            {
                TimeEvent?.Invoke(this, $"Time left {i}");
                Thread.Sleep(1000);
                Console.Clear();
            }
            TimeEvent?.Invoke(this, "Time is over");

        }
    }
}

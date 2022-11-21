namespace Alarm
{
    class Subscriber
    {
        public void Timer(Clock clock)
        {
            clock.TimeEvent += TimeIsOver;
        }

        private void TimeIsOver(object? sender, string e)
        {
            Console.WriteLine(e);
        }
    }
}

using Alarm;

var subs1 = new Subscriber();
var clock = new Clock();
subs1.Timer(clock);
clock.StartClock(10);

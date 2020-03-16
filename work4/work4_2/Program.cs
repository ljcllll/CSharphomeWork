using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace work4_2
{
    public delegate void AlarmHandler(int timeTick);
    public delegate void TickHandler(int timeTick);

    class ClockEvent
    {
        public event AlarmHandler onAlarm;
        public event TickHandler onTick;
        public void Tick(int timeTick) { onTick(timeTick); }
        public void Alarm(int timeTick) { onAlarm(timeTick); }
    }

    class AlarmClock
    {
        public ClockEvent clock = new ClockEvent();
        //private int timeTick;
        public int timeTick { set; get; }
        public AlarmClock()
        {
            timeTick = 0;
            clock.onTick += new TickHandler(TickEvent);
            clock.onAlarm += new AlarmHandler(AlarmEvent);
        }

        public void TickEvent(int timeTick)
        {
            Console.WriteLine("Tick at time" + timeTick);
        }
        public void AlarmEvent(int timeTick)
        {
            Console.WriteLine("Alarm at time" + timeTick);
        }
        public void Tick()
        {
            clock.Tick(timeTick);
        }
        public void Alarm(){
            clock.Alarm(timeTick);

    }

    class Program
    {
        static void Main(string[] args)
        {
                AlarmClock alarmClock = new AlarmClock();
                alarmClock.timeTick
        }
    }
}

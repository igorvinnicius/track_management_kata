using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace track_management.ClassicalStyle.Entities
{
    public class Event
    {
	    public TimeSpan StartAt { get; private set; }
	    public TimeSpan FinishAt { get; private set; }

	    public int Duration { get; private set; }

	    public Event(TimeSpan startTime, TimeSpan finishTime)
	    {
			SetStartTime(startTime);
			SetFinishTime(finishTime);
	    }

	    public void SetStartTime(TimeSpan startTime)
	    {
		    StartAt = startTime;
	    }

	    public void SetFinishTime(TimeSpan finishTime)
	    {
		    FinishAt = finishTime;
	    }

	    public void SetDuration(int duration)
	    {
		    this.Duration = duration;
	    }
    }
}

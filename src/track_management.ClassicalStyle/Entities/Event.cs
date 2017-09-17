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

	    public Event(TimeSpan startTime)
	    {
			SetStartTime(startTime);
	    }

	    public void SetStartTime(TimeSpan startTime)
	    {
		    StartAt = startTime;
	    }
    }
}

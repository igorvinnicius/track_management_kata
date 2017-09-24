using System;
using System.Collections.Generic;

namespace track_management.ClassicalStyle.Entities
{
    public class Track
    {
	   
	    public Session MorningSession { get; private set; }

	    public Session AfternoonSession { get; private set; }

		public Track()
	    {
		    MorningSession = new Session(new TimeSpan(9,0,0), new TimeSpan(12,0,0));
		    AfternoonSession = new Session(new TimeSpan(13, 0, 0), new TimeSpan(17, 0, 0));
		}

	    public void SetMorningSession(Session _morningSession)
	    {
		    MorningSession = _morningSession;
	    }

	    public void SetAfternoonSession(Session _afternoonSession)
	    {
		    AfternoonSession = _afternoonSession;
	    }

	    public void AddTalk(Talk talk)
	    {
			MorningSession.AddTalk(talk);
	    }


    }
}

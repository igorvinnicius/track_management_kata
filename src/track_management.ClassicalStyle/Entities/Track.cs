using System;
using System.Collections.Generic;
using System.Linq;

namespace track_management.ClassicalStyle.Entities
{
    public class Track
    {
	   
	    public Session MorningSession { get; private set; }

	    public Session AfternoonSession { get; private set; }
	    public int TotalTime { get; private set; }
	    public int TotalTalks { get; private set; }

	    private readonly IList<Event> _events;
	    public IEnumerable<Event> Events => _events;

		public Track()
	    {
		    MorningSession = new Session(new TimeSpan(9,0,0), new TimeSpan(12,0,0));
		    AfternoonSession = new Session(new TimeSpan(13, 0, 0), new TimeSpan(17, 0, 0));

			_events = new List<Event>();
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
			if(MorningSession.HasAvailableTime() && !TalkAlreadyExists(talk))
				MorningSession.AddTalk(talk);

			if(AfternoonSession.HasAvailableTime() && !TalkAlreadyExists(talk))
				AfternoonSession.AddTalk(talk);

			CalculateTotalTime();
			CalculateTotalTalks();
	    }

	    private void CalculateTotalTime()
	    {
		    this.TotalTime = this.MorningSession.CauculateTalksTime() + this.AfternoonSession.CauculateTalksTime() + Events.Sum(e => e.Duration);
	    }

	    private bool TalkAlreadyExists(Talk talk)
	    {
		    var inMorningSession = MorningSession.Talks.Any(t => t.Name.Contains(talk.Name));
		    var inAfternoonSession = AfternoonSession.Talks.Any(t => t.Name.Contains(talk.Name));

		    return inMorningSession || inAfternoonSession;

	    }

	    private void CalculateTotalTalks()
	    {
		    this.TotalTalks = MorningSession.Talks.Count() + AfternoonSession.Talks.Count();
	    }

	    public void AddEvent(Event newEvent)
	    {
			_events.Add(newEvent);

			CalculateTotalTime();
	    }

    }
}

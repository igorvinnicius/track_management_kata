using System;
using System.Collections.Generic;
using System.Linq;

namespace track_management.ClassicalStyle.Entities
{
    public class Track
    {
	   
	    public Session MorningSession { get; private set; }

	    public Session AfternoonSession { get; private set; }
	    public TimeSpan TotalTime { get; private set; }
	    public int TotalTalks { get; private set; }

	    private readonly IList<Event> _events;
	    public IEnumerable<Event> Events => _events;

		public Track()
	    {
		    MorningSession = new Session(new TimeSpan(9,0,0), new TimeSpan(12,0,0));
		    AfternoonSession = new Session(new TimeSpan(13, 0, 0), new TimeSpan(17, 0, 0));

			_events = new List<Event>();

			CalculateTotalTime();
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
		    if (CanAddTalkToMorningSesion(talk))
				AddTalkToMorningSession(talk);

		    if(AfternoonSession.HasAvailableTime() && !TalkAlreadyExists(talk))
			    AddTalkToAfternoonSession(talk);

			CalculateTotalTime();
			CalculateTotalTalks();
		    CalculateRemainingTime();
	    }

	    private bool CanAddTalkToMorningSesion(Talk talk)
	    {
		    return MorningSession.HasAvailableTime() && !TalkAlreadyExists(talk);

	    }

	    private void AddTalkToMorningSession(Talk talk)
	    {
		    var startAt = MorningSession.Talks.Any() ? MorningSession.Talks.Last().FinishAt : MorningSession.StartAt;

		    talk.SetStartTime(startAt);
		    var timeToBeAdded = new TimeSpan(0, talk.Duration, 0);
			talk.SetFinishTime(talk.StartAt.Add(timeToBeAdded));
		    MorningSession.AddTalk(talk);
		}

	    private void AddTalkToAfternoonSession(Talk talk)
	    {
		    var startAt = AfternoonSession.Talks.Any() ? AfternoonSession.Talks.Last().FinishAt : AfternoonSession.StartAt;

		    talk.SetStartTime(startAt);
		    var timeToBeAdded = new TimeSpan(0, talk.Duration, 0);
		    talk.SetFinishTime(talk.StartAt.Add(timeToBeAdded));
		    AfternoonSession.AddTalk(talk);
	    }

		private void CalculateTotalTime()
	    {
		    var timeSum = MorningSession.TotalTime.Add(AfternoonSession.TotalTime);

		    this.TotalTime = MorningSession.TotalTime.Add(AfternoonSession.TotalTime);
	    }

	    public TimeSpan CalculateRemainingTime()
	    {
			var timeSum = new TimeSpan(0, MorningSession.CauculateTalksTime(),0).Add(new TimeSpan(0, AfternoonSession.CauculateTalksTime(), 0));

		    timeSum.Add(new TimeSpan(0, Events.Sum(e => e.Duration), 0));

		    return this.TotalTime.Subtract(timeSum);
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
		    if (!EventAlreadyExists(newEvent))
		    {
			    _events.Add(newEvent);
			    CalculateTotalTime();
		    }
	    }

	    private bool EventAlreadyExists(Event newEvent)
	    {
		    return Events.Any(e => e.Name.Contains(newEvent.Name));
	    }

    }
}

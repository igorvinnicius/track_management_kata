using System;
using System.Collections.Generic;
using System.Linq;

namespace track_management.ClassicalStyle.Entities
{
	public class Session
	{
		private readonly IList<Talk> _talks;
		public IEnumerable<Talk> Talks => _talks;

		public TimeSpan StartAt { get; private set; }
		public TimeSpan FinishAt { get; private set; }
		public TimeSpan TotalTime { get; private set; }

		public Session(TimeSpan startTime, TimeSpan finishTime)
		{
			_talks = new List<Talk>();

			SetStartTime(startTime);
			SetFinishTime(finishTime);
			CalculateTotalTime();
		}

		public void SetStartTime(TimeSpan startTime)
		{
			StartAt = startTime;
		}

		public void SetFinishTime(TimeSpan finishTime)
		{
			FinishAt = finishTime;
		}

		private void CalculateTotalTime()
		{
			TotalTime = FinishAt.Subtract(StartAt);
		}

		public TimeSpan CalculateTimeRemaining()
		{
			return TotalTime.Subtract(new TimeSpan(0, CauculateTalksTime(), 0));
		}

		public int CauculateTalksTime()
		{
			return _talks.Sum(t => t.Duration);
		}

		public bool HasAvailableTime()
		{
			return CalculateTimeRemaining().TotalMinutes > 0;
		}

		private bool CanAddTalk(int duration)
		{
		  return CalculateTimeRemaining().TotalMinutes - duration > 0;
		}

		public void AddTalk(Talk talk)
		{
			if(CanAddTalk(talk.Duration))
			_talks.Add(talk);
		}
	}
}
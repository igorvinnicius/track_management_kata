using System;
using System.Collections.Generic;

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


		public void AddTalk(Talk talk)
		{
			_talks.Add(talk);
		}
	}
}
using System;

namespace track_management.ClassicalStyle.Entities
{
	public class Session
	{
		public TimeSpan StartAt { get; private set; }
		public TimeSpan FinishAt { get; private set; }
		public TimeSpan TotalTime { get; private set; }

		public Session(TimeSpan startTime, TimeSpan finishTime)
		{
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


	}
}
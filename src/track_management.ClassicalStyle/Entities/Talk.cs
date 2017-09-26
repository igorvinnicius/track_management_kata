namespace track_management.ClassicalStyle.Entities
{
	public class Talk
	{
		public string Name { get; set; }

		public int Duration { get; private set; }

		public void SetDuration(int duration)
		{
			this.Duration = duration;
		}

	}
}
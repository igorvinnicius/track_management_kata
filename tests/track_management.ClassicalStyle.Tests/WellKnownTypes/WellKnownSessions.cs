using System;
using System.Collections.Generic;
using System.Text;

namespace track_management.ClassicalStyle.Tests.WellKnownTypes
{
    public static class WellKnownSessions
    {
	    public static MorningSession MorningSession()
	    {
			return new MorningSession();
	    }
    }


	public class MorningSession : WellKnownSession
	{
		public override TimeSpan StartAt => new TimeSpan(9,0,0);
		public override TimeSpan FinishAt => new TimeSpan(12, 0, 0);
	}



}

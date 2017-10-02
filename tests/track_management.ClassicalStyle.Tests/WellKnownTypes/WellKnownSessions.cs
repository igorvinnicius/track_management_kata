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

	    public static AfternoonSession AfternoonSession()
	    {
		    return new AfternoonSession();
	    }


	}


	public class MorningSession : WellKnownSession
	{
		public override TimeSpan StartAt => new TimeSpan(8,0,0);
		public override TimeSpan FinishAt => new TimeSpan(12, 0, 0);
	}

	public class AfternoonSession : WellKnownSession
	{
		public override TimeSpan StartAt => new TimeSpan(13, 0, 0);
		public override TimeSpan FinishAt => new TimeSpan(17, 0, 0);
	}



}

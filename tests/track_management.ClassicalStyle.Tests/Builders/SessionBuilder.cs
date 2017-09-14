using System;
using System.Collections.Generic;
using System.Text;
using track_management.ClassicalStyle.Entities;
using track_management.ClassicalStyle.Tests.WellKnownTypes;

namespace track_management.ClassicalStyle.Tests.Builders
{
    public class SessionBuilder
    {

	    public TimeSpan DefaultStartAt { get; private set; }
	    public TimeSpan DefaultFinishAt { get; private set; }

		public SessionBuilder WithStartAt(TimeSpan startAt)
		{
			this.DefaultStartAt = startAt;
			return this;
		}

	    public SessionBuilder WithFinishAt(TimeSpan finishAt)
	    {
		    this.DefaultFinishAt = finishAt;
		    return this;
	    }

	    public SessionBuilder ForWellKnownSession(WellKnownSession wellKnownSession)
	    {
		    WithStartAt(wellKnownSession.StartAt);
		    WithFinishAt(wellKnownSession.FinishAt);

		    return this;
	    }


	    public Session Build()
	    {
			var session = new Session(DefaultStartAt, DefaultFinishAt);

		    return session;
	    }

    }
}

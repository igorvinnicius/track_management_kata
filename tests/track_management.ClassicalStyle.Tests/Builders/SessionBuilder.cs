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

	    private TimeSpan _startAt;
	    private TimeSpan _finishAt;

	    public SessionBuilder()
	    {
		    WithStartAt(DefaultStartAt);
		    WithFinishAt(DefaultFinishAt);
	    }

		public SessionBuilder WithStartAt(TimeSpan startAt)
		{
			this._startAt = startAt;
			return this;
		}

	    public SessionBuilder WithFinishAt(TimeSpan finishAt)
	    {
		    this._finishAt = finishAt;
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
			var session = new Session(_startAt, _finishAt);

		    return session;
	    }

    }
}

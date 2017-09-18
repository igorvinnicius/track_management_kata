using System;
using System.Collections.Generic;
using System.Text;
using track_management.ClassicalStyle.Entities;

namespace track_management.ClassicalStyle.Tests.Builders
{
    public class EventBuilder
    {
	    public TimeSpan DefaultStartAt  => new TimeSpan(12, 0, 0);
	    public TimeSpan DefaultFinishAt => new TimeSpan(12, 59, 0);

	    private TimeSpan _startAt;
	    private TimeSpan _finishAt;

	    public EventBuilder()
	    {
		    WithStartAt(DefaultStartAt);
		    WithFinishAt(DefaultFinishAt);
	    }

	    public EventBuilder WithStartAt(TimeSpan startAt)
	    {
		    this._startAt = startAt;
		    return this;
	    }

	    public EventBuilder WithFinishAt(TimeSpan finishAt)
	    {
		    this._finishAt = finishAt;
		    return this;
	    }

	    public Event Build()
	    {
		    var session = new Event(_startAt, _finishAt);

		    return session;
	    }

	}
}

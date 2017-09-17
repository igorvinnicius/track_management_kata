using System;
using System.Collections.Generic;
using System.Text;
using track_management.ClassicalStyle.Entities;

namespace track_management.ClassicalStyle.Tests.Builders
{
    public class EventBuilder
    {
	    public TimeSpan DefaultStartAt { get; private set; }
	    public TimeSpan DefaultFinishAt { get; private set; }

	    public EventBuilder WithStartAt(TimeSpan startAt)
	    {
		    this.DefaultStartAt = startAt;
		    return this;
	    }

	    public EventBuilder WithFinishAt(TimeSpan finishAt)
	    {
		    this.DefaultFinishAt = finishAt;
		    return this;
	    }

	   


	    public Event Build()
	    {
		    var session = new Event(DefaultStartAt, DefaultFinishAt);

		    return session;
	    }

	}
}

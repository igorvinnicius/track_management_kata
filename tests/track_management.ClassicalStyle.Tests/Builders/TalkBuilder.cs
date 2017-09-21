using System;
using System.Collections.Generic;
using System.Text;
using track_management.ClassicalStyle.Entities;

namespace track_management.ClassicalStyle.Tests.Builders
{
    public class TalkBuilder
    {

	    public int DefaultDuration => 30;

	    private int _duration;

	    public TalkBuilder()
	    {
		    _duration = DefaultDuration;
	    }


	    public TalkBuilder WithDuration(int duration)
	    {
		    this._duration = duration;
		    return this;

	    }

	    public Talk Build()
	    {
			var talk = new Talk();
		    talk.SetDuration(_duration);


		    return talk;
	    }

    }
}

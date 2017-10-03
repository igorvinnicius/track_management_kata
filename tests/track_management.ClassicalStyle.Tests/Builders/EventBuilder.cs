using System;
using System.Collections.Generic;
using System.Text;
using track_management.ClassicalStyle.Entities;

namespace track_management.ClassicalStyle.Tests.Builders
{
    public class EventBuilder
    {
	    public string DefaultName => "Coffee Break";
	    public TimeSpan DefaultStartAt  => new TimeSpan(12, 0, 0);
	    public TimeSpan DefaultFinishAt => new TimeSpan(12, 59, 0);
	    public int DefaultDuration => 60;

	    private string _name;
	    private TimeSpan _startAt;
	    private TimeSpan _finishAt;
	    private int _duration;

	    public EventBuilder()
	    {
		    WithName(DefaultName);
		    WithStartAt(DefaultStartAt);
		    WithFinishAt(DefaultFinishAt);
		    WithDuration(DefaultDuration);
	    }

	    public EventBuilder WithName(string name)
	    {
		    this._name = name;
		    return this;
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

	    public EventBuilder WithDuration(int duration)
	    {
		    this._duration = duration;
		    return this;
	    }
		
		public Event Build()
	    {
		    var newEvent = new Event(_startAt, _finishAt);

		    newEvent.Name = _name;
			newEvent.SetDuration(_duration);

		    return newEvent;
	    }

	}
}

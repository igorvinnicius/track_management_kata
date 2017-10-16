using System;
using System.Collections.Generic;
using System.Text;
using track_management.ClassicalStyle.Entities;
using track_management.ClassicalStyle.Tests.WellKnownTypes;

namespace track_management.ClassicalStyle.Tests.Builders
{
    public class TalkBuilder
    {

	    public string DefaultName => "Talk 1";
		public int DefaultDuration => 30;
	    public TimeSpan DefaultStartAt => new TimeSpan(9,0,0);
	    public TimeSpan DefaultFinishAt => new TimeSpan(10, 0, 0);

		private string _name;
		private int _duration;

	    private TimeSpan _startAt;
	    private TimeSpan _finishAt;

		public TalkBuilder()
	    {
		    _name = DefaultName;
		    _duration = DefaultDuration;
	    }


	    public TalkBuilder WithName(string name)
	    {
		    this._name = name;
		    return this;

	    }

		public TalkBuilder WithDuration(int duration)
	    {
		    this._duration = duration;
		    return this;

	    }

	    public TalkBuilder WithStartAt(TimeSpan startAt)
	    {
		    this._startAt = startAt;
		    return this;

	    }

	    public TalkBuilder WithFinishAt(TimeSpan startAt)
	    {
		    this._finishAt = startAt;
		    return this;
	    }

		public TalkBuilder ForWellKnownTalk(WellKnownTalk wellKnownTalk)
	    {
		    WithName(wellKnownTalk.Name);
		    WithDuration(wellKnownTalk.Duration);

			return this;

	    }

		public Talk Build()
	    {
			var talk = new Talk();
		    talk.Name = _name;
		    talk.SetDuration(_duration);
			talk.SetStartTime(_startAt);
			talk.SetFinishTime(_finishAt);


		    return talk;
	    }

    }
}

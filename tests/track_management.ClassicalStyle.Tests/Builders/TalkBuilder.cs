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

	    private string _name;
		private int _duration;

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


		    return talk;
	    }

    }
}

using System;
using System.Collections.Generic;
using System.Text;
using track_management.ClassicalStyle.Entities;
using track_management.ClassicalStyle.Tests.WellKnownTypes;

namespace track_management.ClassicalStyle.Tests.Builders
{
    public class TrackBuilder
    {

		public Session DefaultMorningSession => new SessionBuilder().ForWellKnownSession(WellKnownSessions.MorningSession()).Build();
	    public Session DefaultAfternoonSession => new SessionBuilder().ForWellKnownSession(WellKnownSessions.AfternoonSession()).Build();

	    private Session _morningSession;
	    private Session _afternoonSession;

		public TrackBuilder()
		{
			this._morningSession = DefaultMorningSession;
			this._afternoonSession = DefaultAfternoonSession;
		}

	    public TrackBuilder WithMorningSession(SessionBuilder sessionBuilder)
	    {
		    this._morningSession = sessionBuilder.Build();
		    return this;
	    }

	    public TrackBuilder WithAfternoonSession(SessionBuilder sessionBuilder)
	    {
		    this._afternoonSession = sessionBuilder.Build();
		    return this;
	    }

	    public Track Build()
	    {
			var track = new Track();

			track.SetMorningSession(_morningSession);
			track.SetAfternoonSession(_afternoonSession);

		    return track;

	    }

    }
}

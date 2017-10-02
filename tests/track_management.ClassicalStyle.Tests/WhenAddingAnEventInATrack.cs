using System;
using System.Collections.Generic;
using System.Text;
using track_management.ClassicalStyle.Tests.Builders;
using track_management.ClassicalStyle.Tests.WellKnownTypes;
using Xunit;

namespace track_management.ClassicalStyle.Tests
{
    public class WhenAddingAnEventInATrack
    {

	    [Fact]
	    public void ShouldDecreaseTrackRemainingTime()
	    {
		    var track = new TrackBuilder()
			    .WithMorningSession(new SessionBuilder().ForWellKnownSession(WellKnownSessions.MorningSession()))
			    .WithAfternoonSession(new SessionBuilder().ForWellKnownSession(WellKnownSessions.AfternoonSession()))
			    .Build();

		    var breakFast = new EventBuilder().Build();

		    var trackRemainingTimeBeforeEvent = track.CalculateRemainingTime();

		    track.AddEvent(breakFast);

			Assert.True(trackRemainingTimeBeforeEvent < track.CalculateRemainingTime());

	    }

    }
}

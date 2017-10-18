using System;
using System.Collections.Generic;
using System.Linq;
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

	    [Fact]
	    public void ShouldNotBeAddedIfAlreadyExists()
	    {
		    var track = new TrackBuilder()
			    .WithMorningSession(new SessionBuilder().ForWellKnownSession(WellKnownSessions.MorningSession()))
			    .WithAfternoonSession(new SessionBuilder().ForWellKnownSession(WellKnownSessions.AfternoonSession()))
			    .Build();

		    var breakFast = new EventBuilder().Build();

		    track.AddEvent(breakFast);

		    track.AddEvent(breakFast);

		    Assert.Equal(track.Events.Count(), 1);

		}

	    [Fact]
	    public void EventShouldNotBeAddedIfItMatchATalk()
	    {
		    var track = new TrackBuilder()
			    .WithMorningSession(new SessionBuilder().ForWellKnownSession(WellKnownSessions.MorningSession()))
			    .WithAfternoonSession(new SessionBuilder().ForWellKnownSession(WellKnownSessions.AfternoonSession()))
			    .Build();

		    var talkBuilder = new TalkBuilder();

		    var talk = talkBuilder
			    .WithStartAt(new TimeSpan(12, 0, 0))
			    .WithFinishAt(new TimeSpan(12, 59, 0))
			    .Build();

		    track.AddTalk(talk);


			var newEvent = new EventBuilder()
				.WithStartAt(new TimeSpan(8,0,0))
				.WithFinishAt(new TimeSpan(12,0,0))
				.Build();

		    track.AddEvent(newEvent);

		    Assert.Equal(0, track.Events.Count());

	    }

	}
}

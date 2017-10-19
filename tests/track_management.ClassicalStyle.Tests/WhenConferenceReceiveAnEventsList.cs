using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using track_management.ClassicalStyle.Entities;
using track_management.ClassicalStyle.Tests.Builders;
using Xunit;

namespace track_management.ClassicalStyle.Tests
{
    public class WhenConferenceReceiveAnEventsList
    {
	    [Fact]
	    public void ShouldScheduleEventsCorrectly()
	    {
		    var conference = new ConferenceBuilder().Build();

			var events = new List<Event>();

			var eventBuilder = new EventBuilder();

		    var newEvent = eventBuilder
			    .WithFinishAt(new TimeSpan(12, 0, 0))
			    .WithFinishAt(new TimeSpan(12, 59, 00))
			    .Build();

			events.Add(newEvent);

		    conference.AutomaticScheduleEvents(events);

		    Assert.True(conference.Tracks.Any());

	    }

	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using track_management.ClassicalStyle.Entities;
using track_management.ClassicalStyle.Tests.Builders;
using track_management.ClassicalStyle.Tests.WellKnownTypes;
using Xunit;

namespace track_management.ClassicalStyle.Tests
{
    public class WhenConferenceRecieveATalksList
    {

	    [Fact]
	    public void ShouldScheduleTalksCorrectly()
	    {
		    var conference = new ConferenceBuilder().Build();
			

		    conference.AutomaticScheduleTalks(GetTalks().ToList());

			Assert.True(conference.Tracks.Any());

	    }

	    private IEnumerable<Talk> GetTalks()
	    {
		    var talks = WellKnownTalks.ReturnAllWellKnownTalks();
		    var talksBuilder = new TalkBuilder();

		    foreach (var talk in talks)
			    yield return talksBuilder.ForWellKnownTalk(talk).Build();
	    }

    }
}

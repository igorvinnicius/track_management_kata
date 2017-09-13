using System.Linq;
using track_management.ClassicalStyle.Entities;
using Xunit;

namespace track_management.ClassicalStyle.Tests
{
    public class WhenTheConferenceIsCreated
    {
	    [Fact]
	    public void TracksCountShouldBeZero()
	    {
		    var conference = new Conference();

			Assert.Equal(0, conference.Tracks.Count());
	    }

    }
}

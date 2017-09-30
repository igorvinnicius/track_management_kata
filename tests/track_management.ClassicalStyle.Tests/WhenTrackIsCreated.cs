using System.Linq;
using track_management.ClassicalStyle.Entities;
using Xunit;

namespace track_management.ClassicalStyle.Tests
{
    public class WhenTrackIsCreated
    {
	    [Fact]
	    public void ShouldHaveAMorningSession()
	    {
		    var track = new Track();

		    Assert.NotNull(track.MorningSession);
	    }

	    [Fact]
	    public void ShouldHaveAAfternoonSession()
	    {
		    var track = new Track();

		    Assert.NotNull(track.AfternoonSession);
	    }

	    [Fact]
	    public void ShouldNotHaveAddedEvents()
	    {
			var track = new Track();

			Assert.Equal(track.Events.Count(), 0);
	    }

    }
}

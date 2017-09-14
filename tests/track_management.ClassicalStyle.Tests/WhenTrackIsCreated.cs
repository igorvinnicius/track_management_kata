using System.Linq;
using track_management.ClassicalStyle.Entities;
using Xunit;

namespace track_management.ClassicalStyle.Tests
{
    public class WhenTrackIsCreated
    {
	    [Fact]
	    public void TalksCountShouldBeZero()
	    {
		    var track = new Track();

			Assert.Equal(0, track.Talks.Count());

	    }

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

	}
}

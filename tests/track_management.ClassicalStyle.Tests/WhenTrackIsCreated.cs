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

    }
}

using System;
using track_management.ClassicalStyle.Entities;
using Xunit;


namespace track_management.ClassicalStyle.Tests
{
    public class WhenAnEventIsCreated
    {

	    [Fact]
	    public void ShouldStartAtASetTime()
	    {
		    var expectedStart = new TimeSpan(13, 0, 0);
		    var expectedFinish = new TimeSpan(17, 0, 0);

			var someEvent = new Event(expectedStart, expectedFinish);

		    Assert.Equal(expectedStart, someEvent.StartAt);
		}

	    [Fact]
	    public void ShouldFinishAtASetTime()
	    {
		    var expectedStart = new TimeSpan(13, 0, 0);
			var expectedFinish = new TimeSpan(17, 0, 0);

		    var someEvent = new Event(expectedStart, expectedFinish);

		    Assert.Equal(expectedFinish, someEvent.FinishAt);
	    }


	}
}

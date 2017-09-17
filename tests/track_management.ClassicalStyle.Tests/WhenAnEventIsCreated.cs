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

			var someEvent = new Event(expectedStart);

		    Assert.Equal(expectedStart, someEvent.StartAt);
		}


    }
}

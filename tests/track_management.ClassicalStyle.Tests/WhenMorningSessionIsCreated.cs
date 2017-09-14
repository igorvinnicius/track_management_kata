using System;
using System.Collections.Generic;
using System.Text;
using track_management.ClassicalStyle.Entities;
using Xunit;

namespace track_management.ClassicalStyle.Tests
{
    public class WhenMorningSessionIsCreated
    {
	    [Fact]
	    public void ShouldStartAtASetTime()
	    {
		    var expectedStart = new TimeSpan(9, 0, 0);

			var morningSession = new Session(expectedStart, new TimeSpan(12,0,0));

			Assert.Equal(expectedStart, morningSession.StartAt);
	    }

	    [Fact]
	    public void ShouldFinishAtASetTime()
	    {
			var expectedStart = new TimeSpan(9,0,0);
		    var expectedFinish = new TimeSpan(12,0,0);

			var morningSession = new Session(expectedStart, expectedFinish);

			Assert.Equal(expectedFinish, morningSession.FinishAt);

	    }
    }
}

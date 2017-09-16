using System;
using System.Collections.Generic;
using System.Text;
using track_management.ClassicalStyle.Entities;
using track_management.ClassicalStyle.Tests.Builders;
using track_management.ClassicalStyle.Tests.WellKnownTypes;
using Xunit;

namespace track_management.ClassicalStyle.Tests
{
    public class WhenMorningSessionIsCreated
    {
	    [Fact]
	    public void ShouldStartAtASetTime()
	    {
		    var sessionBuilder = new SessionBuilder();
		    var morningSession = sessionBuilder.ForWellKnownSession(WellKnownSessions.MorningSession()).Build();

		    var expectedStart = new TimeSpan(9, 0, 0);

			Assert.Equal(expectedStart, morningSession.StartAt);
	    }

	    [Fact]
	    public void ShouldFinishAtASetTime()
	    {

		    var sessionBuilder = new SessionBuilder();
		    var morningSession = sessionBuilder.ForWellKnownSession(WellKnownSessions.MorningSession()).Build();
			
		    var expectedFinish = new TimeSpan(12,0,0);

			Assert.Equal(expectedFinish, morningSession.FinishAt);

	    }


	    [Fact]
	    public void ShouldHaveATotalOfTheDifferenceBetweenFinishAtAndStartAt()
	    {
			var startAt = new TimeSpan(9,0,0);
		    var finishAt = new TimeSpan(12, 0, 0);

		    var expectedTotalOfTime = finishAt.Subtract(startAt);

			var sessionBuilder = new SessionBuilder();

		    var morningSession = sessionBuilder
				.WithStartAt(startAt)
				.WithFinishAt(finishAt)
				.Build();

			Assert.Equal(expectedTotalOfTime, morningSession.TotalTime);


	    }
    }
}

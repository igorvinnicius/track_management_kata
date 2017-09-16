using System;
using track_management.ClassicalStyle.Tests.Builders;
using track_management.ClassicalStyle.Tests.WellKnownTypes;
using Xunit;

namespace track_management.ClassicalStyle.Tests
{
    public class WhenAfternoonSessionIsCreated
    {

	    [Fact]
	    public void ShouldStartAtASetTime()
	    {
		    var sessionBuilder = new SessionBuilder();
		    var afternoonSession = sessionBuilder.ForWellKnownSession(WellKnownSessions.AfternoonSession()).Build();

		    var expectedStart = new TimeSpan(13, 0, 0);

		    Assert.Equal(expectedStart, afternoonSession.StartAt);
	    }

	    [Fact]
	    public void ShouldFinishAtASetTime()
	    {

		    var sessionBuilder = new SessionBuilder();
		    var afternoonSession = sessionBuilder.ForWellKnownSession(WellKnownSessions.AfternoonSession()).Build();

		    var expectedFinish = new TimeSpan(17, 0, 0);

		    Assert.Equal(expectedFinish, afternoonSession.FinishAt);

	    }
	}
}

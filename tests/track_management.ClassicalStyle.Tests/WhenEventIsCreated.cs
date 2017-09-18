using System;
using track_management.ClassicalStyle.Entities;
using track_management.ClassicalStyle.Tests.Builders;
using Xunit;


namespace track_management.ClassicalStyle.Tests
{
    public class WhenEventIsCreated
    {

	    [Fact]
	    public void ShouldStartAtASetTime()
	    {
		    var expectedStart = new TimeSpan(13, 0, 0);

		    var eventBuilder = new EventBuilder();

		    var someEvent = eventBuilder
			    .WithStartAt(expectedStart)

			    .Build();

		    Assert.Equal(expectedStart, someEvent.StartAt);
		}

	    [Fact]
	    public void ShouldFinishAtASetTime()
	    {

			var expectedFinish = new TimeSpan(17, 0, 0);

			var eventBuilder = new EventBuilder();

		    var someEvent = eventBuilder
			    .WithFinishAt(expectedFinish)
			    .Build();


			Assert.Equal(expectedFinish, someEvent.FinishAt);
	    }


	}
}

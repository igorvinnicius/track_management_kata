using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using track_management.ClassicalStyle.Tests.Builders;
using Xunit;

namespace track_management.ClassicalStyle.Tests
{
    public class WhenAddingATalkInASession
    {
	    [Fact]
	    public void TalkShouldBeAddedIfSessionISEmpty()
	    {
			var sessionBuilder = new SessionBuilder();
			var session = sessionBuilder
				.WithStartAt(new TimeSpan(9, 0, 0))
				.WithFinishAt(new TimeSpan(12, 0, 0))
				.Build();

			var talkBuilder = new TalkBuilder();
		    var talk = talkBuilder.Build();

		    session.AddTalk(talk);

			Assert. True(session.Talks.Count() == 1);
	    }

	    [Fact]
	    public void TalkShouldBeAddedIfTheDurationIsLessThanTimeRemaningInSession()
	    {
			var sessionBuilder = new SessionBuilder();
		    var session = sessionBuilder
				.WithStartAt(new TimeSpan(9,0,0))
			    .WithFinishAt(new TimeSpan(12, 0, 0))
				.Build();

		    var talkBuilder = new TalkBuilder();
		    var talk = talkBuilder
				.WithDuration(30)
				.Build();


		    session.AddTalk(talk);

		    Assert.True(session.Talks.Count() == 1);

		}

	    [Fact]
	    public void TalkShouldNotBeAddedIfTheDurationIsGreaterThanTimeRemaningInSession()
	    {
		    var sessionBuilder = new SessionBuilder();
		    var session = sessionBuilder
			    .WithStartAt(new TimeSpan(11, 0, 0))
			    .WithFinishAt(new TimeSpan(12, 0, 0))
			    .Build();

		    var talkBuilder = new TalkBuilder();
		    var talk = talkBuilder
			    .WithDuration(60)
			    .Build();

		    session.AddTalk(talk);

		    Assert.True(!session.Talks.Any());

		}

	    [Fact]
	    public void TalkShouldDecreaseTheSessionRemainingTime()
	    {
		    var sessionBuilder = new SessionBuilder();
		    var session = sessionBuilder
			    .WithStartAt(new TimeSpan(9, 0, 0))
			    .WithFinishAt(new TimeSpan(12, 0, 0))
			    .Build();

		    var talkBuilder = new TalkBuilder();
		    var talk = talkBuilder
			    .WithDuration(60)
			    .Build();

			session.AddTalk(talk);

		    var expectedRemainingTime = session.TotalTime.TotalMinutes - talk.Duration;

			Assert.Equal(expectedRemainingTime, session.CalculateTimeRemaining().TotalMinutes);

	    }


    }
}

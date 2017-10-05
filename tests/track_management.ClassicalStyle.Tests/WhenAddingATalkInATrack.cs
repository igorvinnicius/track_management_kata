using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using track_management.ClassicalStyle.Entities;
using track_management.ClassicalStyle.Tests.Builders;
using track_management.ClassicalStyle.Tests.WellKnownTypes;
using Xunit;

namespace track_management.ClassicalStyle.Tests
{
    public class WhenAddingATalkInATrackcs
    {


	    [Fact]
	    public void TrackShouldAddTalkInMorningSessionWhenHaveAvailableTime()
	    {
		    var trackBuilder = new TrackBuilder();
		    var track = trackBuilder.Build();

		    var talkBuilder = new TalkBuilder();
		    var talk = talkBuilder
				.WithDuration(60)
				.Build();

			track.AddTalk(talk);

			Assert.True(track.MorningSession.Talks.Count() == 1);
	    }


		[Fact]
	    public void TrackShouldTryToAddTheTalkInTheAfternoonSessionIfMorningSessionHaveNoMoreTime()
	    {
			var sessionBuilder = new SessionBuilder()
								.WithStartAt(new TimeSpan(11,30,0))
								.WithFinishAt(new TimeSpan(12, 0, 0));

			var trackBuilder = new TrackBuilder();
			var track = trackBuilder.WithMorningSession(sessionBuilder).Build();
		    
			var talkBuilder = new TalkBuilder();
		    var talk = talkBuilder
			    .WithDuration(60)
			    .Build();

			track.AddTalk(talk);

		    Assert.True(track.AfternoonSession.Talks.Count() == 1);

		}

	    [Fact]
	    public void TrackRemainingTimeShouldBeSumOkTalksInMorningSessionAndAfternoonSession()
	    {
		    var track = new TrackBuilder()
			    .WithMorningSession(new SessionBuilder().ForWellKnownSession(WellKnownSessions.MorningSession()))
			    .WithAfternoonSession(new SessionBuilder().ForWellKnownSession(WellKnownSessions.AfternoonSession()))
			    .Build();

			var talkBuilder = new TalkBuilder();

		    var talks = new Talk[]
		    {
			    talkBuilder.ForWellKnownTalk(WellKnownTalks.WritingFastTestsAgainstEnterpriseRails()).Build(),
			    talkBuilder.ForWellKnownTalk(WellKnownTalks.OverdoingItInPython()).Build()
		    };

		    foreach (var talk in talks)
		    {
			   track.AddTalk(talk);
		    }

		    var expectedTotalTime = track.TotalTime.TotalMinutes - talks.Sum(t => t.Duration);

			Assert.Equal(expectedTotalTime, track.CalculateRemainingTime().TotalMinutes);

	    }

	    [Fact]
	    public void TrackShouldNotAddTalkIfItAlreadyExists()
	    {
		    var track = new TrackBuilder()
			    .WithMorningSession(new SessionBuilder().ForWellKnownSession(WellKnownSessions.MorningSession()))
			    .WithAfternoonSession(new SessionBuilder().ForWellKnownSession(WellKnownSessions.AfternoonSession()))
			    .Build();

		    var talk = new TalkBuilder().ForWellKnownTalk(WellKnownTalks.WritingFastTestsAgainstEnterpriseRails()).Build();

			track.AddTalk(talk);

			track.AddTalk(talk);

			Assert.Equal(track.TotalTalks, 1);

	    }

	    [Fact]
	    public void ShouldSetTalkStartAtEqualsMorningSessionStartAtIfFirstTalk()
	    {
		    var track = new TrackBuilder()
			    .WithMorningSession(new SessionBuilder().ForWellKnownSession(WellKnownSessions.MorningSession()))
			    .WithAfternoonSession(new SessionBuilder().ForWellKnownSession(WellKnownSessions.AfternoonSession()))
			    .Build();

		    var talk = new TalkBuilder().ForWellKnownTalk(WellKnownTalks.WritingFastTestsAgainstEnterpriseRails()).Build();

		    track.AddTalk(talk);

			Assert.Equal(talk.StartAt, track.MorningSession.StartAt);
		}

	    [Fact]
	    public void ShouldAdjustStartAtAndFinishAtInMorningSessionCorrectly()
	    {
		    var track = new TrackBuilder()
			    .WithMorningSession(new SessionBuilder().ForWellKnownSession(WellKnownSessions.MorningSession()))
			    .WithAfternoonSession(new SessionBuilder().ForWellKnownSession(WellKnownSessions.AfternoonSession()))
			    .Build();

		    var talkBuilder = new TalkBuilder();

		    var talks = new Talk[]
		    {
			    talkBuilder.ForWellKnownTalk(WellKnownTalks.WritingFastTestsAgainstEnterpriseRails()).Build(),
			    talkBuilder.ForWellKnownTalk(WellKnownTalks.OverdoingItInPython()).Build()
		    };

		    foreach (var talk in talks)
		    {
			    track.AddTalk(talk);
		    }
		   
			Assert.Equal(new TimeSpan(8, 0, 0), track.MorningSession.Talks[0].StartAt);
		    Assert.Equal(new TimeSpan(9, 0, 0), track.MorningSession.Talks[0].FinishAt);
		    Assert.Equal(new TimeSpan(9, 0, 0), track.MorningSession.Talks[1].StartAt);
		    Assert.Equal(new TimeSpan(9, 45, 0), track.MorningSession.Talks[1].FinishAt);
		}

	    [Fact]
	    public void ShouldAdjustStartAtAndFinishAtBetweenMorningSessionAndAfternoonSessionCorrectly()
	    {
		    var track = new TrackBuilder()
			    .WithMorningSession(new SessionBuilder().ForWellKnownSession(WellKnownSessions.MorningSession()))
			    .WithAfternoonSession(new SessionBuilder().ForWellKnownSession(WellKnownSessions.AfternoonSession()))
			    .Build();

		    var talkBuilder = new TalkBuilder();

		    var talks = new Talk[]
		    {
			    talkBuilder.ForWellKnownTalk(WellKnownTalks.WritingFastTestsAgainstEnterpriseRails()).Build(),
			    talkBuilder.ForWellKnownTalk(WellKnownTalks.OverdoingItInPython()).Build(),
			    talkBuilder.ForWellKnownTalk(WellKnownTalks.LuaForTheMasses()).Build(),
			    talkBuilder.ForWellKnownTalk(WellKnownTalks.RubyErrorsFromMismatchedGemVersions()).Build(),
			    talkBuilder.ForWellKnownTalk(WellKnownTalks.RubyOnRailsWhyWeShouldMoveOn()).Build(),
			    talkBuilder.ForWellKnownTalk(WellKnownTalks.CommonRubyErrors()).Build()

			};

		    foreach (var talk in talks)
		    {
			    track.AddTalk(talk);
		    }

		    Assert.Equal(new TimeSpan(8, 0, 0), track.MorningSession.Talks[0].StartAt);
		    Assert.Equal(new TimeSpan(9, 0, 0), track.MorningSession.Talks[0].FinishAt);

			Assert.Equal(new TimeSpan(9, 0, 0), track.MorningSession.Talks[1].StartAt);
		    Assert.Equal(new TimeSpan(9, 45, 0), track.MorningSession.Talks[1].FinishAt);

		    Assert.Equal(new TimeSpan(9, 45, 0), track.MorningSession.Talks[2].StartAt);
		    Assert.Equal(new TimeSpan(10, 15, 0), track.MorningSession.Talks[2].FinishAt);

		    Assert.Equal(new TimeSpan(10, 15, 0), track.MorningSession.Talks[3].StartAt);
		    Assert.Equal(new TimeSpan(11, 0, 0), track.MorningSession.Talks[3].FinishAt);

		    Assert.Equal(new TimeSpan(11, 0, 0), track.MorningSession.Talks[3].StartAt);
		    Assert.Equal(new TimeSpan(12, 0, 0), track.MorningSession.Talks[3].FinishAt);

		    Assert.Equal(new TimeSpan(13, 0, 0), track.MorningSession.Talks[3].StartAt);
		    Assert.Equal(new TimeSpan(13, 45, 0), track.MorningSession.Talks[3].FinishAt);
		}

	}
}

using System;
using System.Collections.Generic;
using System.Text;
using track_management.ClassicalStyle.Tests.Builders;
using Xunit;

namespace track_management.ClassicalStyle.Tests
{
    public class WhenAddingATalkInTheMorningSession
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



			
	    }


		[Fact]
	    public void TrackShouldTryToAddTheTalkInTheAfternoonSessionIfMorningSessionHaveNoMoreTime()
	    {
		    var trackBuilder = new TrackBuilder();
			var track = trackBuilder.Build();
		    
			var talkBuilder = new TalkBuilder();
			var talk = talkBuilder.Build();

	    }

    }
}

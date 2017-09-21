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
		    var session = sessionBuilder.Build();

			var talkBuilder = new TalkBuilder();
		    var talk = talkBuilder.Build();

		    session.AddTalk(talk);

			Assert. True(session.Talks.Count() == 1);
	    }
    }
}

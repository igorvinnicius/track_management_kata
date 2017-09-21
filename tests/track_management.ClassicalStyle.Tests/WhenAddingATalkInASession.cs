using System;
using System.Collections.Generic;
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

	    }
    }
}

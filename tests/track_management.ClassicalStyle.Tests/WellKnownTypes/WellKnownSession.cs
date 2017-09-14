using System;
using System.Collections.Generic;
using System.Text;

namespace track_management.ClassicalStyle.Tests.WellKnownTypes
{
    public abstract class WellKnownSession
    {
	    public abstract TimeSpan StartAt { get; }
	    public abstract TimeSpan FinishAt { get; }

	}
}

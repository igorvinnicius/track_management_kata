using System;
using System.Collections.Generic;

namespace track_management.ClassicalStyle.Entities
{
    public class Track
    {
	    private readonly IList<Talk> _talks;
	    public IEnumerable<Talk> Talks => _talks;

	    public Session MorningSession { get; private set; }

	    public Session AfternoonSession { get; private set; }

		public Track()
	    {
			_talks = new List<Talk>();

		    MorningSession = new Session();
		    AfternoonSession = new Session();
		}

	}
}

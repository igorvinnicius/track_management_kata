using System;
using System.Collections.Generic;
using System.Text;

namespace track_management.ClassicalStyle.Entities
{
    public class Track
    {
	    private readonly IList<Talk> _talks;

	    public IEnumerable<Talk> Talks => _talks;

	    public Track()
	    {
			_talks = new List<Talk>();
	    }
    }
}

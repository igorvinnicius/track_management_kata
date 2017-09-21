using System;
using System.Collections.Generic;
using System.Text;

namespace track_management.ClassicalStyle.Entities
{
    public class Conference
    {
	    private readonly IList<Track> _tracks;
	    public IEnumerable<Track> Tracks => _tracks;

	    public Conference()
	    {
			_tracks = new List<Track>();
			
	    }


	    public void InsertTrack(Track track)
	    {
			this._tracks.Add(track);
	    }


    }
}

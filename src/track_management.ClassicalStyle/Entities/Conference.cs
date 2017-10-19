using System;
using System.Collections.Generic;
using System.Linq;
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

	    public void AutomaticScheduleTalks(IList<Talk> talks)
	    {
		    foreach (var talk  in talks)
		    {
			    var track = Tracks.FirstOrDefault(t => t.CalculateRemainingTime().TotalMinutes >= talk.Duration);

				if(track != null)
					track.AddTalk(talk);
				else
				{
					var newTrack = new Track();
					newTrack.AddTalk(talk);

					_tracks.Add(newTrack);
				}

		    }

			

	    }

    }
}

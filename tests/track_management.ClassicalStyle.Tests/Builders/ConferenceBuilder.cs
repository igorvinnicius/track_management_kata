using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using track_management.ClassicalStyle.Entities;

namespace track_management.ClassicalStyle.Tests.Builders
{
    public class ConferenceBuilder
    {
		public IList<Track> Tracks => new List<Track>();

	    private IList<Track> _tracks;

	    public ConferenceBuilder()
	    {
			_tracks = new List<Track>();
	    }

	    public ConferenceBuilder WithTrack(TrackBuilder trackBuilder)
	    {
			this._tracks.Add(trackBuilder.Build());
		    return this;
	    }

	    public Conference Build()
	    {
			var conference = new Conference();

			InsertTracks(conference, _tracks);

		    return conference;

	    }

	    private void InsertTracks(Conference conference, IList<Track> tracks)
	    {
		    foreach (var track in tracks)
		    {
			    conference.InsertTrack(track);
		    }

	    }

    }
}

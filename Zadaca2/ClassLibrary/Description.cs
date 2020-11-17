using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Description
    {
        public int EpisodeNumber { get; private set; }
        public string EpisodeName { get; private set; }
        public TimeSpan EpisodeDuration { get; private set; }

        public Description(int episodeNumber,TimeSpan episodeDuration,string episodeName)
        {
            EpisodeNumber = episodeNumber;
            EpisodeDuration = episodeDuration;
            EpisodeName = episodeName;
        }
        public override string ToString()
        {
            return $"{EpisodeNumber},{EpisodeDuration},{EpisodeName}";
        }
    }
}

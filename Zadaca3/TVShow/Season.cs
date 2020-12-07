using System;
using System.Collections.Generic;
using System.Text;

namespace TVShow
{
    public class Season
    {

        public int SeasonNumber { get; private set; }
        public Episode[] Episodes { get; private set; }



        public Season(int seasonNumber, Episode[] episodes)
        {
            Episodes = episodes;
            SeasonNumber = seasonNumber;
        }

        public Episode this[int episodeIndex]
        {
            get { return Episodes[episodeIndex]; }
            set { Episodes[episodeIndex] = value; }
        }
        public int GetTotalViewers()
        {
            int viewerCount = 0;
            for(int i=0;i<Episodes.Length;i++)
            {
                viewerCount += Episodes[i].GetViewerCount();
            }
            return viewerCount;
        }
        public TimeSpan GetTotalDuration()
        {
            TimeSpan duration = new TimeSpan(0, 0, 0);
            foreach(var episode in Episodes)
            {
                duration += episode.GetDescription().EpisodeDuration;
            }
            return duration;
        }

        public int Length
        {
            get { return Episodes.Length; }
        }
        public override string ToString()
        {
            return $"Season {SeasonNumber}:\n{string.Join<Episode>(Environment.NewLine, Episodes)}\nTotal Viewers: {GetTotalViewers()}\nTotal Duration {GetTotalDuration()}";
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TVShow
{
    public class Season:IEnumerable<Episode>
    {

        public int SeasonNumber { get; private set; }
        public List<Episode> Episodes { get; private set; }



        public Season(int seasonNumber, List<Episode> episodes)
        {
            Episodes = episodes;
            SeasonNumber = seasonNumber;
        }

        public Season(Season other) // :(
        {
            SeasonNumber = other.SeasonNumber;
            Episodes = new List<Episode>();
            Episodes.AddRange(other.Episodes);
           
        }

        public Episode this[int episodeIndex]
        {
            get { return Episodes[episodeIndex]; }
            set { Episodes[episodeIndex] = value; }
        }
        public int GetTotalViewers()
        {
            int viewerCount = 0;
            foreach (var episode in Episodes)
            {
                viewerCount += episode.GetViewerCount();
            }
            return viewerCount;
        }
        public TimeSpan GetTotalDuration()
        {
            TimeSpan duration = new TimeSpan(0, 0, 0);
            foreach (var episode in Episodes)
            {
                duration += episode.GetDescription().EpisodeDuration;
            }
            return duration;
        }

        public int Length
        {
            get { return Episodes.Count; }
        }

       

        public void AddEpisode(Episode episode)
        {
            Episodes.Add(episode);

        }

        public void Remove(string episodeName)
        {
          int removableAt=-1;
          for(int i=0;i<Episodes.Count;i++)
            {
                if(Episodes[i].GetDescription().EpisodeName==episodeName)
                {
                    removableAt = i;
                    break;
                }
            }
          if(removableAt>=0)
            {
                Episodes.RemoveAt(removableAt);
            }
            else
            {
                throw new TvException(episodeName, $"Episode doesn't exist!");
            }

            
        }

        public override string ToString()
        {
            return $"Season {SeasonNumber}:\n{string.Join<Episode>(Environment.NewLine, Episodes)}\nTotal Viewers: {GetTotalViewers()}\nTotal Duration {GetTotalDuration()}";
        }

        public IEnumerator<Episode> GetEnumerator()
        {
            return Episodes.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() // ova je non-generic
        {
            return GetEnumerator(); 
        }
    }
}

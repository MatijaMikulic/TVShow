using System;

namespace TVShow
{
    public class Episode
    {
        private int viewerCount=0;
        private double maxScore;
        private double scoreSum;
        private Description description;

        public Episode(int viewers, double scoreSum, double maxScore, Description description)
        {
            viewerCount = viewers;
            this.maxScore = maxScore;
            this.scoreSum = scoreSum;
            this.description = description;
        }

        public Episode() : this(0, 0, 0, null) { }

        public void AddView(double maxScore)
        {
            this.maxScore = maxScore;
            scoreSum += this.maxScore;
            viewerCount++;
        }
        public double GetMaxScore()
        {
            return maxScore;
        }

        public double GetAverageScore()
        {
            return scoreSum / viewerCount;

        }

        public int GetViewerCount()
        {
            return viewerCount;
        }
        public Description GetDescription()
        {
            return description;
        }
        public override string ToString()
        {
            return $"{viewerCount},{scoreSum},{maxScore},{description.EpisodeNumber},{description.ToString()}";
        }

        public static bool operator >(Episode ep1, Episode ep2)
        {
            if (ep1.GetAverageScore() > ep2.GetAverageScore())
            {
                return true;
            }
            return false;
        }
        public static bool operator <(Episode ep1, Episode ep2)
        {
            return !(ep1 > ep2);
        }
    }
}

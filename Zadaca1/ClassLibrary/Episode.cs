using System;

namespace ClassLibrary
{
    public class Episode
    {

        private int viewerCount = 0;
        private double score;
        private double scoreSum;

        public Episode(int viewers, double score, double scoreSum)
        {
            viewerCount = viewers;
            this.score = score;
            this.scoreSum = scoreSum;

        }

        public Episode()
        {
            viewerCount = 0;
            score = 0;
            scoreSum = 0;
        }



        public void AddView(double score)
        {

            this.score = score;
            scoreSum += this.score;

            viewerCount++;

        }
        public double GetMaxScore()
        {
            return this.score;
        }

        public double GetAverageScore()
        {
            return scoreSum / viewerCount;

        }

        public int GetViewerCount()
        {
            return viewerCount;
        }
    }
}

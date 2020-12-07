using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TVShow
{
    public static class TvUtilities
    {
        private static Random generator = new Random();
        public static double GenerateRandomScore()
        {
            
            return generator.NextDouble() * 10;

        }
        public static Episode Parse(string episodeInput)
        {
            string[] elements = episodeInput.Split(",");
            return new Episode(int.Parse(elements[0]), double.Parse(elements[1]), double.Parse(elements[2]), new Description(int.Parse(elements[3]), TimeSpan.Parse(elements[4]), elements[5]));

        }

        public static void Sort(Episode[] episodes)
        {
            for (int i = 0; i < episodes.Length - 1; i++)
            {
                for (int j = i + 1; j < episodes.Length; j++)
                {
                    if (episodes[i] < episodes[j])
                    {
                        Episode temp = episodes[i];
                        episodes[i] = episodes[j];
                        episodes[j] = temp;
                    }
                }
            }
        }

        public static Episode[] LoadEpisodesFromFile(string filename)
        {
            
            string[]episodesInputs = File.ReadAllLines(filename);
            Episode[] episodes = new Episode[episodesInputs.Length];
            for (int i = 0; i < episodes.Length; i++)
            {
                episodes[i] = TvUtilities.Parse(episodesInputs[i]);
            }
            return episodes;
        }

    }
}

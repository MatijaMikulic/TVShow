using System;
using TVShow;
namespace Zadaca3
{
    class Program
    {
        static void Main(string[] args)
        {
            TestHomework3();
        }
        public static void TestHomework3()
        {
			// Assume that the number of rows in the text file is always at least 10. 
			// Assume a valid input file.
			string fileName = "shows.tv.txt";
			string outputFileName = "storage.tv.txt";

			IPrinter printer = new ConsolePrinter();
			printer.Print($"Reading data from file {fileName}");

			Episode[] episodes = TvUtilities.LoadEpisodesFromFile(fileName);
			Season season = new Season(1, episodes);

			printer.Print(season.ToString());
			for (int i = 0; i < season.Length; i++)
			{
				season[i].AddView(TvUtilities.GenerateRandomScore());
			}
			printer.Print(season.ToString());

			printer = new FilePrinter(outputFileName);
			printer.Print(season.ToString());
			
		}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            double picturesTaken = double.Parse(Console.ReadLine());
            double timeForFiltering = double.Parse(Console.ReadLine());
            double percentageOfGoodPcitures = double.Parse(Console.ReadLine());
            double timeForFilteredPhotos = double.Parse(Console.ReadLine());    //To be uploaded

            double filteredPicture = Math.Ceiling((double)(percentageOfGoodPcitures * picturesTaken) / 100);
            double totalTime = (picturesTaken * timeForFiltering) + (filteredPicture * timeForFilteredPhotos);
            TimeSpan time = TimeSpan.FromSeconds(totalTime);
            
            string timeFormating = string.Format("{0}:{1:D2}:{2:D2}:{3:D2}",
                time.Days,
                time.Hours,
                time.Minutes,
                time.Seconds);
            Console.WriteLine(timeFormating);
        }
    }
}

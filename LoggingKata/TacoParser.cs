using System;

namespace LoggingKata
{
    /// <summary>
    /// Parses a POI file to locate all the Taco Bells
    /// </summary>
    public class TacoParser
    {
        readonly ILog logger = new TacoLogger();

        public static double ConvertMetersToMiles(double meters)
        {
            return Math.Round(meters / 1609.344, 2);
        }

        public ITrackable Parse(string line)
        {
            logger.LogInfo("Begin parsing");

            // Take your line and use line.Split(',') to split it up into an array of strings, separated by the char ','
            var cells = line.Split(',');

            // If your array.Length is less than 3, something went wrong
            if (cells.Length < 3)
            {
                // Log that and return null
                // Do not fail if one record parsing fails, return null
                return null; // TODO Implement
            }

            // grab the latitude from your array at index 0
            double latitude = 0;
            if(double.TryParse(cells[0], out latitude) == false)
            {
                logger.LogError("Bad data- wasn't able to parse as double.");
            }
            // grab the longitude from your array at index 1
            double longitude = 0;
            if(double.TryParse(cells[1], out longitude) == false)
            {
                logger.LogError("Bad data- wasn't able to parse as double.");
            }
            // grab the name from your array at index 2
            var name = cells[2];

            // Your going to need to parse your string as a `double`
            // which is similar to parsing a string as an `int`

           

            // Then, you'll need an instance of the TacoBell class
            // With the name and point set correctly
            var tacobell = new TacoBell();
            tacobell.Name = name;
            var point = new Point();
            point.Latitude = latitude;
            point.Longitude = longitude;
            tacobell.Location = point;
            // Then, return the instance of your TacoBell class
            // Since it conforms to ITrackable
            return tacobell;
            
        }
    }
}
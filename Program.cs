using System;

namespace astro_dotnet
{
	class Program
	{
		static void Main(string[] args)
		{
			AstroUtil astroUtil = new AstroUtil();

			// Test Right Ascension
			astroUtil.RightAscension = astroUtil.ConvertRightAscensionToFloat(3, 27, 30);
			Console.WriteLine("Right Ascension is " + astroUtil.RightAscension.ToString());

			// Test Declination
			astroUtil.Declination = astroUtil.ConvertDeclinationToFloat(36, 3, 27, "N");
			Console.WriteLine("Declination is " + astroUtil.Declination.ToString());

			// Test Latitude
			astroUtil.Latitude = astroUtil.ConvertLatitudeToFloat(39, 22, 4, "N");
			Console.WriteLine("Latitude is " + astroUtil.Latitude.ToString());

			// Test Longitude
			astroUtil.Longitude = astroUtil.ConvertLongitudeToFloat(84, 12, 5, "W");
			Console.WriteLine("Longitude is " + astroUtil.Longitude.ToString());

			// Test Time
			astroUtil.Time = astroUtil.ConvertTimeToFloat(16, 30);
			Console.WriteLine("Time is " + astroUtil.Time.ToString());

			// Test Days From Epoch
			long daysFromEpoch = astroUtil.GetDaysFromEpoch();
			Console.WriteLine("Days elapsed from beginning of epoch: " + daysFromEpoch.ToString() + " (" + (daysFromEpoch / 365).ToString() + " years)");
		}
	}
}

using System;

namespace astro_dotnet
{
	class Program
	{
		static void Main(string[] args)
		{
			AstroUtil astroUtil = new AstroUtil();

			// Test Right Ascension
			astroUtil.SetRightAscension(3, 27, 30);
			Console.WriteLine("Right Ascension is " + astroUtil.RightAscension.ToString());

			// Test Declination
			astroUtil.SetDeclination(36, 3, 27, "N");
			Console.WriteLine("Declination is " + astroUtil.Declination.ToString());

			// Test Latitude
			astroUtil.SetLatitude(39, 22, 4, "N");
			Console.WriteLine("Latitude is " + astroUtil.Latitude.ToString());

			// Test Longitude
			astroUtil.SetLongitude(84, 12, 5, "W");
			Console.WriteLine("Longitude is " + astroUtil.Longitude.ToString());

			// Test Time
			astroUtil.SetTime(16, 30);
			Console.WriteLine("Time is " + astroUtil.Time.ToString());

			// Test Days From Epoch
			Console.WriteLine("Days elapsed from beginning of epoch: " + astroUtil.GetDaysFromEpoch().ToString());
		}
	}
}

using System;

namespace astro_dotnet
{
	public class AstroUtil
	{
		public float RightAscension;
		public float Declination;
		public float Time;
		public float Latitude;
		public float Longitude;

		public Int64 GetDaysFromEpoch()
		{
			var startTime = DateTime.Parse("1/1/2000");
			var endTime = DateTime.Now;

			var duration = endTime - startTime;

			return duration.Days;
		}

		public void SetDeclination(Int32 degrees, Int32 minutes, Int32 seconds, string cardinal)
		{
			float calcValue = (float)degrees + ((float)minutes / 60) + ((float)seconds / 60 / 60);

			switch (cardinal)
			{
				case "N":
					Declination = calcValue;
					break;
				case "S":
					Declination = -(calcValue);
					break;
				default:
					Declination = calcValue;
					break;
			}
		}

		public void SetRightAscension(Int32 hours, Int32 minutes, Int32 seconds)
		{
			RightAscension = ((float)hours + ((float)minutes / 60) + ((float)seconds / 60 / 60)) * 15;
		}

		public void SetLatitude(Int32 degrees, Int32 minutes, Int32 seconds, string cardinal)
		{
			float calcValue = (float)degrees + ((float)minutes / 60) + ((float)seconds / 60 / 60);

			switch (cardinal)
			{
				case "N":
					Latitude = calcValue;
					break;
				case "S":
					Latitude = -(calcValue);
					break;
				default:
					Latitude = calcValue;
					break;
			}
		}

		public void SetLongitude(Int32 degrees, Int32 minutes, Int32 seconds, string cardinal)
		{
			float calcValue = (float)degrees + ((float)minutes / 60) + ((float)seconds / 60 / 60);

			switch (cardinal)
			{
				case "E":
					Longitude = calcValue;
					break;
				case "W":
					Longitude = -(calcValue);
					break;
				default:
					Longitude = calcValue;
					break;
			}
		}

		public void SetTime(Int32 hours, Int32 minutes)
		{
			Time = (float)hours + ((float)minutes / 60);
		}
	}
}
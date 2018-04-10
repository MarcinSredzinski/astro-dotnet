using System;

namespace astro_dotnet
{
	public class AstroUtil
	{
		private float rightAscension, declination;
		private float latitude, longitude;
		private float time;

		public float Declination
		{
			get
			{
				return declination;
			}
			set
			{
				declination = value;
			}
		}

		public float ConvertDeclinationToFloat(Int32 degrees, Int32 minutes, Int32 seconds, string cardinal)
		{
			float calcValue = (float)degrees + ((float)minutes / 60) + ((float)seconds / 60 / 60);

			switch (cardinal)
			{
				case "N":
					break;
				case "S":
					calcValue = -(calcValue);
					break;
				default:
					break;
			}

			return calcValue;
		}

		public float RightAscension
		{
			get
			{
				return rightAscension;
			}
			set
			{
				rightAscension = value;
			}
		}

		public float ConvertRightAscensionToFloat(Int32 hours, Int32 minutes, Int32 seconds)
		{
			float calcValue = ((float)hours * 15) + ((float)minutes / 4) + ((float)seconds / 240);

			return calcValue;
		}

		public Int64 GetDaysFromEpoch()
		{
			var startTime = DateTime.Parse("1/1/2000");
			var endTime = DateTime.Now;

			var duration = endTime - startTime;

			return duration.Days;
		}

		public float Latitude
		{
			get
			{
				return latitude;
			}
			set
			{
				latitude = value;
			}
		}

		public float ConvertLatitudeToFloat(Int32 degrees, Int32 minutes, Int32 seconds, string cardinal)
		{
			float calcValue = (float)degrees + ((float)minutes / 60) + ((float)seconds / 60 / 60);

			switch (cardinal)
			{
				case "N":
					break;
				case "S":
					calcValue = -(calcValue);
					break;
				default:
					break;
			}

			return calcValue;
		}

		public float Longitude
		{
			get
			{
				return longitude;
			}
			set
			{
				longitude = value;
			}
		}

		public float ConvertLongitudeToFloat(Int32 degrees, Int32 minutes, Int32 seconds, string cardinal)
		{
			float calcValue = (float)degrees + ((float)minutes / 60) + ((float)seconds / 60 / 60);

			switch (cardinal)
			{
				case "E":
					break;
				case "W":
					calcValue = -(calcValue);
					break;
				default:
					break;
			}

			return calcValue;
		}

		public float Time
		{
			get
			{
				return time;
			}
			set
			{
				time = value;
			}
		}

		public float ConvertTimeToFloat(Int32 hours, Int32 minutes)
		{
			float calcValue = (float)hours + ((float)minutes / 60);

			return calcValue;
		}
	}
}
using System;

namespace Assignment
{
	public class SimpleCalculator
	{
		private readonly double kmToMiles = 0.621371;
		private readonly double kgToPounds = 2.20462;

		#region Basic Mathematical Operations

		public double Add(double a, double b)
		{
			return a + b;
		}

		public double Substract(double a, double b)
		{
			return a - b;
		}

		public double Multiply(double a, double b)
		{
			return a * b;
		}

		public double Devide(double a, double b)
		{
			if (b == 0)
			{
				Console.WriteLine("Division with 0 is not allowed!");
				return 0;
			}

			return a / b;
		}

		#endregion

		#region Conversions

		public double ConvertMilesToKilometers(double miles)
		{
			return miles / kmToMiles;
		}

		public double ConvertKilometersToMiles(double km)
		{
			return km * kmToMiles;
		}

		public double ConvertKilogramsToPounds(double kg)
		{
			return kg * kgToPounds;
		}

		public double ConvertPoundsToKilograms(double pounds)
		{
			return pounds / kgToPounds;
		}

		#endregion
	}
}

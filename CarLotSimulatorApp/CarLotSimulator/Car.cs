using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
	class Car
	{
		public Car(string make, string model, int year)
		{
			Make = make;
			Model = model;
			Year = year;
		}

		public Car()
		{

		}
		public string Make { get; set; }
		public string Model { get; set; }
		public int Year { get; set; }
		public string EngineNoise { get; set; }
		public string HonkNoise { get; set; }
		public bool IsDriveable { get; set; }

		public string MakeEngineNoise(string noise)
		{
			return noise;
		}

		public string MakeHonkNoise(string noise)
		{
			return noise;
		}
	}
}

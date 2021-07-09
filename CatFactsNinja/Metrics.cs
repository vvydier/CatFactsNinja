using System;
namespace CatFactsNinja
{
	public class Metrics
	{
		public string Name { get; set; }

		public string Model { get; set; }

		public string Manufacturer { get; set; }

		public string Version { get; set; }

		public override string ToString()
		{
			return Name;
		}
       
    }
}

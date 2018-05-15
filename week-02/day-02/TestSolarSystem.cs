using Microsoft.ViusalStudio.TestTools.UnitTesting;
using SolarSystem;

namespace SolarSystem.Tests
{
	[TestClass()]
	public class TestSolarSystem
	{
		[TestMethod()]
		public void TestSolarSystemWithOriginalList()
		{
			var planetList = new List<string> { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Uranus", "Neptune" };
            var expected = new List<string> { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Uranus", "Neptune", "Saturn" };
			Assert.AreEquals(expected, SolarSystem.PutSaturn(planetList));
		}

		[TestMethod()]
		public void TestSolarSystemWithEmptyList()
		{
			var list = new List<string> ();
            var expected = new List<string> ();
			Assert.AreEquals(expected, SolarSystem.PutSaturn(planetList));

		}
	}
}

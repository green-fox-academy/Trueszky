using Microsoft.ViusalStudio.TestTools.UnitTesting;
using Matchmaking;

namespace MakingMatches.Tests
{
	[TestClass()]
	public class TestMakingMatches
	{
		[TestMethod()]
		public void TestMakingMatchesWithOriginalList()
		{
			var girls = new List<string> {"Eve", "Ashley", "Bözsi", "Kat", "Jane"};
            var boys = new List<string> {"Joe", "Fred", "Béla", "Todd", "Neef", "Jeff"};
            var expected = new List<string> {"Eve", "Joe", "Ashley", "Fred", "Bözsi", "Béla", "Kat", "Todd", "Jane", "Neef"};
			Assert.AreEquals(expected, Matchmaking.MakingMatches(girls, boys));
		}

		[TestMethod()]
		public void TestMakingMatchesWithEmptyList()
		{
			var girls = new List<string> ();
            var boys = new List<string> ();
            var expected = new List<string> ();
			Assert.AreEquals(expected, Matchmaking.MakingMatches(girls, boys));
		}
	}
}

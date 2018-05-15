using Microsoft.ViusalStudio.TestTools.UnitTesting;
using CandyShop;

namespace CandyShop.Tests
{
	[TestClass()]
	public class TestCandyShop
	{
		[TestMethod()]
		public void TestSweetsWithOriginalList()
		{
			var expected = new List<string> {"Cupcake", "Croissant", "Brownie", "Ice cream"};
			var list = new List<string> {"Cupcake", 2, "Brownie", false};
			Assert.AreEqual(expected, CandyShop.Sweets(list));
		}

		[TestMethod()]
		public void TestSweetsWithEmptyList()
		{
			var expected = new List<string> ();
			var list = new List<string> ();
			Assert.AreEqual(expected, CandyShop.Sweets(list));
		}
	}
}

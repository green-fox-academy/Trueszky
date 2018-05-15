using Microsoft.ViusalStudio.TestTools.UnitTesting;
using ElementFinder;

namespace ElementFinder.Tests
{
	[TestClass()]
	public class TestElementFinder
	{
		[TestMethod()]
		public void TestContainsSevenWithOriginalList()
		{
			var List = new List<int>{1, 2, 3, 4, 5};
			string expected = "Noooooo";
			Assert.AreEqual(expected, ElementFinder.ContainsSeven(List));
		}

		[TestMethod()]
		public void TestContainsSevenEmptyList()
		{
			var List = new List<int> ();
			string expected = "Noooooo";
			Assert.AreEqual(expected, ElementFinder.ContainsSeven(List));
		}

		[TestMethod()]
		public void TestContainsSevenWithSevenInTheList()
		{
			var List = new List<int>{1, 2, 7, 4, 5};
			string expected = "Hoorray";
			Assert.AreEqual(expected, ElementFinder.ContainsSeven(List));
		}
	}
}

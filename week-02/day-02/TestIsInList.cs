using Microsoft.ViusalStudio.TestTools.UnitTesting;
using IsInList;

namespace IsInList.Tests
{
	[TestClass()]
	public class TestIsInList
	{
		[TestMethod()]
		public void TestCheckNumsWithOriginalList()
		{
			var list = new List<int>{2, 4, 6, 8, 10, 12, 14, 16};
			Assert.IsTrue(IsInList.CheckNums(list));
		}

		[TestMethod()]
		public void TestCheckNumsEmptyList()
		{
			var list = new List<int> ();
			Assert.IsFalse(IsInList.CheckNums(list));
		}

		[TestMethod()]
		public void TestCheckNumsWithNotAllElementsInTheList()
		{
			var list = new List<int>{1, 2, 7, 4, 5};
			Assert.IsFalse(IsInList.CheckNums(list));
		}
	}
}

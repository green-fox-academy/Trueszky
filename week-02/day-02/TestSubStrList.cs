using Microsoft.ViusalStudio.TestTools.UnitTesting;
using SubStrList;

namespace SubStrList.Tests
{
	[TestClass()]
	public class TestSubStrList
	{
		[TestMethod()]
		public void TestSubStrListWithOriginalList()
		{
			string[] searchArr = {"this", "is", "what", "I'm", "searching", "in"};
			Assert.AreEqual(4, SubStrList.SubStrList("ching", searchArr));
		}

		[TestMethod()]
		public void TestSubStrListWithEmptyList()
		{
    		string[] searchArr = {"this", "is"};
			Assert.AreEqual(-1, SubStrList.SubStrList("not", searchArr));
		}
	}
}

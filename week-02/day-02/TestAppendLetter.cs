using Microsoft.ViusalStudio.TestTools.UnitTesting;
using AppendLetter;

namespace AppendLetter.Tests
{
	[TestClass()]
	public class TestAppendLetter
	{
		[TestMethod()]
		public void TestAppendAWithOriginalList()
		{
			var expected = new List<string> {"kutya", "macska", "kacsa", "róka", "halacska"};
			var far = new List<string> {"kuty", "macsk", "kacs", "rók", "halacsk"};
			Assert.AreEqual(expected, AppendLetter.AppendA(far));
		}

		[TestMethod()]
		public void TestAppendAWithEmptyList()
		{
			var expected = new List<string> ();
			var far = new List<string> ();
			Assert.AreEqual(expected, AppendLetter.AppendA(far));
		}
	}
}

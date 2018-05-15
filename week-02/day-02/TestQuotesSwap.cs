using Microsoft.ViusalStudio.TestTools.UnitTesting;
using QuoteSwap;

namespace QuoteSwap.Tests
{
	[TestClass()]
	public class TestQuoteSwap
	{
		[TestMethod()]
		public void TestQuoteSwapWithOriginalList()
		{
			var list = new List<string> { "What", "I", "do", "create,", "I", "cannot", "not", "understand." };
            		string expected = "What i cannot create I do not understand.";
			Assert.AreEquals(expected, QuoteSwap.QuoteSwap(list));
		}
	}
}

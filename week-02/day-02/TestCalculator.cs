using Microsoft.ViusalStudio.TestTools.UnitTesting;
using Calculator;

namespace Calculator.Tests
{
	[TestClass()]
	public class TestCalculator
	{
		[TestMethod()]
		public void TestCalculatorAdd()
		{
			Assert.AreEqual(8 , Calculator.Calculate("+ 2 6"));
		}

		[TestMethod()]
		public void TestCalculatorMultply()
		{
			Assert.AreEqual(12 , Calculator.Calculate("* 3 4"));
		}

		[TestMethod()]
		public void TestCalculatorSubstract()
		{
			Assert.AreEqual(5 , Calculator.Calculate("- 8 3"));
		}

		[TestMethod()]
		public void TestCalculatorDivide()
		{
			Assert.AreEqual(3 , Calculator.Calculate("/ 9 3"));
		}

		[TestMethod()]
		public void TestCalculatorMod()
		{
			Assert.AreEqual(1 , Calculator.Calculate("% 5 2"));
		}

	}
}

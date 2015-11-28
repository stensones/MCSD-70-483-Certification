namespace ExampleCode.Tests.Unit.Chapter3
{
	using System;
	using ExampleCode.Chapter3;
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void AfterCtor_Values_Zero()
		{
			var sut = new StructWithNoCtor();

			Assert.AreEqual(0, sut.Two);
			Assert.AreEqual(0, sut.Three);
			Assert.IsNull(sut.MyObject);
		}
	}
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace ExampleCode.Tests.Unit.Chapter3
{
	using System;
	using ExampleCode.Chapter3;
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	[TestClass]
	public class StructWithDefaultCtorFacts
	{
		[TestMethod]
		public void AfterCtor_Values_AsInCtor()
		{
			var sut = new StructWithDefaultCtor();

			Assert.AreEqual(3, sut.One);
			Assert.AreEqual(69, sut.Two);
		}

		////[TestMethod]
		////public void NewStructWithoutNewCall_Doesnt_CallCtor()
		////{
		////	StructWithDefaultCtor sut;

		////	// not valid before we assign something to the fields
		////	//Assert.AreEqual(3, sut.One);
		////	//Assert.AreEqual(69, sut.Two);

		////	sut = null;
		////	if (sut != null)
		////	{
		////		// look compilers happy but obvs sut is null here so tests would NullReferenceException
		////		Assert.AreEqual(3, sut.One);
		////		Assert.AreEqual(69, sut.Two);
		////	}

		////	StructWithDefaultCtor sut2;
		////	sut2.One = 34;

		////	Assert.AreEqual(3, sut2.One);
		////	Assert.AreEqual(69, sut2.Two);
		////	Assert.IsNull(sut2.Three);
		////}
	}
}

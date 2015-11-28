using System;
using chapter3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chapter3.Tests.Unit
{
	[TestClass]
	public class Class3Facts
	{
		[TestMethod]
		public void TestMethod1()
		{
			var sut = new Class3();
			sut.Method1();
		}
	}
}

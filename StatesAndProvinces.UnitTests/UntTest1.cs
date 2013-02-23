using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StatesAndProvinces.UnitTests
{
	[TestClass]
	public class UntTest1
	{
		[TestMethod]
		public void MakesUSStates()
		{
			var actual = Factory.Make(CountrySelection.UnitedStates);

			Assert.AreEqual(51, actual.Count);
		}

		[TestMethod]
		public void MakesCanadianProvinces()
		{
			var actual = Factory.Make(CountrySelection.Canada);

			Assert.AreEqual(13, actual.Count);
		}

		[TestMethod]
		public void MakesBothUSAndCanada()
		{
			var actual = Factory.Make(CountrySelection.UnitedStates | CountrySelection.Canada);

			Assert.AreEqual(64, actual.Count);
		}

		[TestMethod]
		[ExpectedException(typeof(System.NotImplementedException))]
		public void ThrowsExceptionIfCountryNotAvailable()
		{
			var actual = Factory.Make((CountrySelection)100);
		}
	}
}

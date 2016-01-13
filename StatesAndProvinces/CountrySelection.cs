// Copyright (C) 2013 Paul G Brown

using System;
using System.ComponentModel;

namespace StatesAndProvinces
{
	/// <summary>
	/// Represents the countries for whom subregions are available.
	/// </summary>
	[Flags]
	public enum CountrySelection
	{
		[Description("Canada")]
		Canada = 1,

		[Description("United States")]
		UnitedStates = 2
	}
}

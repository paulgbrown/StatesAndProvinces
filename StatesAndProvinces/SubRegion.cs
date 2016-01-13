// Copyright (C) 2013 Paul G Brown

namespace StatesAndProvinces
{
	/// <summary>
	/// Represents a political subregion such as a state or province.
	/// </summary>
	public class SubRegion
	{
		/// <summary>
		/// Gets or sets the name of the subregion.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets the ISO-3166 code for the subregion.
		/// </summary>
		public string IsoCode { get; set; }

		/// <summary>
		/// Gets or sets the standard abbreviation for the subregion.
		/// </summary>
		/// <remarks>
		/// For the US, this is the USPS 2 character abbreviation.
		/// </remarks>
		public string Abbreviation { get; set; }

		/// <summary>
		/// Gets or sets an alternative abbreviation that may be used.
		/// </summary>
		/// <remarks>
		/// This is a common local or historical abbreviation.
		/// </remarks>
		public string AlternateAbbreviation { get; set; }
	}
}

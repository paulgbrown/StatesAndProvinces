// Copyright (C) 2013 Paul G Brown

using System.Collections.Generic;

namespace StatesAndProvinces
{
	/// <summary>
	/// Creates the list of subregions for the individual countries.
	/// </summary>
	public static class Factory
	{
		/// <summary>
		/// Public member for creating a list of subregions.
		/// </summary>
		/// <param name="selection">The country or countries that define the desired subregions.</param>
		/// <returns>A generic List of Subregions.</returns>
		/// <remarks>
		/// More that one country may be returned by using the bitwise OR operator.
		/// </remarks>
		public static List<SubRegion> Make(CountrySelection selection)
		{
			var results = new List<SubRegion>();

			if (selection.HasFlag(CountrySelection.Canada))
			{
				results.AddRange(MakeCanadianProvinces());
			}

			if (selection.HasFlag(CountrySelection.UnitedStates))
			{
				results.AddRange(MakeUSStates());
			}

			if (results.Count == 0)
			{
				throw new System.NotImplementedException("The country selection has not been implemented.");
			}
			return results;
		}

		/// <summary>
		/// Creates the list of Canadian provinces.
		/// </summary>
		/// <returns>A generic List of provinces.</returns>
		private static List<SubRegion> MakeCanadianProvinces()
		{
			var results = new List<SubRegion>();
			results.Add(new SubRegion() { Abbreviation = "AB", Name = "Alberta", AlternateAbbreviation = "Alta.", IsoCode = "CA-AB" });
			results.Add(new SubRegion() { Abbreviation = "BC", Name = "British Columbia", AlternateAbbreviation = "B.C.", IsoCode = "CA-BC" });
			results.Add(new SubRegion() { Abbreviation = "MB", Name = "Manitoba", AlternateAbbreviation = "Man.", IsoCode = "CA-MB" });
			results.Add(new SubRegion() { Abbreviation = "NB", Name = "New Brunswick", AlternateAbbreviation = "N.B.", IsoCode = "CA-NB" });
			results.Add(new SubRegion() { Abbreviation = "NL", Name = "Newfoundland and Labrador", AlternateAbbreviation = "Nfld.", IsoCode = "CA-NL" });
			results.Add(new SubRegion() { Abbreviation = "NS", Name = "Nova Scotia", AlternateAbbreviation = "N.S.", IsoCode = "CA-NS" });
			results.Add(new SubRegion() { Abbreviation = "NT", Name = "Northwest Territories", AlternateAbbreviation = "N.W.T.", IsoCode = "CA-NT" });
			results.Add(new SubRegion() { Abbreviation = "NU", Name = "Nunavut", AlternateAbbreviation = "Nun.", IsoCode = "CA-NU" });
			results.Add(new SubRegion() { Abbreviation = "ON", Name = "Ontario", AlternateAbbreviation = "Ont.", IsoCode = "CA-ON" });
			results.Add(new SubRegion() { Abbreviation = "PE", Name = "Prince Edward Island", AlternateAbbreviation = "P.E.I.", IsoCode = "CA-PE" });
			results.Add(new SubRegion() { Abbreviation = "QC", Name = "Quebec", AlternateAbbreviation = "Que.", IsoCode = "CA-QC" });
			results.Add(new SubRegion() { Abbreviation = "SK", Name = "Saskatchewan", AlternateAbbreviation = "Sask.", IsoCode = "CA-SK" });
			results.Add(new SubRegion() { Abbreviation = "YT", Name = "Yukon", AlternateAbbreviation = "Yuk.", IsoCode = "CA-YT" });
			return results;
		}

		/// <summary>
		/// Creates the list of US states.
		/// </summary>
		/// <returns>A generic List of US states.</returns>
		private static List<SubRegion> MakeUSStates()
		{
			var results = new List<SubRegion>();
			results.Add(new SubRegion() { Name = "Alabama", IsoCode ="US-AL", Abbreviation = "AL", AlternateAbbreviation = "Ala." });
			results.Add(new SubRegion() { Name = "Alaska", IsoCode ="US-AK", Abbreviation = "AK", AlternateAbbreviation = "Alaska" });
			results.Add(new SubRegion() { Name = "Arizona", IsoCode ="US-AZ",Abbreviation  = "AZ",AlternateAbbreviation  = "Ariz." });
			results.Add(new SubRegion() { Name = "Arkansas", IsoCode ="US-AR", Abbreviation = "AR",AlternateAbbreviation  = "Ark." });
			results.Add(new SubRegion() { Name = "California", IsoCode ="US-CA",Abbreviation  = "CA",AlternateAbbreviation  = "Calif." });
			results.Add(new SubRegion() { Name = "Colorado", IsoCode ="US-CO", Abbreviation = "CO", AlternateAbbreviation = "Colo." });
			results.Add(new SubRegion() { Name = "Connecticut", IsoCode = "US-CT",Abbreviation  = "CT", AlternateAbbreviation = "Conn." });
			results.Add(new SubRegion() { Name = "Delaware", IsoCode = "US-DE",  Abbreviation= "DE", AlternateAbbreviation = "Del." });
			results.Add(new SubRegion() { Name = "District of Columbia",IsoCode  = "US-DC",Abbreviation  = "DC", AlternateAbbreviation = "D.C." });
			results.Add(new SubRegion() { Name = "Florida", IsoCode = "US-FL", Abbreviation = "FL", AlternateAbbreviation = "Fla." });
			results.Add(new SubRegion() { Name = "Georgia", IsoCode = "US-GA", Abbreviation = "GA", AlternateAbbreviation = "Ga." });
			results.Add(new SubRegion() { Name = "Hawaii", IsoCode = "US-HI", Abbreviation = "HI",AlternateAbbreviation  = "Hawaii" });
			results.Add(new SubRegion() { Name = "Idaho", IsoCode = "US-ID", Abbreviation = "ID", AlternateAbbreviation = "Idaho" });
			results.Add(new SubRegion() { Name = "Illinois", IsoCode = "US-IL",Abbreviation  = "IL",AlternateAbbreviation  = "Ill." });
			results.Add(new SubRegion() { Name = "Indiana", IsoCode = "US-IN",Abbreviation  = "IN", AlternateAbbreviation = "Ind." });
			results.Add(new SubRegion() { Name = "Iowa", IsoCode = "US-IA", Abbreviation = "IA", AlternateAbbreviation = "Iowa" });
			results.Add(new SubRegion() { Name = "Kansas", IsoCode = "US-KS",Abbreviation  = "KS", AlternateAbbreviation = "Kan." });
			results.Add(new SubRegion() { Name = "Kentucky", IsoCode = "US-KY",Abbreviation  = "KY",AlternateAbbreviation  = "Ky." });
			results.Add(new SubRegion() { Name = "Louisiana", IsoCode = "US-LA", Abbreviation = "LA", AlternateAbbreviation = "La." });
			results.Add(new SubRegion() { Name = "Maine", IsoCode = "US-ME", Abbreviation = "ME", AlternateAbbreviation = "Maine" });
			results.Add(new SubRegion() { Name = "Maryland", IsoCode = "US-MD",Abbreviation  = "MD",AlternateAbbreviation  = "Md." });
			results.Add(new SubRegion() { Name = "Massachusetts", IsoCode = "US-MA", Abbreviation = "MA", AlternateAbbreviation = "Mass." });
			results.Add(new SubRegion() { Name = "Michigan", IsoCode = "US-MI", Abbreviation = "MI", AlternateAbbreviation = "Mich." });
			results.Add(new SubRegion() { Name = "Minnesota", IsoCode = "US-MN",Abbreviation  = "MN", AlternateAbbreviation = "Minn." });
			results.Add(new SubRegion() { Name = "Mississippi", IsoCode = "US-MS",Abbreviation  = "MS",AlternateAbbreviation  = "Miss." });
			results.Add(new SubRegion() { Name = "Missouri", IsoCode = "US-MO",Abbreviation  = "MO", AlternateAbbreviation = "Mo." });
			results.Add(new SubRegion() { Name = "Montana", IsoCode = "US-MT", Abbreviation = "MT", AlternateAbbreviation = "Mont." });
			results.Add(new SubRegion() { Name = "Nebraska",IsoCode  = "US-NE", Abbreviation = "NE",AlternateAbbreviation  = "Neb." });
			results.Add(new SubRegion() { Name = "Nevada", IsoCode = "US-NV",Abbreviation  = "NV", AlternateAbbreviation = "Nev." });
			results.Add(new SubRegion() { Name = "New Hampshire", IsoCode = "US-NH", Abbreviation = "NH", AlternateAbbreviation = "N.H." });
			results.Add(new SubRegion() { Name = "New Jersey", IsoCode = "US-NJ", Abbreviation = "NJ", AlternateAbbreviation = "N.J." });
			results.Add(new SubRegion() { Name = "New Mexico", IsoCode = "US-NM",Abbreviation  = "NM", AlternateAbbreviation = "N.M." });
			results.Add(new SubRegion() { Name = "New York",IsoCode  = "US-NY", Abbreviation = "NY", AlternateAbbreviation = "N.Y." });
			results.Add(new SubRegion() { Name = "North Carolina", IsoCode = "US-NC", Abbreviation = "NC",AlternateAbbreviation  = "N.C" });
			results.Add(new SubRegion() { Name = "North Dakota",IsoCode  = "US-ND",Abbreviation  = "ND", AlternateAbbreviation = "N.D." });
			results.Add(new SubRegion() { Name = "Ohio", IsoCode = "US-OH", Abbreviation = "OH", AlternateAbbreviation = "Ohio" });
			results.Add(new SubRegion() { Name = "Oklahoma", IsoCode = "US-OK", Abbreviation = "OK", AlternateAbbreviation = "Okla." });
			results.Add(new SubRegion() { Name = "Oregon",IsoCode  = "US-OR",Abbreviation  = "OR", AlternateAbbreviation = "Ore." });
			results.Add(new SubRegion() { Name = "Pennsylvania", IsoCode = "US-PA",Abbreviation  = "PA", AlternateAbbreviation = "Pa." });
			results.Add(new SubRegion() { Name = "Rhode Island", IsoCode = "US-RI",Abbreviation  = "RI", AlternateAbbreviation = "R.I." });
			results.Add(new SubRegion() { Name = "South Carolina", IsoCode = "US-SC",Abbreviation  = "SC",AlternateAbbreviation  = "S.C." });
			results.Add(new SubRegion() { Name = "South Dakota", IsoCode = "US-SD",Abbreviation  = "SD", AlternateAbbreviation = "S.D." });
			results.Add(new SubRegion() { Name = "Tennessee",IsoCode  = "US-TN", Abbreviation = "TN", AlternateAbbreviation = "Tenn." });
			results.Add(new SubRegion() { Name = "Texas", IsoCode = "US-TX", Abbreviation = "TX", AlternateAbbreviation = "Texas" });
			results.Add(new SubRegion() { Name = "Utah", IsoCode = "US-UT", Abbreviation = "UT", AlternateAbbreviation = "Utah" });
			results.Add(new SubRegion() { Name = "Vermont", IsoCode = "US-VT",Abbreviation  = "VT", AlternateAbbreviation = "Vt." });
			results.Add(new SubRegion() { Name = "Virginia", IsoCode = "US-VA", Abbreviation = "VA",AlternateAbbreviation  = "Va." });
			results.Add(new SubRegion() { Name = "Washington", IsoCode = "US-WA", Abbreviation = "WA",AlternateAbbreviation  = "Wash." });
			results.Add(new SubRegion() { Name = "West Virginia",IsoCode  = "US-WV", Abbreviation = "WV",AlternateAbbreviation  = "W.Va." });
			results.Add(new SubRegion() { Name = "Wisconsin", IsoCode = "US-WI",Abbreviation  = "WI",AlternateAbbreviation  = "Wis." });
			results.Add(new SubRegion() { Name = "Wyoming", IsoCode = "US-WY", Abbreviation = "WY", AlternateAbbreviation = "Wyo." });
			return results;
		}
	}
}

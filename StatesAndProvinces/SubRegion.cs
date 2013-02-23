// Copyright (C) 2013 Paul G Brown

// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.

// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.

// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

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

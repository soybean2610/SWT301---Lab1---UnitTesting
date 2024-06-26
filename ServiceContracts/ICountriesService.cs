﻿using ServiceContracts.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceContracts
{
    /// <summary>
    /// Represents business logic for manipulate
    /// Country entity
    /// </summary>
    public interface ICountriesService
    {
        /// <summary>
        /// Adds a country object to the list of countries
        /// </summary>
        /// <param name="countryAddRequest">
        /// Country object to add
        /// </param>
        /// <returns>
        /// Returns the country object after adding it
        /// </returns>
        CountryResponse AddCountry(CountryAddRequest?
            countryAddRequest);

        /// <summary>
        /// Returns all countries from the list
        /// </summary>
        /// <returns>
        /// All countries from the list as List
        /// of CountryResponse
        /// </returns>
        List<CountryResponse> GetAllCountries();

        /// <summary>
        /// Returns a country object based on the given country id
        /// </summary>
        /// <param name="countryID">CountryID (guid) to search</param>
        /// <returns>
        /// Matching country as CountryResponse object
        /// </returns>
        CountryResponse? GetCountryByCountryID(Guid? countryID);
    }
}

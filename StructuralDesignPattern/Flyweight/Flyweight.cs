using Microsoft.Extensions.Caching.Memory;

using System;
using System.Collections.Generic;
using System.Linq;

namespace Flyweight
{
    public class FlyweightFactory
    {
        public static IMemoryCache cache;

        public ICountryManager ICountryManager
        {
            get => default;
            set
            {
            }
        }

        public static IEnumerable<Country> GetCountries()
        {
            ICountryManager countryManager = new CountryManager();

            var countries = cache.Get<IEnumerable<Country>>("country");
            if (countries != null)
            {
                return countries;
            }

            countries = countryManager.GetCountries();
            cache.Set("country", countries);
            return countries;
        }
    }

    public interface ICountryManager
    {
        IEnumerable<Country> GetCountries();
    }

    public class CountryManager : ICountryManager
    {
        public Country Country
        {
            get => default;
            set
            {
            }
        }

        public IEnumerable<Country> GetCountries()
        {
            var countries = new List<Country>
            {
                new Country{ Id=Guid.NewGuid(),Name="VietNam" },
                new Country{ Id=Guid.NewGuid(),Name="Australia" },
                new Country{ Id=Guid.NewGuid(),Name="America" }
            };
            return countries.AsEnumerable();
        }
    }

    public class Country
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}
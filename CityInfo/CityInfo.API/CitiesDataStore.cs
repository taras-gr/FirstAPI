using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityInfo.API.Models;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDTO> Cities { get; set; }

        public CitiesDataStore()
        {
            Cities = new List<CityDTO>()
            {
                new CityDTO()
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "The one with that big park.",
                    PointsOfInterest = new List<PointIfInterestDTO>()
                    {
                        new PointIfInterestDTO()
                        {
                            Id = 1,
                            Name = "Central Park",
                            Description = "The most visited urban park in the US."
                        },
                        new PointIfInterestDTO()
                        {
                            Id = 2,
                            Name = "Empire State Building",
                            Description = "A 102-story skyscrapper in Midtown Manhattan."
                        }
                    }
                },
                new CityDTO()
                {
                    Id = 2,
                    Name = "Antwerp",
                    Description = "The one with the cathedral that was never really finished."
                },
                new CityDTO()
                {
                    Id = 3,
                    Name = "Paris",
                    Description = "The one with that big tower."
                }
            };
        }
    }
}

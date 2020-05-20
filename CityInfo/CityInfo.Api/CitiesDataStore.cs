using CityInfo.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.Api
{
    public class CitiesDataStore
    {
        /// <summary>
        /// Returns cities list
        /// </summary>
        public static CitiesDataStore Current { get => new CitiesDataStore(); }

        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "City never sleeps",
                    PointsOfInterests = new List<PointsOfInterestDto>()
                    {
                        new PointsOfInterestDto()
                        {
                            Id = 1,
                            Name = "Statue of Liberty",
                            Description = "The great land mark of the city"
                        },
                        new PointsOfInterestDto()
                        {
                            Id = 2,
                            Name = "Empire State Building",
                            Description = "Wonderful place to watch city skyscrapers"
                        }
                    }

                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Singapore City",
                    Description = "City of garnder and lakes",
                    PointsOfInterests = new List<PointsOfInterestDto>()
                    {
                        new PointsOfInterestDto()
                        {
                            Id = 1,
                            Name = "Universal Studio",
                            Description = "Great place for the adventure rides."
                        },
                        new PointsOfInterestDto()
                        {
                            Id = 2,
                            Name = "Merlion Park",
                            Description = "City iconic landmark to visit"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Hyderabad City",
                    Description = "City of pearls",
                    PointsOfInterests = new List<PointsOfInterestDto>()
                    {
                        new PointsOfInterestDto()
                        {
                            Id = 1,
                            Name = "Charminar",
                            Description = "Historical monument built 400 years back"
                        },
                        new PointsOfInterestDto()
                        {
                            Id = 2,
                            Name = "Buddha Statue",
                            Description = "Great monument sculptured with a single rock"
                        }
                    }
                }
            };
   
        }
    }
}

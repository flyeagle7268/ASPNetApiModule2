﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.Api.Models
{
    public class CityDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<PointsOfInterestDto> PointsOfInterests { get; set; } = new List<PointsOfInterestDto>();
    }
}

using System;

namespace RickLocalization.Application.Queries.Ricks.GetDetails
{
    public class GetDetailsRickViewModel
    {
        public String id { get; set; }
        public String name { get; set; }
        public String urlImage { get; set; }
        public String description { get; set; }
        public GetDetailsRickDimensionViewModel dimensionOrigin { get; set; }
        public GetDetailsRickDimensionViewModel dimensionCurrent { get; set; }
    }
}

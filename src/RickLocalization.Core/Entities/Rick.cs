using System;
using System.Collections.Generic;

namespace RickLocalization.Core.Entities
{
    public class Rick
    {
        public Guid Id { get; set; }
        public Guid IdMorty { get; set; }
        public Guid IdDimensionOrigin { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public String Url { get; set; }
        public String UrlImage { get; set; }
        public DateTime RegistrationDate { get; set; }
        public virtual Morty Morty { get; set; }
        public virtual Dimension DimensionOrigin { get; set; }
        public virtual ICollection<DimensionTravelled> DimensionsTravelled { get; set; }
    }
}

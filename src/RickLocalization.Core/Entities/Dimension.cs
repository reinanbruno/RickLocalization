using System;
using System.Collections.Generic;

namespace RickLocalization.Core.Entities
{
    public class Dimension
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public virtual ICollection<DimensionTravelled> DimensionsTravelledBefore { get; set; }
        public virtual ICollection<DimensionTravelled> DimensionsTravelledCurrent { get; set; }
        public virtual ICollection<Rick> Ricks { get; set; }
    }
}

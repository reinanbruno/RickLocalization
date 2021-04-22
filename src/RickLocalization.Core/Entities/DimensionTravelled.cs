using System;

namespace RickLocalization.Core.Entities
{
    public class DimensionTravelled
    {
        public Guid Id { get; set; }
        public Guid IdRick { get; set; }
        public Guid? IdDimensionBefore { get; set; }
        public Guid IdDimensionCurrent { get; set; }
        public DateTime RegistrationDate { get; set; }
        public virtual Rick Rick { get; set; }
        public virtual Dimension DimensionBefore { get; set; }
        public virtual Dimension DimensionCurrent { get; set; }
    }
}

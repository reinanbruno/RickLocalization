using System;
using System.Collections.Generic;

namespace RickLocalization.Core.Entities
{
    public class Morty
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public String UrlImage { get; set; }
        public virtual ICollection<Rick> Ricks { get; set; }
    }
}

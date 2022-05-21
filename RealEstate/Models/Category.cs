using System;
using System.Collections.Generic;

#nullable disable

namespace RealEstate.Models
{
    public partial class Category
    {
        public Category()
        {
            Realestates = new HashSet<Ad>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Ad> Realestates { get; set; }
    }
}

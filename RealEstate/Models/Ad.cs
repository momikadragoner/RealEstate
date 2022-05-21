using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

#nullable disable

namespace RealEstate.Models
{
    public partial class Ad
    {
        public long Id { get; set; }
        public long CategoryId { get; set; }
        public long SellerId { get; set; }
        public string Description { get; set; }
        public DateTime CreateAt { get; set; }
        public bool Freeofcharge { get; set; }
        public string ImageUrl { get; set; }
        public int? Area { get; set; }
        public int? Rooms { get; set; }
        public int? Floors { get; set; }
        public string Latlong { get; set; }

        public virtual Category Category { get; set; }
        public virtual Seller Seller { get; set; }

        public static List<Ad> LoadFromJson(string file)
        {
            return JsonConvert.DeserializeObject<List<Ad>>(File.ReadAllText(file));
        }

        public double DistanceTo(double x, double y)
        {
            double dx = Math.Abs(Convert.ToDouble(this.Latlong.Split(',')[0].Replace(".",",")) - x);
            double dy = Math.Abs(Convert.ToDouble(this.Latlong.Split(',')[1].Replace(".",",")) - y);
            return Math.Sqrt(dy * dy + dx * dx);
        }
    }
}

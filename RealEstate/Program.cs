using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using RealEstate.Models;

namespace RealEstate
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ad> ads = Ad.LoadFromJson("realestates.json");
            Console.WriteLine("1. Földszinti ingatlanok átlagos alapterülete: {0:F2} m2", ads.Where(x => x.Floors == 0).Average(x => x.Area));
            var adat = ads.Where(x => x.Freeofcharge).OrderBy(x => x.DistanceTo(47.4164220114023, 19.066342425796986)).FirstOrDefault();
            Console.WriteLine("2. Mesevár óvodához légvonalban legközelebbi tehermentes ingatlan adatai:");
            Console.WriteLine("\tEladó neve: {0}", adat.Seller.Name);
            Console.WriteLine("\tEladó telefonja: {0}", adat.Seller.Phone);
            Console.WriteLine("\tAlapterület: {0}", adat.Area);
            Console.WriteLine("\tSzobák szma: {0}", adat.Rooms);
        }
    }
}

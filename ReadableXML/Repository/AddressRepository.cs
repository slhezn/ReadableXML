using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReadableXML.Repository
{
    public class AddressRepository
    {
        public string ID { get; set; }
        public string Room { get; set; }
        public string StreetName { get; set; }
        public string BuildingName { get; set; }
        public string BuildingNumber { get; set; }
        public string CitySubDivisionName { get; set; }
        public string CityName { get; set; }
        public string PostalZone { get; set; }
        public string Region { get; set; }
        public string District { get; set; }
        public CountryRepository Country { get; set; }
    }
}

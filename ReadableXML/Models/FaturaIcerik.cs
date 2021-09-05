using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReadableXML.Models
{
    public class FaturaIcerik
    {
        public string SiraNo { get; set; }
        public string Miktar { get; set; }
        public string BirimFiyat { get; set; }
        public string UrunHizmetAdi { get; set; }
        public string UrunHizmetTanim { get; set; }
        public string UrunHizmetTutar { get; set; }
        public string KdvOran { get; set; }
        public string KdvTutar { get; set; }
    }
}

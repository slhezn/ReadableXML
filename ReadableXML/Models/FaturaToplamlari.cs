using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReadableXML.Models
{
    public class FaturaToplamlari
    {
        public string MalHizmetToplamtutar { get; set; }
        public string HesaplananKdv { get; set; }
        public string KdvOran { get; set; }
        public string IndirimTutari { get; set; }
        public string TahsilEdilen { get; set; }
        public string OdenecekTutar { get; set; }
    }
}

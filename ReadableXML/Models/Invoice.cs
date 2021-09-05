using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReadableXML.Models
{
    public class Invoice
    {
        public Tedarikci Tedarikci { get; set; }
        public Musteri Musteri { get; set; }
        public List<FaturaIcerik> FaturaIcerik { get; set; }
        public FaturaOzellikleri FaturaOzellikleri { get; set; }
        public FaturaToplamlari FaturaToplamlari { get; set; }
        public List<string> OtherNotes { get; set; }

    }
}

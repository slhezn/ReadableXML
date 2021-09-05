using ReadableXML.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReadableXML.Repository
{
    public class XadesCertRepository
    {
        public XadesCertDigestRepository XadesCertDigestRepository { get; set; }

        public XadesIssuerSerialRepository XadesIssuerSerialRepository { get; set; }

    }
}

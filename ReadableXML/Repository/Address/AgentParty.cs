using System.Collections.Generic;

namespace ReadableXML.Repository
{
    public class AgentParty
    {
        public List<PartyIdentification> PartyIdentification { get; set; }
        public PartyName PartyName { get; set; }
        public AddressRepository PostalAddress { get; set; }
            
    }
}
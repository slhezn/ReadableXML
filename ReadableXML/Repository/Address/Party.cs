using System.Collections.Generic;

namespace ReadableXML.Repository
{
    public class Party
    {
        public string WebsiteURI { get; set; }
        public List<Dictionary<string, string>> PartyIdentification{ get; set; }
        public PartyName PartyName { get; set; }
        public AddressRepository PostalAddress { get; set; }
        public PartyTaxScheme PartyTaxScheme { get; set; }
        public Contact Contact { get; set; }
        public AgentParty AgentParty { get; set; }

    }
}
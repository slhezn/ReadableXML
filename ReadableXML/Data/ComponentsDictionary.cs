using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReadableXML.Data
{
    public class ComponentsDictionary
    {
        public Dictionary<string, string> Tedarikci = new Dictionary<string, string>() {
            { "unvan", "cac:AccountingSupplierParty/cac:Party/cac:PartyName/cbc:Name" },
            { "adresId", "cac:AccountingSupplierParty/cac:Party/cac:PostalAddress/cbc:ID" },
            { "adresCadde", "cac:AccountingSupplierParty/cac:Party/cac:PostalAddress/cbc:StreetName" },
            { "adresOdaNo", "cac:AccountingSupplierParty/cac:Party/cac:PostalAddress/cbc:Room" },
            { "adresBinaAdi", "cac:AccountingSupplierParty/cac:Party/cac:PostalAddress/cbc:BuildingName" },
            { "adresBinaNo", "cac:AccountingSupplierParty/cac:Party/cac:PostalAddress/cbc:BuildingNumber" },
            { "adresIlce", "cac:AccountingSupplierParty/cac:Party/cac:PostalAddress/cbc:CitySubdivisionName" },
            { "adresSemt", "cac:AccountingSupplierParty/cac:Party/cac:PostalAddress/cbc:Region" },
            { "adresIl", "cac:AccountingSupplierParty/cac:Party/cac:PostalAddress/cbc:CityName" },
            { "adresPostaKodu", "cac:AccountingSupplierParty/cac:Party/cac:PostalAddress/cbc:PostalZone" },
            { "adresUlkeKodu", "cac:AccountingSupplierParty/cac:Party/cac:PostalAddress/cac:Country/cbc:IdentificationCode" },
            { "adresUlkeAdi", "cac:AccountingSupplierParty/cac:Party/cac:PostalAddress/cac:Country/cbc:Name" },
            { "iletisimKisiAd", "cac:AccountingSupplierParty/cac:Party/cac:Person/cbc:FirstName" },
            { "iletisimKisiSoyad", "cac:AccountingSupplierParty/cac:Party/cac:Person/cbc:FamilyName" },
            { "iletisimTelefon", "cac:AccountingSupplierParty/cac:Party/cac:Contact/cbc:Telephone" },
            { "iletisimEmail", "cac:AccountingSupplierParty/cac:Party/cac:Contact/cbc:ElectronicMail" },
            { "iletisimFax", "cac:AccountingSupplierParty/cac:Party/cac:Contact/cbc:Telefax" },
            { "iletisimWeb", "cac:AccountingSupplierParty/cac:Party/cbc:WebsiteURI" },
            { "vergiDairesi", "cac:AccountingSupplierParty/cac:Party/cac:PartyTaxScheme/cac:TaxScheme/cbc:Name" },
            { "vkn", "cac:AccountingSupplierParty/cac:Party/cac:PartyIdentification/cbc:ID[@schemeID='VKN']" },
            { "ticaretSicilNo", "cac:AccountingSupplierParty/cac:Party/cac:PartyIdentification/cbc:ID[@schemeID='TICARETSICILNO']" },
            { "mersisNo", "cac:AccountingSupplierParty/cac:Party/cac:PartyIdentification/cbc:ID[@schemeID='MERSISNO']" },
            { "tckn", "cac:AccountingSupplierParty/cac:Party/cac:PartyIdentification/cbc:ID[@schemeID='TCKN']" }
        };

        public Dictionary<string, string> Musteri = new Dictionary<string, string>() {
            { "unvan", "cac:AccountingCustomerParty/cac:Party/cac:PartyName/cbc:Name" },
            { "firstName", "cac:AccountingCustomerParty/cac:Party/cac:Person/cbc:FirstName" },
            { "familyName", "cac:AccountingCustomerParty/cac:Party/cac:Person/cbc:FamilyName" },
            { "adresId", "cac:AccountingCustomerParty/cac:Party/cac:PostalAddress/cbc:ID" },
            { "adresCadde", "cac:AccountingCustomerParty/cac:Party/cac:PostalAddress/cbc:StreetName" },
            { "adresOdaNo", "cac:AccountingCustomerParty/cac:Party/cac:PostalAddress/cbc:Room" },
            { "adresBinaAdi", "cac:AccountingCustomerParty/cac:Party/cac:PostalAddress/cbc:BuildingName" },
            { "adresBinaNo", "cac:AccountingCustomerParty/cac:Party/cac:PostalAddress/cbc:BuildingNumber" },
            { "adresIlce", "cac:AccountingCustomerParty/cac:Party/cac:PostalAddress/cbc:CitySubdivisionName" },
            { "adresSemt", "cac:AccountingCustomerParty/cac:Party/cac:PostalAddress/cbc:Region" },
            { "adresIl", "cac:AccountingCustomerParty/cac:Party/cac:PostalAddress/cbc:CityName" },
            { "adresPostaKodu", "cac:AccountingCustomerParty/cac:Party/cac:PostalAddress/cbc:PostalZone" },
            { "adresUlkeKodu", "cac:AccountingCustomerParty/cac:Party/cac:PostalAddress/cac:Country/cbc:IdentificationCode" },
            { "adresUlkeAdi", "cac:AccountingCustomerParty/cac:Party/cac:PostalAddress/cac:Country/cbc:Name" },
            { "iletisimKisiAd", "cac:AccountingCustomerParty/cac:Party/cac:Person/cbc:FirstName" },
            { "iletisimKisiSoyad", "cac:AccountingCustomerParty/cac:Party/cac:Person/cbc:FamilyName" },
            { "iletisimTelefon", "cac:AccountingCustomerParty/cac:Party/cac:Contact/cbc:Telephone" },
            { "iletisimEmail", "cac:AccountingCustomerParty/cac:Party/cac:Contact/cbc:ElectronicMail" },
            { "iletisimFax", "cac:AccountingCustomerParty/cac:Party/cac:Contact/cbc:Telefax" },
            { "iletisimWeb", "cac:AccountingCustomerParty/cac:Party/cbc:WebsiteURI" },
            { "vergiDairesi", "cac:AccountingCustomerParty/cac:Party/cac:PartyTaxScheme/cac:TaxScheme/cbc:Name" },
            { "vkn", "cac:AccountingCustomerParty/cac:Party/cac:PartyIdentification/cbc:ID[@schemeID='VKN']" },
            { "ticaretSicilNo", "cac:AccountingCustomerParty/cac:Party/cac:PartyIdentification/cbc:ID[@schemeID='TICARETSICILNO']" },
            { "mersisNo", "cac:AccountingCustomerParty/cac:Party/cac:PartyIdentification/cbc:ID[@schemeID='MERSISNO']" },
            { "agentMusteriNo", "cac:AccountingCustomerParty/cac:Party/cac:AgentParty/cac:PartyIdentification/cbc:ID[@schemeID='MUSTERINO']" },
            { "agentMusteri", "cac:AccountingCustomerParty/cac:Party/cac:AgentParty/cac:PartyName/cbc:Name" },
            { "agentCadde", "cac:AccountingCustomerParty/cac:Party/cac:AgentParty/cac:PostalAddress/cbc:StreetName" },
            { "agentOdaNo", "cac:AccountingCustomerParty/cac:Party/cac:AgentParty/cac:PostalAddress/cbc:Room" },
            { "agentBinaNo", "cac:AccountingCustomerParty/cac:Party/cac:AgentParty/cac:PostalAddress/cbc:BuildingNumber" },
            { "agentIlce", "cac:AccountingCustomerParty/cac:Party/cac:AgentParty/cac:PostalAddress/cbc:CitySubdivisionName" },
            { "agentSemt", "cac:AccountingCustomerParty/cac:Party/cac:AgentParty/cac:PostalAddress/cbc:Region" },
            { "agentIl", "cac:AccountingCustomerParty/cac:Party/cac:AgentParty/cac:PostalAddress/cbc:CityName" },
            { "agentPostaKodu", "cac:AccountingCustomerParty/cac:Party/cac:AgentParty/cac:PostalAddress/cbc:PostalZone" },
            { "agentUlkeKodu", "cac:AccountingCustomerParty/cac:Party/cac:AgentParty/cac:PostalAddress/cac:Country/cbc:IdentificationCode" },
            { "agentUlkeAdi", "cac:AccountingCustomerParty/cac:Party/cac:AgentParty/cac:PostalAddress/cac:Country/cbc:Name" }

        };

        public Dictionary<string, string> FaturaOzellikleri = new Dictionary<string, string>()
        {
            { "UUID", "cbc:UUID"},
            { "ozellestirmeNo", "cbc:CustomizationID"},
            { "senaryo", "cbc:ProfileID"},
            { "faturaTipi", "cbc:InvoiceTypeCode"},
            { "faturaNo", "cbc:ID"},
            { "faturaTarihi", "cbc:IssueDate"},
            { "faturaPcn", "cbc:DocumentCurrencyCode" }
        };

        public Dictionary<string, string> FaturaIcerik = new Dictionary<string, string>()
        {
            {"siraNo", "cbc:ID" },
            {"miktar", "cbc:InvoicedQuantity" },
            {"birimFiyat", "cac:Price/cbc:PriceAmount" },
            {"urunHizmetAdi", "cac:Item/cbc:Name" },
            {"urunHizmetTanim", "cac:Item/cbc:Description" },
            {"urunHizmetTutar", "cac:TaxTotal/cac:TaxSubtotal/cbc:TaxableAmount" },
            {"kdvOran", "cac:TaxTotal/cac:TaxSubtotal/cbc:Percent" },
            {"kdvTutar", "cac:TaxTotal/cac:TaxSubtotal/cbc:TaxAmount" }
        };

        public Dictionary<string, string> FaturaToplamlari = new Dictionary<string, string>()
        {
            {"malHizmetToplamtutar", "cac:TaxTotal/cac:TaxSubtotal/cbc:TaxableAmount" },
            {"hesaplananKdv", "cac:TaxTotal/cac:TaxSubtotal/cbc:TaxAmount" },
            {"kdvOran", "cac:TaxTotal/cac:TaxSubtotal/cbc:Percent" },
            {"indirimTutari", "cac:LegalMonetaryTotal/cbc:AllowanceTotalAmount" },
            {"tahsilEdilen", "cac:LegalMonetaryTotal/cbc:ChargeTotalAmount" },
            {"odenecekTutar", "cac:LegalMonetaryTotal/cbc:PayableAmount" }
        };

        public Dictionary<string, string> FHASH = new Dictionary<string, string>()
        {
            {"digestValue", "ext:UBLExtensions/ext:UBLExtension/ext:ExtensionContent" }
        };
    }
}

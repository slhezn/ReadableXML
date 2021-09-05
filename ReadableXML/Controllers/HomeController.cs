using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReadableXML.Data;
using ReadableXML.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;

namespace ReadableXML.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(IFormFile files)
        {
            if (files != null)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\xmls", files.FileName);

                using (FileStream stream = new FileStream(path, FileMode.Create))
                {
                    await files.CopyToAsync(stream);
                }

                XmlDocument doc = new XmlDocument();
                doc.Load(path);

                XmlNamespaceManager manager = new XmlNamespaceManager(doc.NameTable);
                manager.AddNamespace("cbc", "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2");
                manager.AddNamespace("cac", "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2");
                manager.AddNamespace("qdt", "urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2");
                manager.AddNamespace("xsd", "http://www.w3.org/2001/XMLSchema");
                manager.AddNamespace("udt", "urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2");
                manager.AddNamespace("ccts", "urn:un:unece:uncefact:documentation:2");
                manager.AddNamespace("ext", "urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2");
                manager.AddNamespace("", "urn:oasis:names:specification:ubl:schema:xsd:Invoice-2");

                XmlNode xmlElement = doc.DocumentElement;

                XmlNodeList invoiceLine = doc.SelectNodes("//cac:InvoiceLine", manager);
                XmlNodeList notes = doc.SelectNodes("//cbc:Note", manager);

                ComponentsDictionary componentsDictionary = new ComponentsDictionary();

                static string DegeriAl(XmlNamespaceManager manager, XmlNode xmlElement, string yol)
                {
                    XmlNode gelenElement = xmlElement.SelectSingleNode(yol, manager);

                    return gelenElement != null ? gelenElement.InnerText : string.Empty;
                }

                List<FaturaIcerik> faturaIceriks = new List<FaturaIcerik>();
                List<string> otherNotes = new List<string>();

                Invoice invoice = new Invoice()
                {
                    Tedarikci = new Tedarikci()
                    {
                        Unvan = DegeriAl(manager, xmlElement, componentsDictionary.Tedarikci["unvan"]),
                        AdresId = DegeriAl(manager, xmlElement, componentsDictionary.Tedarikci["adresId"]),
                        AdresCadde = DegeriAl(manager, xmlElement, componentsDictionary.Tedarikci["adresCadde"]),
                        AdresOdaNo = DegeriAl(manager, xmlElement, componentsDictionary.Tedarikci["adresOdaNo"]),
                        AdresBinaAdi = DegeriAl(manager, xmlElement, componentsDictionary.Tedarikci["adresBinaAdi"]),
                        AdresBinaNo = DegeriAl(manager, xmlElement, componentsDictionary.Tedarikci["adresBinaNo"]),
                        AdresIlce = DegeriAl(manager, xmlElement, componentsDictionary.Tedarikci["adresIlce"]),
                        AdresSemt = DegeriAl(manager, xmlElement, componentsDictionary.Tedarikci["adresSemt"]),
                        AdresIl = DegeriAl(manager, xmlElement, componentsDictionary.Tedarikci["adresIl"]),
                        AdresPostaKodu = DegeriAl(manager, xmlElement, componentsDictionary.Tedarikci["adresPostaKodu"]),
                        AdresUlkeKodu = DegeriAl(manager, xmlElement, componentsDictionary.Tedarikci["adresUlkeKodu"]),
                        AdresUlkeAdi = DegeriAl(manager, xmlElement, componentsDictionary.Tedarikci["adresUlkeAdi"]),
                        IletisimKisiAd = DegeriAl(manager, xmlElement, componentsDictionary.Tedarikci["iletisimKisiAd"]),
                        IletisimKisiSoyad = DegeriAl(manager, xmlElement, componentsDictionary.Tedarikci["iletisimKisiSoyad"]),
                        IletisimTelefon = DegeriAl(manager, xmlElement, componentsDictionary.Tedarikci["iletisimTelefon"]),
                        IletisimEmail = DegeriAl(manager, xmlElement, componentsDictionary.Tedarikci["iletisimEmail"]),
                        IletisimFax = DegeriAl(manager, xmlElement, componentsDictionary.Tedarikci["iletisimFax"]),
                        IletisimWeb = DegeriAl(manager, xmlElement, componentsDictionary.Tedarikci["iletisimWeb"]),
                        VergiDairesi = DegeriAl(manager, xmlElement, componentsDictionary.Tedarikci["vergiDairesi"]),
                        Vkn = DegeriAl(manager, xmlElement, componentsDictionary.Tedarikci["vkn"]),
                        TicaretSicilNo = DegeriAl(manager, xmlElement, componentsDictionary.Tedarikci["ticaretSicilNo"]),
                        MersisNo = DegeriAl(manager, xmlElement, componentsDictionary.Tedarikci["mersisNo"]),
                        Tckn = DegeriAl(manager, xmlElement, componentsDictionary.Tedarikci["tckn"]),
                    },

                    Musteri = new Musteri()
                    {
                        Unvan = DegeriAl(manager, xmlElement, componentsDictionary.Musteri["unvan"]),
                        FirstName = DegeriAl(manager, xmlElement, componentsDictionary.Musteri["firstName"]),
                        FamilyName = DegeriAl(manager, xmlElement, componentsDictionary.Musteri["familyName"]),
                        AdresId = DegeriAl(manager, xmlElement, componentsDictionary.Musteri["adresId"]),
                        AdresCadde = DegeriAl(manager, xmlElement, componentsDictionary.Musteri["adresCadde"]),
                        AdresOdaNo = DegeriAl(manager, xmlElement, componentsDictionary.Musteri["adresOdaNo"]),
                        AdresBinaAdi = DegeriAl(manager, xmlElement, componentsDictionary.Musteri["adresBinaAdi"]),
                        AdresBinaNo = DegeriAl(manager, xmlElement, componentsDictionary.Musteri["adresBinaNo"]),
                        AdresIlce = DegeriAl(manager, xmlElement, componentsDictionary.Musteri["adresIlce"]),
                        AdresSemt = DegeriAl(manager, xmlElement, componentsDictionary.Musteri["adresSemt"]),
                        AdresIl = DegeriAl(manager, xmlElement, componentsDictionary.Musteri["adresIl"]),
                        AdresPostaKodu = DegeriAl(manager, xmlElement, componentsDictionary.Musteri["adresPostaKodu"]),
                        AdresUlkeKodu = DegeriAl(manager, xmlElement, componentsDictionary.Musteri["adresUlkeKodu"]),
                        AdresUlkeAdi = DegeriAl(manager, xmlElement, componentsDictionary.Musteri["adresUlkeAdi"]),
                        IletisimKisiAd = DegeriAl(manager, xmlElement, componentsDictionary.Musteri["iletisimKisiAd"]),
                        IletisimKisiSoyad = DegeriAl(manager, xmlElement, componentsDictionary.Musteri["iletisimKisiSoyad"]),
                        IletisimTelefon = DegeriAl(manager, xmlElement, componentsDictionary.Musteri["iletisimTelefon"]),
                        IletisimEmail = DegeriAl(manager, xmlElement, componentsDictionary.Musteri["iletisimEmail"]),
                        IletisimFax = DegeriAl(manager, xmlElement, componentsDictionary.Musteri["iletisimFax"]),
                        IletisimWeb = DegeriAl(manager, xmlElement, componentsDictionary.Musteri["iletisimWeb"]),
                        VergiDairesi = DegeriAl(manager, xmlElement, componentsDictionary.Musteri["vergiDairesi"]),
                        Vkn = DegeriAl(manager, xmlElement, componentsDictionary.Musteri["vkn"]),
                        TicaretSicilNo = DegeriAl(manager, xmlElement, componentsDictionary.Musteri["ticaretSicilNo"]),
                        MersisNo = DegeriAl(manager, xmlElement, componentsDictionary.Musteri["mersisNo"]),
                        AgentMusteriNo = DegeriAl(manager, xmlElement, componentsDictionary.Musteri["agentMusteriNo"]),
                        AgentMusteri = DegeriAl(manager, xmlElement, componentsDictionary.Musteri["agentMusteri"]),
                        AgentCadde = DegeriAl(manager, xmlElement, componentsDictionary.Musteri["agentCadde"]),
                        AgentOdaNo = DegeriAl(manager, xmlElement, componentsDictionary.Musteri["agentOdaNo"]),
                        AgentBinaNo = DegeriAl(manager, xmlElement, componentsDictionary.Musteri["agentBinaNo"]),
                        AgentIlce = DegeriAl(manager, xmlElement, componentsDictionary.Musteri["agentIlce"]),
                        AgentSemt = DegeriAl(manager, xmlElement, componentsDictionary.Musteri["agentSemt"]),
                        AgentIl = DegeriAl(manager, xmlElement, componentsDictionary.Musteri["agentIl"]),
                        AgentPostaKodu = DegeriAl(manager, xmlElement, componentsDictionary.Musteri["agentPostaKodu"]),
                        AgentUlkeKodu = DegeriAl(manager, xmlElement, componentsDictionary.Musteri["agentUlkeKodu"]),
                        AgentUlkeAdi = DegeriAl(manager, xmlElement, componentsDictionary.Musteri["agentUlkeAdi"]),

                    },

                    FaturaOzellikleri = new FaturaOzellikleri()
                    {
                        UUID = DegeriAl(manager, xmlElement, componentsDictionary.FaturaOzellikleri["UUID"]),
                        OzellestirmeNo = DegeriAl(manager, xmlElement, componentsDictionary.FaturaOzellikleri["ozellestirmeNo"]),
                        Senaryo = DegeriAl(manager, xmlElement, componentsDictionary.FaturaOzellikleri["senaryo"]),
                        FaturaTipi = DegeriAl(manager, xmlElement, componentsDictionary.FaturaOzellikleri["faturaTipi"]),
                        FaturaNo = DegeriAl(manager, xmlElement, componentsDictionary.FaturaOzellikleri["faturaNo"]),
                        FaturaTarihi = DegeriAl(manager, xmlElement, componentsDictionary.FaturaOzellikleri["faturaTarihi"]),
                        FaturaPcn = DegeriAl(manager, xmlElement, componentsDictionary.FaturaOzellikleri["faturaPcn"])
                    },

                    FaturaToplamlari = new FaturaToplamlari
                    {
                        MalHizmetToplamtutar = DegeriAl(manager, xmlElement, componentsDictionary.FaturaToplamlari["malHizmetToplamtutar"]),
                        HesaplananKdv = DegeriAl(manager, xmlElement, componentsDictionary.FaturaToplamlari["hesaplananKdv"]),
                        KdvOran = DegeriAl(manager, xmlElement, componentsDictionary.FaturaToplamlari["kdvOran"]),
                        IndirimTutari = DegeriAl(manager, xmlElement, componentsDictionary.FaturaToplamlari["indirimTutari"]),
                        TahsilEdilen = DegeriAl(manager, xmlElement, componentsDictionary.FaturaToplamlari["tahsilEdilen"]),
                        OdenecekTutar = DegeriAl(manager, xmlElement, componentsDictionary.FaturaToplamlari["odenecekTutar"]),
                    },

                    FaturaIcerik = faturaIceriks,

                    OtherNotes = otherNotes
                };

                for (int line = 0; line < invoiceLine.Count; line++)
                {
                    faturaIceriks.Add(new FaturaIcerik()
                    {
                        SiraNo = DegeriAl(manager, invoiceLine.Item(line), componentsDictionary.FaturaIcerik["siraNo"]),
                        Miktar = DegeriAl(manager, invoiceLine.Item(line), componentsDictionary.FaturaIcerik["miktar"]),
                        BirimFiyat = DegeriAl(manager, invoiceLine.Item(line), componentsDictionary.FaturaIcerik["birimFiyat"]),
                        UrunHizmetAdi = DegeriAl(manager, invoiceLine.Item(line), componentsDictionary.FaturaIcerik["urunHizmetAdi"]),
                        UrunHizmetTanim = DegeriAl(manager, invoiceLine.Item(line), componentsDictionary.FaturaIcerik["urunHizmetTanim"]),
                        UrunHizmetTutar = DegeriAl(manager, invoiceLine.Item(line), componentsDictionary.FaturaIcerik["urunHizmetTutar"]),
                        KdvOran = DegeriAl(manager, invoiceLine.Item(line), componentsDictionary.FaturaIcerik["kdvOran"]),
                        KdvTutar = DegeriAl(manager, invoiceLine.Item(line), componentsDictionary.FaturaIcerik["kdvTutar"])
                    });
                }

                for (int note = 0; note < notes.Count; note++)
                {
                    otherNotes.Add(notes.Item(note).InnerText);
                }

                try
                {
                    ViewBag.HASH = xmlElement.SelectSingleNode(componentsDictionary.FHASH["digestValue"], manager).FirstChild.FirstChild.LastChild.LastChild.InnerText ?? "";
                }
                catch (System.Exception)
                {

                    ViewBag.HASH = "";
                }

                return View(invoice);
            }

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

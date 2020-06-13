using OsnovnaSkola;
using OsnovnaSkola.DataAccess;
using OsnovnaSkolaPL.Interfaces;
using OsnovnaSkolaPL.IntermediaryModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsnovnaSkolaPL.Services
{
    public class KontrolneTackeService : IKontrolneTacke
    {
        private static DomaciDAO domaciDAO = new DomaciDAO();
        private static KontrolniDAO kontrolniDAO = new KontrolniDAO();

        public bool AddDomaci(DomaciIM domaci)
        {
            Domaci d = new Domaci()
            {
                ZaposleniId_zaposlenog = domaci.ZaposleniId_zaposlenog,
                dan_predaje = domaci.dan_predaje,
                dan_zadavanja = domaci.dan_zadavanja,
                zadatak = domaci.zadatak,
            };

            return domaciDAO.Insert(d);
        }

        public bool AddKontrolni(KontrolniIM kontrolni)
        {
            Kontrolni k = new Kontrolni()
            {
                ZaposleniId_zaposlenog = kontrolni.ZaposleniId_zaposlenog,
                datum_odrzavanja = kontrolni.datum_odrzavanja,
                zadatak = kontrolni.zadatak
            };

            return kontrolniDAO.Insert(k);
        }

        public bool ChangeDomaci(DomaciIM domaci)
        {
            Domaci d = domaciDAO.FindById(domaci.Id_kontrolne_tacke);
            d.dan_predaje = domaci.dan_predaje;
            d.dan_zadavanja = domaci.dan_zadavanja;
            d.zadatak = domaci.zadatak;

            return domaciDAO.Update(d);
        }

        public bool ChangeKontrolni(KontrolniIM kontrolni)
        {
            Kontrolni k = kontrolniDAO.FindById(kontrolni.Id_kontrolne_tacke);
            k.datum_odrzavanja = kontrolni.datum_odrzavanja;
            k.zadatak = kontrolni.zadatak;

            return kontrolniDAO.Update(k);
        }

        public bool DeleteDomaci(int domaciID)
        {
            return domaciDAO.Delete(domaciID);
        }

        public bool DeleteKontrolni(int kontrolniId)
        {
            return kontrolniDAO.Delete(kontrolniId);
        }

        public DomaciIM GetDomaciById(int domaciID)
        {
            Domaci d =  domaciDAO.FindById(domaciID);
            return new DomaciIM()
            {
                Id_kontrolne_tacke = d.Id_kontrolne_tacke,
                zadatak = d.zadatak,
                dan_predaje = d.dan_predaje,
                dan_zadavanja = d.dan_zadavanja,
                ZaposleniId_zaposlenog = d.ZaposleniId_zaposlenog
            };
        }

        public KontrolniIM GetKontrolniById(int kontrolniID)
        {
            Kontrolni k = kontrolniDAO.FindById(kontrolniID);
            return new KontrolniIM()
            {
                Id_kontrolne_tacke = k.Id_kontrolne_tacke,
                zadatak = k.zadatak,
                datum_odrzavanja = k.datum_odrzavanja,
                ZaposleniId_zaposlenog = k.ZaposleniId_zaposlenog
            };
        }

        public List<KontrolnaTackaIM> GetKTForZaposleni(int idZaposlenog)
        {
            List<Kontrolni> listaK = kontrolniDAO.GetAll().Where(k => k.ZaposleniId_zaposlenog == idZaposlenog).ToList();
            List<Domaci> listaD = domaciDAO.GetAll().Where(d => d.ZaposleniId_zaposlenog == idZaposlenog).ToList();

            List<KontrolnaTackaIM> retVal = new List<KontrolnaTackaIM>();

            foreach(var item in listaK)
            {
                if (item != null)
                    retVal.Add(new KontrolnaTackaIM() { Id_kontrolne_tacke = item.Id_kontrolne_tacke, datum = item.datum_odrzavanja, zadatak = item.zadatak, ZaposleniId_zaposlenog = item.ZaposleniId_zaposlenog , Domaci = false});
            }

            foreach(var item in listaD)
            {
                if (item != null)
                {
                    retVal.Add(new KontrolnaTackaIM() { ZaposleniId_zaposlenog = item.ZaposleniId_zaposlenog, datum = item.dan_zadavanja, zadatak = item.zadatak, Id_kontrolne_tacke = item.Id_kontrolne_tacke , Domaci = true});
                }
            }
            return retVal;
        }
    }
}

using OsnovnaSkola;
using OsnovnaSkola.DataAccess;
using OsnovnaSkolaPL.Interfaces;
using OsnovnaSkolaPL.IntermediaryModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

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
            try
            {
                using (var db = new ModelOsnovnaSkolaContainer())
                {
                    Domaci d = (Domaci)db.Kontrolna_tacka.SingleOrDefault(x => x.Id_kontrolne_tacke == domaciID);
                    List<Radi> dRadi = db.Rade.Where(x => x.Kontrolna_tackaId_kontrolne_tacke == domaciID).ToList();

                    foreach (var item in dRadi)
                    {
                        db.Entry(item).State = EntityState.Deleted;
                    }
                    db.SaveChanges();

                    db.Entry(d).State = EntityState.Deleted;
                    db.SaveChanges();
                    return true;
                }
            }catch(Exception e)
            {
                Console.WriteLine("Message:\n" +e.Message + "\nTrace:\n\n"+e.StackTrace + "\nInner:\n\n"+e.InnerException);
                return false;
            }
            
            
        }

        public bool DeleteKontrolni(int kontrolniId)
        {
            using(var db = new ModelOsnovnaSkolaContainer())
            {
                Kontrolni k = (Kontrolni)db.Kontrolna_tacka.SingleOrDefault(x => x.Id_kontrolne_tacke == kontrolniId);
                List<Radi> kRadi = db.Rade.Where(x => x.Kontrolna_tackaId_kontrolne_tacke == kontrolniId).ToList();

                foreach (var item in kRadi)
                {
                    db.Entry(item).State = EntityState.Deleted;
                }
                db.SaveChanges();

                db.Entry(k).State = EntityState.Deleted;
                db.SaveChanges();
                return true;
            }
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

            List<Domaci> domaci = domaciDAO.GetAll().ToList();
            List<Kontrolni> kontrolni = kontrolniDAO.GetAll().ToList();
            //using(var db = new ModelOsnovnaSkolaContainer())
            //{
            //    List<GetKontrolnuTackuAndRadeForZaposleni_Result> list = db.GetKontrolnuTackuAndRadeForZaposleni(idZaposlenog).ToList();
            //    List<KontrolnaTackaIM> retVal = new List<KontrolnaTackaIM>();

            //    bool isDomaci;

            //    foreach (var item in list)
            //    {
            //        isDomaci = domaci.Any(x => x.Id_kontrolne_tacke == item.Id_kontrolne_tacke);
            //        retVal.Add(new KontrolnaTackaIM() { zadatak = item.zadatak, Id_kontrolne_tacke = (int)item.Id_kontrolne_tacke, Domaci = isDomaci});
            //    }
            //    return retVal;
            //}

            List<KontrolnaTackaIM> retVal = new List<KontrolnaTackaIM>();

            foreach(var item in domaci)
            {
                retVal.Add(new KontrolnaTackaIM() { Domaci = true, Id_kontrolne_tacke = item.Id_kontrolne_tacke, zadatak = item.zadatak, ZaposleniId_zaposlenog = item.ZaposleniId_zaposlenog });
            }

            foreach(var item in kontrolni)
            {
                retVal.Add(new KontrolnaTackaIM() { Domaci = false, Id_kontrolne_tacke = item.Id_kontrolne_tacke, zadatak = item.zadatak, ZaposleniId_zaposlenog = item.ZaposleniId_zaposlenog });
            }

            return retVal;
        }


    }
}

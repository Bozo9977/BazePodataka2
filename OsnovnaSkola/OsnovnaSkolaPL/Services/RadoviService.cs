using OsnovnaSkola;
using OsnovnaSkola.DataAccess;
using OsnovnaSkolaPL.Interfaces;
using OsnovnaSkolaPL.IntermediaryModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsnovnaSkolaPL.Services
{
    public class RadoviService : IRadovi
    {
        private static RadiDAO dao = new RadiDAO();
        private static DomaciDAO domaciDao = new DomaciDAO();
        public bool ChangeRad(RadiIM rad)
        {
            try
            {
                using (var db = new ModelOsnovnaSkolaContainer())
                {
                    Radi r = db.Rade.SingleOrDefault(x => x.Kontrolna_tackaId_kontrolne_tacke == rad.Kontrolna_tackaId_kontrolne_tacke && x.UcenikId_ucenika == rad.UcenikId_ucenika && x.ZaposleniId_zaposlenog == rad.ZaposleniId_zaposlenog);
                    r.ocena = rad.ocena;

                    db.Entry(r).State = EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
            }catch(Exception e)
            {
                
                return false;
            }
            
        }

        public List<RadiIM> GetRadoviForKontrolnaTacka(int idZaposlenog, int idKT)
        {
           

            List<Domaci> domaci = domaciDao.GetAll().ToList();

            using (var db = new ModelOsnovnaSkolaContainer())
            {
                List<GetKontrolnuTackuAndRadeForZaposleniAndKontrolnaTacka_Result> list = db.GetKontrolnuTackuAndRadeForZaposleniAndKontrolnaTacka(idZaposlenog, idKT).ToList();
                List<RadiIM> retVal = new List<RadiIM>();

                foreach (var item in list)
                {
                    
                    retVal.Add(new RadiIM() { Kontrolna_tackaId_kontrolne_tacke=(int)item.Id_kontrolne_tacke, ocena = (short)item.ocena, zadatak = item.zadatak, UcenikId_ucenika = (int)item.UcenikId_ucenika, ZaposleniId_zaposlenog = (int)item.ZaposleniId_zaposlenog});
                }
                return retVal;
            }

        }
    }
}

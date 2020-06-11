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
    public class PredmetiService : IPredmeti
    {
        private static PredmetDAO dao = new PredmetDAO();
        public bool AddPredmet(PredmetIM predmet)
        {
            Predmet toAdd = new Predmet()
            {
                broj_oblasti = predmet.broj_oblasti,
                naziv = predmet.naziv,
                razred = predmet.razred,
                
            };
            return dao.Insert(toAdd);
        }

        public List<OblastIM> GetOblastiForPRedmet(int id)
        {
            List<Oblast> lista = dao.GetOblastiForPredmet(id);
            List<OblastIM> retVal = new List<OblastIM>();
            foreach(var item in lista)
            {
                retVal.Add(new OblastIM() { Id_oblasti = item.Id_oblasti, naziv = item.naziv, PredmetId_predmeta = item.PredmetId_predmeta });
            }
            return retVal;
        }

        public List<PredmetIM> GetPredmeti()
        {
            List<Predmet> lista = dao.GetAll();
            List<PredmetIM> retVal = new List<PredmetIM>();
            foreach(var item in lista)
            {
                retVal.Add(new PredmetIM() { naziv = item.naziv, razred = item.razred, broj_oblasti = item.broj_oblasti, Id_predmeta = item.Id_predmeta });
            }
            return retVal;
        }
    }
}

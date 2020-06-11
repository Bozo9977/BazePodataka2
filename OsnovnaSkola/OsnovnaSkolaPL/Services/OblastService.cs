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
    public class OblastService : IOblast
    {
        private static OblastDAO dao = new OblastDAO();
        public bool AddOblast(OblastIM oblast)
        {
            Oblast o = new Oblast() { naziv = oblast.naziv, PredmetId_predmeta = oblast.PredmetId_predmeta };
            return dao.Insert(o);
        }

        public bool ChangeOblast(OblastIM oblast)
        {
            Oblast o = dao.FindById(oblast.Id_oblasti);
            o.naziv = oblast.naziv;
            return dao.Update(o);
        }

        public bool DeleteOblast(OblastIM oblast)
        {
            //Oblast o = dao.FindById(oblast.Id_oblasti);
            return dao.Delete(oblast.Id_oblasti);
        }

        public List<OblastIM> GetAllOblast()
        {
            List<Oblast> lista = dao.GetAll();
            List<OblastIM> retVal = new List<OblastIM>();
            foreach(var item in lista)
            {
                retVal.Add(new OblastIM() { Id_oblasti = item.Id_oblasti, naziv = item.naziv, PredmetId_predmeta = item.PredmetId_predmeta });
            }
            return retVal;
        }
    }
}

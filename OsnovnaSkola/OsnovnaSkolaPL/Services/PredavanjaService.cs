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
    public class PredavanjaService : IPredavanja
    {
        private static PredavanjeDAO dao = new PredavanjeDAO();
        public bool AddPredavanjeForZaposleni(/*ZaposleniIM zaposleni,*/ PredavanjeIM predavanje)
        {
            Predavanje p = new Predavanje()
            {
                datum_odrzavanja = predavanje.datum_odrzavanja,
                OblastId_oblasti = predavanje.OblastId_oblasti,
                ZaposleniId_zaposlenog = predavanje.ZaposleniId_zaposlenog,
                opis = predavanje.opis,
            };
            return dao.Insert(p);
        }

        public bool ChangePredavanje(PredavanjeIM predavanje)
        {
            Predavanje p = dao.FindById(predavanje.Id_predavanja);
            p.opis = predavanje.opis;
            p.datum_odrzavanja = predavanje.datum_odrzavanja;

            return dao.Update(p);
        }

        public bool DeletePredavanje(PredavanjeIM predavanje)
        {
            return dao.Delete(predavanje.Id_predavanja);
        }

        public List<PredavanjeIM> GetPredavanjaForZaposleni(ZaposleniIM zaposleni)
        {
            List<Predavanje> lista = dao.FindByZaposleniId(zaposleni.Id_zaposlenog).ToList();
            List<PredavanjeIM> retVal = new List<PredavanjeIM>();
           
            foreach(var item in lista)
            {
                if (item != null)
                    retVal.Add(new PredavanjeIM() { datum_odrzavanja = item.datum_odrzavanja, Id_predavanja = item.Id_predavanja, OblastId_oblasti = item.OblastId_oblasti, opis = item.opis, ZaposleniId_zaposlenog = item.ZaposleniId_zaposlenog });
            }

            return retVal;
        }
    }
}

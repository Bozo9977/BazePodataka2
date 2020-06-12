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
    public class CasService : ICasovi
    {
        private static CasDAO dao = new CasDAO();
        public bool AddCas(CasIM cas)
        {
            Cas c = new Cas()
            {
                datum=cas.datum,
                pocetak=cas.pocetak,
                kraj = cas.kraj,
                OblastId_oblasti = cas.OblastId_oblasti,
                ZaposleniId_zaposlenog = cas.ZaposleniId_zaposlenog,
            };
            return dao.Insert(c);
        }

        public bool ChangeCas(CasIM cas)
        {
            Cas c = dao.FindById(cas.Id_casa);
            c.pocetak = cas.pocetak;
            c.kraj = cas.kraj;
            c.datum = cas.datum;

            return dao.Update(c);
            
        }

        public bool DeleteCas(int idCasa)
        {
            return dao.Delete(idCasa);
        }

        public List<CasIM> GetCasoviForZaposleni(int idZaposlenog)
        {
            List<Cas> lista = dao.FindByZaposleniId(idZaposlenog);
            List<CasIM> retVal = new List<CasIM>();

            foreach(var item in lista)
            {
                retVal.Add(new CasIM() { datum = item.datum, Id_casa = item.Id_casa, kraj = item.kraj, pocetak = item.pocetak, OblastId_oblasti = item.OblastId_oblasti, ZaposleniId_zaposlenog = item.ZaposleniId_zaposlenog });
            }

            return retVal;
        }
    }
}

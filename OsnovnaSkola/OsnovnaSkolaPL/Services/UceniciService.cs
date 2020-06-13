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
    public class UceniciService : IUcenici
    {
        private static UcenikDAO dao = new UcenikDAO();

        public bool AddOdeljenjeUceniku(UcenikIM ucenik, OdeljenjeIM odeljenje)
        {
            return dao.DodajOdeljenje(ucenik.Id_ucenika, odeljenje.Id_odeljenja);
        }

        public bool AddUcenik(UcenikIM newUcenik)
        {
            Ucenik ucenik = new Ucenik()
            {
                ime = newUcenik.ime,
                prezime = newUcenik.prezime,

            };

            return dao.Insert(ucenik);

        }

        public bool ChangeUcenik(UcenikIM ucenik)
        {
            Ucenik toChange = dao.FindById(ucenik.Id_ucenika);
            toChange.ime = ucenik.ime;
            toChange.prezime = ucenik.prezime;
            return dao.Update(toChange);
        }

        public bool DeleteUcenik(int id)
        {
            return dao.Delete(id);
        }

        public List<UcenikIM> GetIcenici()
        {
            List<Ucenik> ucenici = dao.GetAll();
            List<UcenikIM> retVal = new List<UcenikIM>();

            foreach(var item in ucenici)
            {
                retVal.Add(new UcenikIM() { ime = item.ime, prezime = item.prezime, Id_ucenika = item.Id_ucenika });
            }

            return retVal;
        }
    }
}

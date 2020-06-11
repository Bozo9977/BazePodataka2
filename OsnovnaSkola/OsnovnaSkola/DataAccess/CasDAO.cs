using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsnovnaSkola.DataAccess
{
    public class CasDAO: RepoAccess<Cas>
    {
        public List<Cas> FindByZaposleniId(int idZaposlenog)
        {
            using(var db = new ModelOsnovnaSkolaContainer())
            {
                Zaposleni zaposleni = db.Zaposlenici.Find(idZaposlenog);
                if(zaposleni != null)
                {
                    return zaposleni.Casovi.ToList();
                }
                return new List<Cas>();
            }
        }
    }
}

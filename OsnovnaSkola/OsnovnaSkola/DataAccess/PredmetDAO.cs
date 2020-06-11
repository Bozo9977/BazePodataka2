using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsnovnaSkola.DataAccess
{
    public class PredmetDAO: RepoAccess<Predmet>
    {
        public override List<Predmet> GetAll()
        {
            using (var db = new ModelOsnovnaSkolaContainer())
            {
                return db.Predmeti.Include(p=>p.Oblasti).ToList();
            }
        }

        public List<Oblast> GetOblastiForPredmet(int id)
        {
            using (var db = new ModelOsnovnaSkolaContainer())
            {
                return db.Oblasti.Where(o => o.PredmetId_predmeta == id).ToList();
            }
        }
    }
}

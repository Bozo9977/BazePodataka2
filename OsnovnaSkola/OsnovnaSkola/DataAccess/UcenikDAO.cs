using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace OsnovnaSkola.DataAccess
{
    public class UcenikDAO: RepoAccess<Ucenik>
    {
        public bool DodajOdeljenje(int ucenikId, int odeljenjeId)
        {
            try
            {
                using (var db = new ModelOsnovnaSkolaContainer())
                {
                    Ucenik u = db.Ucenici.Find(ucenikId);
                    Odeljenje o = db.Odeljenja.Find(odeljenjeId);

                    u.Odeljenje = o;
                    o.Ucenici.Add(u);
                    db.Entry(u).State = EntityState.Modified;
                    db.Entry(o).State = EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Message:\n" + e.Message + "\n\nTrace:\n" + e.StackTrace + "\n\nInner:\n" + e.InnerException);
                return false;
            }
        }
            
    }
}

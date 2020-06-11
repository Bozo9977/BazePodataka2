using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace OsnovnaSkola.DataAccess
{
    public class ZaposleniciDAO: RepoAccess<Zaposleni>
    {
        public bool AddPredmetToZaposleni(int zaposleniID, int predmetID)
        {
            using(var db = new ModelOsnovnaSkolaContainer())
            {
                try
                {
                    Nastavnik n = db.Zaposlenici.Find(zaposleniID) as Nastavnik;
                    Predmet p = db.Predmeti.Find(predmetID);

                    n.Predmet = p;

                    db.Entry(n).State = EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
                catch(Exception e)
                {
                    Console.WriteLine("Message:\n" + e.Message + "\n\nTrace:\n" + e.StackTrace + "\n\nInner:\n" + e.InnerException);
                    return false;
                }
                
            }
        }

        public bool ValidatePredmetAdding(int zaposleniID)
        {
            using (var db = new ModelOsnovnaSkolaContainer())
            {
                return (db.Zaposlenici.Find(zaposleniID) as Nastavnik).Predmet != null;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsnovnaSkola.DataAccess
{
    public class OdeljenjeDAO: RepoAccess<Odeljenje>
    {
        public Odeljenje FindById(int id)
        {
            using(var db = new ModelOsnovnaSkolaContainer())
            {
                return db.Odeljenja.Include(n=>n.NastavnikOdeljenjes).SingleOrDefault(o=>o.Id_odeljenja == id);
            }
        }

        public override List<Odeljenje> GetAll()
        {
            using(var db = new ModelOsnovnaSkolaContainer())
            {
                return db.Odeljenja.Include(u=>u.Ucitelj).Include(n => n.NastavnikOdeljenjes.Select(x=>x.Nastavnik)).ToList();
            }
        }

        public bool Delete(int id)
        {
            try
            {
                using (var db = new ModelOsnovnaSkolaContainer())
                {
                    Odeljenje o = db.Odeljenja.Include(n => n.NastavnikOdeljenjes).Include(u=>u.Ucenici).SingleOrDefault(x => x.Id_odeljenja == id);

                    

                    List<Ucenik> ucenici = new List<Ucenik>(o.Ucenici.ToList());
                    foreach(var item in ucenici)
                    {
                        db.Entry(item).State = EntityState.Deleted;
                    }
                    db.SaveChanges();
                    
                    List<NastavnikOdeljenje> listaN = new List<NastavnikOdeljenje>(o.NastavnikOdeljenjes.ToList());
                    for(int i =0; i< listaN.Count; i++)
                    {
                        db.Entry(listaN[i]).State = EntityState.Deleted;
                    }
                    
                    db.Entry(o).State = EntityState.Deleted;
                    db.SaveChanges();
                }
                return true;
            }catch(Exception e)
            {
                Console.WriteLine("Message:\n" + e.Message + "\n\nTrace:\n" + e.StackTrace + "\n\nInner:\n" + e.InnerException);
                return false;
            }
            
        }

        //problematicna greska pri dodavanju nastavnika jer proverava samo da li je ucitelj postojeci
        //napraviti razliku preko dodatnog param da li je dodela RAzrednog ili je dodavanje Nastavnika/ucitelja
        public bool ValidateUciteljExistance(int id)
        {
            using(var db = new ModelOsnovnaSkolaContainer())
            {
                Odeljenje o = db.Odeljenja.Find(id);
                if (o.Ucitelj != null)
                    return true;
                else
                    return false;
            }
            
        }



        public List<Odeljenje> GetOdeljenjaForZaposleni(int zaposleniID)
        {
            using (var db = new ModelOsnovnaSkolaContainer())
            {
                Zaposleni z = db.Zaposlenici.Find(zaposleniID);
                List<Odeljenje> retVal = new List<Odeljenje>();

                if (z is Ucitelj)
                {
                    retVal.Add(db.Odeljenja.SingleOrDefault(x => x.Ucitelj == (z as Ucitelj)));
                }
                else
                {
                    Nastavnik n = (z as Nastavnik);
                    foreach (var item in n.NastavnikOdeljenjes)
                    {
                        retVal.Add(db.Odeljenja.Include(u=>u.Ucitelj).Include(r=>r.NastavnikOdeljenjes.Select(x=>x.Nastavnik)).SingleOrDefault(p=>p.Id_odeljenja==item.OdeljenjeId_odeljenja));
                    }
                }

                return retVal;

            }
        }
    }
}

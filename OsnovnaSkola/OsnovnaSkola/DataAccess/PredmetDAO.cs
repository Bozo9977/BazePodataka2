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

        public override bool Delete(object id)
        {
            try
            {
                using (var db = new ModelOsnovnaSkolaContainer())
                {
                    Predmet p = db.Predmeti.Include(o => o.Oblasti).SingleOrDefault(x => x.Id_predmeta == (int)id);
                    List<Oblast> oblasti = new List<Oblast>(p.Oblasti);
                    for (int i = 0; i < oblasti.Count; i++)
                    {
                        db.Entry(oblasti[i]).State = EntityState.Deleted;
                    }
                    db.Entry(p).State = EntityState.Deleted;

                    db.SaveChanges();
                }
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine("Message:\n" + e.Message + "\n\nTrace:\n" + e.StackTrace + "\n\nInner:\n" + e.InnerException);
                return false;
            }   
        }

        public List<Predmet> GetPredmetiForZaposleni(int id)
        {
            using (var db = new ModelOsnovnaSkolaContainer())
            {
                Zaposleni z = db.Zaposlenici.SingleOrDefault(x=>x.Id_zaposlenog == id);
                
                List<Predmet> lista = new List<Predmet>();

                if(z is Nastavnik)
                {
                    Nastavnik nastavnik = db.Zaposlenici.Find(id) as Nastavnik;
                    List<Predmet> listaP = db.Predmeti.Where(p =>p.Id_predmeta == nastavnik.PredmetId_predmeta).ToList();
                    //Predmet p = db.Predmeti.SingleOrDefault(x => x.Id_predmeta ==);

                    lista.Add((z as Nastavnik).Predmet);
                }
                else
                {
                    short razred = (z as Ucitelj).Odeljenje.razred;
                    lista = db.Predmeti.Where(p => p.razred == razred).ToList();
                }

                return lista;
            }
        }


    }
}

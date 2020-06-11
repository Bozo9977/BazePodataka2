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
                    Odeljenje o = db.Odeljenja.Include(n => n.NastavnikOdeljenjes).SingleOrDefault(x => x.Id_odeljenja == id);
                    List<NastavnikOdeljenje> listaN = new List<NastavnikOdeljenje>(o.NastavnikOdeljenjes.ToList());
                    //List<Ucitelj> listaU = new List<Ucitelj>(o.Ucitelji);
                    //foreach(var item in o.NastavnikOdeljenjes)
                    //{
                    //    db.Entry(item).State = EntityState.Deleted;
                    //}
                    for(int i =0; i< listaN.Count; i++)
                    {
                        db.Entry(listaN[i]).State = EntityState.Deleted;
                    }
                    //for(int i =0; i < listaU.Count; i++)
                    //{
                        
                    //}
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
    }
}
